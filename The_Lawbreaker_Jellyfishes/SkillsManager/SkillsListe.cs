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
    public partial class SkillsListe : UserControl
    {
        SkillList sl;
        public SkillsListe()
        {
            sl = new SkillList();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void Reload(int filtre)
        {
            PSkillList.Controls.Clear();

            
            int i = 0;
            int stat = 0;
            bool display;

            foreach (Skill skill in sl.ObtainList.Values)
            {
                display = false;

                if (skill.statRequired != null)
                {
                    for (int j = 0; j < skill.statRequired.Count(); j++)
                    {
                        if (skill.statRequired[j] != 0 && (j == filtre || filtre == -1))
                        {
                            stat = j;
                            display = true;
                        }
                    }
                }
                else
                {
                    if (filtre == -1)
                    {
                        stat = -1;
                        display = true;
                    }
                }

                if (display == true)
                {
                    IGSkill s = new IGSkill(this, skill, sl, skill.Name, stat);
                    s.Top = i * (s.Height + 5);

                    PSkillList.Controls.Add(s);

                    i++;
                }
            }
        }

        internal void Add_Click(object sender, EventArgs e)
        {
            int[] requiredStat = new int[6];
            requiredStat[CBRequiredStat.SelectedIndex] = int.Parse(NRequiredStatValue.Text);
            Skill skill = new Skill(TName.Text, requiredStat, 0, 0, null, null);
            if (sl.Add(skill) == null)
            {
                LError.Text = "Impossible d'ajouter ce sort. Un sort avec le même nom existe déjà.";
                LError.Visible = true;
            }
            else
            {
                LError.Visible = false;
                Reload(-1);
            }
        }

        private void SkillsListe_Load(object sender, EventArgs e)
        {
            Reload(-1);
        }

        private void CBFiltreStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reload(CBFiltreStats.SelectedIndex);
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            sl.Serializ();
            
        }
    }
}
