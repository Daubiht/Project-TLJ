using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class SkillsTree : UserControl
    {
        int stat;
        List<List<Skill>> usedSkills = new List<List<Skill>>();
        Skill currentSkill;
        Character _chara;

        public SkillsTree(int statToDisplay, Character chara)
        {
            _chara = chara;
            stat = statToDisplay;

            InitializeComponent();
        }

        private void AddSkill (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Skill skill = (Skill)button.Tag;

            if (_chara.AddSkill(skill.Name, skill) == null)
            {
                LError.Text = "Impossible d'apprendre cette compétence";
                LError.Visible = true;
            }

            ((SkillsDisplay)(Parent.Parent.Parent)).SkillPoint.Text = _chara.SkillPoint + " restant";

            Reload();

        }

        private void Reload ()
        {
            SkillList sl = new SkillList();

            Controls.Clear();
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
                            usedSkills.Add(new List<Skill>());
                        }
                    }
                    usedSkills[i].Add(skill);
                }
            }

            for (int i = 0; i < usedSkills.Count; i++)
            {
                for (int j = 0; j < usedSkills[i].Count; j++)
                {
                    Button BSkill = new Button();
                    BSkill.Height = 50;
                    BSkill.Width = 100;
                    BSkill.Left = j * (BSkill.Width + 5);
                    BSkill.Top = i * (BSkill.Height + 50);
                    BSkill.Text = usedSkills[i][j].Name;
                    BSkill.Tag = usedSkills[i][j];
                    if ((usedSkills[i][j].PreviousSkill != null && !_chara.Skills.ContainsKey(usedSkills[i][j].PreviousSkill.Name)) || _chara.Stats[stat] < usedSkills[i][j].statRequired[stat])
                    {
                        BSkill.Enabled = false;
                    }
                    if (_chara.Skills.ContainsKey(usedSkills[i][j].Name))
                    {

                        BSkill.BackColor = Color.Green;
                    }
                    else
                    {
                        BSkill.Click += AddSkill;
                    }


                    Controls.Add(BSkill);
                }
            }
        }

        private void SkillsTree_Load(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
