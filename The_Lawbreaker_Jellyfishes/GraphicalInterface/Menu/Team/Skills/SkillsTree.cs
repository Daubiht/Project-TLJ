using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;
using System.Drawing.Text;

namespace GraphicalInterface
{
    public partial class SkillsTree : UserControl
    {
        int stat;
        List<List<List<Skill>>> usedSkills = new List<List<List<Skill>>>();
        Skill currentSkill;
        Character _chara;
        bool _isShown = false;
        ToolTip _toolTip = new ToolTip();
        SkillsDisplay _SD;
        PrivateFontCollection _font;

        public SkillsTree(int statToDisplay, Character chara, SkillsDisplay SD, PrivateFontCollection font)
        {
            _chara = chara;
            stat = statToDisplay;
            _SD = SD;
            _font = font;
            InitializeComponent();
        }

        private void BSkill_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            Skill skill = (Skill)button.Tag;

            if (!_isShown)
            {
                _toolTip.Show(Infos(skill), button, e.Location);
                _isShown = true;
            }
        }
        private void BSkill_MouseOut(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Skill skill = (Skill)button.Tag;

            if (_isShown)
            {
                _toolTip.Hide(button);
                _isShown = false;
            }
        }

        private void AddSkill (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Skill skill = (Skill)button.Tag;

            if (_chara.SkillPoint <= 0)
            {
                LError.Text = "Vous n'avez pas assez de point de compétence pour apprendre ceci";
                LError.Visible = true;
            }
            else if (_chara.AddSkill(skill.Name, skill) != null)
            {
                _SD.SkillPoint.Text = _chara.SkillPoint + " restant";
                Reload();
            }
            else
            {
                LError.Text = "Impossible d'apprendre cette compétence";
                LError.Visible = true;
            }
        }

        private string Infos (Skill skill)
        {
            string info;

            info = skill.Description + Environment.NewLine;
            if (skill.Cost[1] > 0)
            {
                info += "Fatigue : " + skill.Cost[1] + Environment.NewLine;
            }
            if (skill.Cost[0] > 0)
            {
                info += "Vie : " + skill.Cost[0] + Environment.NewLine;
            }

            return info;
        }

        private void Reload ()
        {
            SkillList sl = new SkillList();
            ToolTip toolTip = new ToolTip();

            _SD.SkillPoint.Text = _chara.SkillPoint + " restant";

            PanelToCenter.Controls.Clear();
            usedSkills.Clear();

            foreach (Skill skill in sl.ObtainList.Values)
            {
                if (skill.statRequired[stat] != 0)
                {
                    int i = 0;
                    currentSkill = skill;
                    while (currentSkill.PreviousSkill != null)
                    {
                        currentSkill = currentSkill.PreviousSkill;
                        i++;
                    }

                    if (usedSkills.Count - 1 < i)
                    {
                        for (int j = usedSkills.Count - 1; j < i; j++)
                        {
                            usedSkills.Add(new List<List<Skill>>());
                        }
                    }

                    bool find = false;
                    for (int j = 0; j < usedSkills[i].Count; j++)
                    {
                        if (usedSkills[i][j][0] == skill.PreviousSkill)
                        {
                            usedSkills[i][j].Add(skill);
                            find = true;
                        }
                    }

                    if (!find)
                    {
                        List<Skill> newList = new List<Skill>();
                        newList.Add(skill.PreviousSkill);
                        newList.Add(skill);
                        usedSkills[i].Add(newList);
                    }
                }
            }

            for (int i = usedSkills.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < usedSkills[i].Count; j++)
                {
                    Panel samePrevious = new Panel();
                    for (int k = 1; k < usedSkills[i][j].Count; k++)
                    {
                        Skill skill = usedSkills[i][j][k];
                        if (i == usedSkills.Count - 1)
                        {
                            Button BSkill = new Button();

                            BSkill.Height = 50;
                            BSkill.Width = 100;
                            BSkill.Top = 100 * i;
                            BSkill.BackColor = Color.Transparent;
                            BSkill.FlatAppearance.MouseDownBackColor = Color.Transparent;
                            BSkill.FlatAppearance.MouseOverBackColor = Color.Transparent;
                            BSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                            BSkill.Font = new System.Drawing.Font(_font.Families[1], 13);
                            BSkill.Left = (k - 1) * (BSkill.Width + 5);
                            BSkill.Text = usedSkills[i][j][k].Name;
                            BSkill.Tag = usedSkills[i][j][k];
                            toolTip.SetToolTip(BSkill, Infos(skill));

                            

                            if (_chara.Skills.ContainsKey(usedSkills[i][j][k].Name))
                            {

                                BSkill.BackColor = Color.Green;
                            }
                            else if ((usedSkills[i][j][k].PreviousSkill != null && !_chara.Skills.ContainsKey(usedSkills[i][j][k].PreviousSkill.Name)) || _chara.Stats[stat] < usedSkills[i][j][k].statRequired[stat])
                            {
                                BSkill.ForeColor = Color.Gray;
                                BSkill.Click -= AddSkill;
                            }
                            else
                            {
                                BSkill.Click += AddSkill;
                            }

                            PanelToCenter.Controls.Add(BSkill);
                        }
                        else
                        {
                            bool find = false;
                            int nextSkills = 0;
                            for (int l = 0; l < usedSkills[i + 1].Count(); l++)
                            {
                                if(usedSkills[i+1][l][0] == skill)
                                {
                                    find = true;
                                    nextSkills = l;
                                }
                            }

                            if (find)
                            {
                                int minX = 1000;
                                int maxX = 0;

                                foreach (Button button in PanelToCenter.Controls)
                                {
                                    for (int count = 0; count < usedSkills[i+1][nextSkills].Count(); count++)
                                    {
                                        if (((Skill)button.Tag).Name == usedSkills[i+1][nextSkills][count].Name)
                                        {
                                            if (minX > button.Left) minX = button.Left;
                                            if (maxX < button.Right) maxX = button.Right;
                                        }
                                    }
                                    
                                }
                                Button newButton = new Button();
                                newButton.BackColor = Color.Transparent;
                                newButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
                                newButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
                                newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                                newButton.Font = new System.Drawing.Font(_font.Families[1], 13);
                                newButton.Height = 50;
                                newButton.Width = 100;
                                newButton.Top = 100 * i;
                                newButton.Left = (maxX + minX) / 2 - newButton.Width / 2;
                                newButton.Text = usedSkills[i][j][k].Name;
                                newButton.Tag = usedSkills[i][j][k];
                                toolTip.SetToolTip(newButton, Infos(skill));

                                if (_chara.Skills.ContainsKey(usedSkills[i][j][k].Name))
                                {

                                    newButton.BackColor = Color.Green;
                                }
                                else if ((usedSkills[i][j][k].PreviousSkill != null && !_chara.Skills.ContainsKey(usedSkills[i][j][k].PreviousSkill.Name)) || _chara.Stats[stat] < usedSkills[i][j][k].statRequired[stat])
                                {
                                    newButton.ForeColor = Color.Gray;
                                }
                                else
                                {
                                    newButton.Click += AddSkill;
                                }

                                

                                PanelToCenter.Controls.Add(newButton);
                            }

                            else
                            {
                                int maxX = 0;
                                foreach (Button button in PanelToCenter.Controls)
                                {
                                    for (int countI = i; countI < usedSkills.Count(); countI++)
                                    {
                                        for (int countJ = 0; countJ < usedSkills[countI].Count(); countJ++)
                                        {
                                            for (int count = 0; count < usedSkills[countI][countJ].Count(); count++)
                                            {
                                                if (((Skill)button.Tag).Name == usedSkills[countI][countJ][count].Name)
                                                {
                                                    if (maxX < button.Right) maxX = button.Right;
                                                }
                                            }
                                        }
                                    }

                                }
                                Button newButton = new Button();
                                newButton.BackColor = Color.Transparent;
                                newButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
                                newButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
                                newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                                newButton.Font = new System.Drawing.Font(_font.Families[1], 13);
                                newButton.Height = 50;
                                newButton.Width = 100;
                                newButton.Top = 100 * i;
                                newButton.Left = maxX + 40;
                                newButton.Text = usedSkills[i][j][k].Name;
                                newButton.Tag = usedSkills[i][j][k];
                                toolTip.SetToolTip(newButton, Infos(skill));

                                if (_chara.Skills.ContainsKey(usedSkills[i][j][k].Name))
                                {

                                    newButton.BackColor = Color.Green;
                                }
                                else if ((usedSkills[i][j][k].PreviousSkill != null && !_chara.Skills.ContainsKey(usedSkills[i][j][k].PreviousSkill.Name)) || _chara.Stats[stat] < usedSkills[i][j][k].statRequired[stat])
                                {
                                    newButton.ForeColor = Color.Gray;
                                }
                                else
                                {
                                    newButton.Click += AddSkill;
                                }

                               
                                PanelToCenter.Controls.Add(newButton);
                            }
                        }
                    }
                }
                PanelToCenter.Left = this.Width / 2 - PanelToCenter.Width / 2;
                Controls.Add(PanelToCenter);
            }

        }

        private void SkillsTree_Load(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
