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
        SkillList _skillList;
        int[] _statsFromScreen2; // used to reset all the basic stats to +5 if the user come back to screen 2

        // Constructor
        public CreateMainCharacter3(Character CreatedCharacter, MainForm context, int[] stat)
        {
            InitializeComponent();
            _C1 = CreatedCharacter;
            _context = context;
            _statsFromScreen2 = stat;
            _skillList = new SkillList();


            // A tooltip is a bubble where we display informations when the mouse is on a checkbox
            // One tooltip for one radio button
            ToolTip toolTipVitality = new ToolTip();
            toolTipVitality.InitialDelay = 250;
            toolTipVitality.ReshowDelay = 500;
            toolTipVitality.ShowAlways = true;
            toolTipVitality.AutoPopDelay = 32000; // We display informations during 32 seconds
            toolTipVitality.SetToolTip(RBVitality, "Passif" + Environment.NewLine + "Description :  +30 PV" + Environment.NewLine + "Coût : aucun" + Environment.NewLine +
                "Position : toutes" + Environment.NewLine + "Cible : soi-même");

            ToolTip toolTipDefensePosition = new ToolTip();
            toolTipDefensePosition.InitialDelay = 250;
            toolTipDefensePosition.ReshowDelay = 500;
            toolTipDefensePosition.ShowAlways = true;
            toolTipDefensePosition.AutoPopDelay = 32000;
            toolTipDefensePosition.SetToolTip(RBDefensePosition, "Actif" + Environment.NewLine + "Description : +5 armure pendant 3 tours" + Environment.NewLine + "Coût : 1 fatigue" + Environment.NewLine +
    "Position : toutes" + Environment.NewLine + "Cible : soi-même");

            ToolTip toolTipEffort = new ToolTip();
            toolTipEffort.InitialDelay = 250;
            toolTipEffort.ReshowDelay = 500;
            toolTipEffort.ShowAlways = true;
            toolTipEffort.AutoPopDelay = 32000;
            toolTipEffort.SetToolTip(RBEffort, "Passif" + Environment.NewLine + "Description : +2 fatigue" + Environment.NewLine + "Coût : aucun" + Environment.NewLine +
"Position : toutes" + Environment.NewLine + "Cible : soi-même");

            ToolTip toolTipConcentredHit = new ToolTip();
            toolTipConcentredHit.InitialDelay = 250;
            toolTipConcentredHit.ReshowDelay = 500;
            toolTipConcentredHit.ShowAlways = true;
            toolTipConcentredHit.AutoPopDelay = 32000;
            toolTipConcentredHit.SetToolTip(RBConcentredHit, "Actif" + Environment.NewLine + "Description : 150% attaque de base" + Environment.NewLine + "Coût : 1 fatigue" + Environment.NewLine +
"Position : toutes" + Environment.NewLine + "Cible : 1 ennemi");

            ToolTip toolTipEnergeticShot = new ToolTip();
            toolTipEnergeticShot.InitialDelay = 250;
            toolTipEnergeticShot.ReshowDelay = 500;
            toolTipEnergeticShot.ShowAlways = true;
            toolTipEnergeticShot.AutoPopDelay = 32000;
            toolTipEnergeticShot.SetToolTip(RBEnergeticShot, "Actif" + Environment.NewLine + "Description : 150% attaque magique" + Environment.NewLine + "Coût : 1 fatigue" + Environment.NewLine +
"Position : toutes" + Environment.NewLine + "Cible : 1 ennemi");

            ToolTip toolTipInstinct = new ToolTip();
            toolTipInstinct.InitialDelay = 250;
            toolTipInstinct.ReshowDelay = 500;
            toolTipInstinct.ShowAlways = true;
            toolTipInstinct.AutoPopDelay = 32000;
            toolTipInstinct.SetToolTip(RBInstinct, "Passif" + Environment.NewLine + "Description : + 3% de chance d'esquiver" + Environment.NewLine + "Coût : aucun" + Environment.NewLine +
"Position : toutes" + Environment.NewLine + "Cible : soi-même");
        }

        // _______________________ Back button _____________________
        private void buttonBack_Click(object sender, EventArgs e)
        {
            // we reset all the basic stats that screen 2 gave to screen 3, example : physical attack +25 will be reset to +5
            _C1.StatsDown(_statsFromScreen2[0]-_statsFromScreen2[6], _statsFromScreen2[1] - _statsFromScreen2[6], _statsFromScreen2[2] - _statsFromScreen2[6], _statsFromScreen2[3] - _statsFromScreen2[6], _statsFromScreen2[4] - _statsFromScreen2[6], _statsFromScreen2[5] - _statsFromScreen2[6]);
            CreateMainCharacter2 uc = new CreateMainCharacter2(_C1, _context);
            _context.ChangeUC(uc, false);
        }
        // _____________________ Next button ___________________
        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Choose the skill
            ChosenSkill();
            // Define the character as the main
            _C1.IsMain = true;

            IFormatter formatter = new BinaryFormatter();
            MapWorld w;
            using (Stream stream = new FileStream("../../../Ressources/NewWorld.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                w = (MapWorld)formatter.Deserialize(stream);
            }

            w.Team.AddMembers(_C1);
            _context.world = w;
            World uc = new World(w, _context, false);
            _context.ChangeUC(uc, true);
        }

        // Here we assign the chosen skill to the character
        private void ChosenSkill()
        {
            if (RBVitality.Checked) _C1.AddSkill(_skillList.ObtainList["Vitalité"].Name, _skillList.ObtainList["Vitalité"]);
            if (RBDefensePosition.Checked) _C1.AddSkill(_skillList.ObtainList["Position défensive"].Name, _skillList.ObtainList["Position défensive"]);
            if (RBEffort.Checked) _C1.AddSkill(_skillList.ObtainList["Infatigable"].Name, _skillList.ObtainList["Infatigable"]);
            if (RBConcentredHit.Checked) _C1.AddSkill(_skillList.ObtainList["Frappe Concentré"].Name, _skillList.ObtainList["Frappe Concentré"]);
            if (RBEnergeticShot.Checked) _C1.AddSkill(_skillList.ObtainList["Tir Energetique"].Name, _skillList.ObtainList["Tir Energetique"]);
            if (RBInstinct.Checked) _C1.AddSkill(_skillList.ObtainList["Instinct"].Name, _skillList.ObtainList["Instinct"]);
        }
    }
}
