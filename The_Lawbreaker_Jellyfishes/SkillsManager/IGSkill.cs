using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace SkillsManager
{
    public partial class IGSkill : UserControl
    {
        Skill _skill;
        SkillList _list;
        SkillsListe _parent;

        public IGSkill(SkillsListe parent, Skill skill, SkillList list, string name, int stat)
        {
            InitializeComponent();

            LName.Text = name;


            CBStat.SelectedIndex = stat;

            // Add Required Skill
            foreach (Skill s in list.ObtainList.Values)
            {
                if (s.statRequired != null && stat != -1 && s.statRequired[stat] != 0 && s != skill)
                {
                    CBRequiredSkill.Items.Add(s.Name);
                }

                if (s.statRequired == null && stat == -1)
                {
                    CBRequiredSkill.Items.Add(s.Name);
                }
            }

            CBRequiredSkill.Items.Add(skill.Name);

            if (stat != -1)
            {
                if (skill.statRequired[stat] == -1)
                {
                    NRequiredStatValue.Value = 0;
                }
                else
                {
                    NRequiredStatValue.Value = skill.statRequired[stat];
                }
            }

            if (skill.PreviousSkill != null)
            {
                for (int i = 0; i < CBRequiredSkill.Items.Count; i++)
                {
                    if ((string)CBRequiredSkill.Items[i] == (string)skill.PreviousSkill.Name) CBRequiredSkill.SelectedIndex = i;
                }
                
            }


            _skill = skill;
            _list = list;
            _parent = parent;

            BErase.Tag = _skill;
        }


        internal void Erase_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Skill skill = (Skill)button.Tag;

            _list.Remove(skill);
            _parent.Reload(-1);
        }

        private void IGSkill_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NRequiredStatValue_ValueChanged(object sender, EventArgs e)
        {
            int value = 0;

            if (_skill != null)
            {
                if (CBStat.SelectedIndex != -1)
                {
                    for (int i = 0; i < CBStat.Items.Count; i++)
                    {
                        if (_skill.statRequired == null) _skill.statRequired = new int[6];
                        if (CBStat.SelectedIndex == i)
                        {
                            if (NRequiredStatValue.Value == 0) value = -1;
                            else value = (int)NRequiredStatValue.Value;

                            //if (_skill.statRequired == null) _skill.statRequired = new int[6];

                            _skill.statRequired[i] = value;
                        }
                        else _skill.statRequired[i] = 0;
                    }
                }
            }
        }
    }
}
