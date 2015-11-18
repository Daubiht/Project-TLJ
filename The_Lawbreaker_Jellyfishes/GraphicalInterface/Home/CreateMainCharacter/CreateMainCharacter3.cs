using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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

            ToolTip toolTipVitality = new ToolTip();
            toolTipVitality.InitialDelay = 250;
            toolTipVitality.ReshowDelay = 500;
            toolTipVitality.ShowAlways = true;
            toolTipVitality.AutoPopDelay = 32000;
            toolTipVitality.SetToolTip(RBVitality, "Passif" + Environment.NewLine + "Description :  +X PV" + Environment.NewLine + "Coût : aucun" + Environment.NewLine +
                "Position : toutes" + Environment.NewLine + "Cible : soi-même");

            ToolTip toolTipDefensePosition = new ToolTip();
            toolTipDefensePosition.InitialDelay = 250;
            toolTipDefensePosition.ReshowDelay = 500;
            toolTipDefensePosition.ShowAlways = true;
            toolTipDefensePosition.AutoPopDelay = 32000;
            toolTipDefensePosition.SetToolTip(RBDefensePosition, "Actif" + Environment.NewLine + "Description : plus X armure pendant X tours" + Environment.NewLine + "Coût : X fatigue" + Environment.NewLine +
    "Position : toutes" + Environment.NewLine + "Cible : soi-même");

            ToolTip toolTipEffort = new ToolTip();
            toolTipEffort.InitialDelay = 250;
            toolTipEffort.ReshowDelay = 500;
            toolTipEffort.ShowAlways = true;
            toolTipEffort.AutoPopDelay = 32000;
            toolTipEffort.SetToolTip(RBEffort, "Actif" + Environment.NewLine + "Description : redonne X fatigue" + Environment.NewLine + "Coût : X pv" + Environment.NewLine +
"Position : toutes" + Environment.NewLine + "Cible : soi-même");

            ToolTip toolTipConcentredHit = new ToolTip();
            toolTipConcentredHit.InitialDelay = 250;
            toolTipConcentredHit.ReshowDelay = 500;
            toolTipConcentredHit.ShowAlways = true;
            toolTipConcentredHit.AutoPopDelay = 32000;
            toolTipConcentredHit.SetToolTip(RBConcentredHit, "Actif" + Environment.NewLine + "Description : 150% attaque de base" + Environment.NewLine + "Coût : X fatigue" + Environment.NewLine +
"Position : toutes" + Environment.NewLine + "Cible : 1 ennemi");

            ToolTip toolTipEnergeticShot = new ToolTip();
            toolTipEnergeticShot.InitialDelay = 250;
            toolTipEnergeticShot.ReshowDelay = 500;
            toolTipEnergeticShot.ShowAlways = true;
            toolTipEnergeticShot.AutoPopDelay = 32000;
            toolTipEnergeticShot.SetToolTip(RBEnergeticShot, "Actif" + Environment.NewLine + "Description : 150% attaque magique" + Environment.NewLine + "Coût : X fatigue" + Environment.NewLine +
"Position : toutes" + Environment.NewLine + "Cible : 1 ennemi");

            ToolTip toolTipInstinct = new ToolTip();
            toolTipInstinct.InitialDelay = 250;
            toolTipInstinct.ReshowDelay = 500;
            toolTipInstinct.ShowAlways = true;
            toolTipInstinct.AutoPopDelay = 32000;
            toolTipInstinct.SetToolTip(RBInstinct, "Passif" + Environment.NewLine + "Description : + X% de chance d'esquiver" + Environment.NewLine + "Coût : aucun" + Environment.NewLine +
"Position : toutes" + Environment.NewLine + "Cible : soi-même");
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
