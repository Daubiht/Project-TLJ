using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class CreateMainCharacter3 : UserControl
    {

        Character _C1;
        private MainForm _context;

        // Constructor
        public CreateMainCharacter3(Character CreatedCharacter, MainForm context)
        {
            InitializeComponent();
            _C1 = CreatedCharacter;
            _context = context;
        }

        // _______________________ Back button _____________________
        private void buttonBack_Click(object sender, EventArgs e)
        {
            CreateMainCharacter2 uc = new CreateMainCharacter2(_C1, _context);
            _context.ChangeUC(uc, false);
        }
        // _____________________ Next button ___________________
        private void buttonNext_Click(object sender, EventArgs e)
        {
            int i = CheckSkillChoosen;
            _C1.IsMain = true;

            IFormatter formatter = new BinaryFormatter();
            MapWorld w;
            using (Stream stream = new FileStream("../../../Ressources/world.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                w = (MapWorld)formatter.Deserialize(stream);
            }

            w.Team.AddMembers(_C1);
            _context.world = w;
            World uc = new World(w, _context, false);
            _context.ChangeUC(uc, true);
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
