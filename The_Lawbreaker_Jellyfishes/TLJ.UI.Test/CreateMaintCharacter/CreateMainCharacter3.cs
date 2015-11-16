using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace TLJ.UI.Test.CreaMaintCaracter
{
    public partial class CreateMainCharacter3 : UserControl
    {

        Character _C1;

        // Constructor
        public CreateMainCharacter3(Character CreatedCharacter)
        {
            InitializeComponent();
            _C1 = CreatedCharacter;
        }

        // _______________________ Back button _____________________
        private void buttonBack_Click(object sender, EventArgs e)
        {
            CreateMainCharacter2 cMC2 = new CreateMainCharacter2(_C1);
            Parent.Controls.Add(cMC2);
            Parent.Controls.Remove(this);
        }
        // _____________________ Next button ___________________
        private void buttonNext_Click(object sender, EventArgs e)
        {
            int i = CheckSkillChoosen;
        }

        // Check what skill the user chose
        private int CheckSkillChoosen
        {
            get
            {
                if (RBVitality.Checked) return 1;
                if (RBDefensePosition.Checked) return 2;
                if (RBEffort.Checked) return 3;
                if (RBConcentredHit.Checked) return 4;
                if (RBEnergeticShot.Checked) return 5;
                if (RBInstinct.Checked) return 6;
                return 0;
            }
        }
    }
}
