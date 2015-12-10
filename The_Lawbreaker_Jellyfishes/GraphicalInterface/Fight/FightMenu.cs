using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;
using System.Runtime.InteropServices;

namespace GraphicalInterface
{
    public partial class FightMenu : UserControl
    {
        FightUserControl _FUC;
        Character _selectedMember;
        MainForm _context;
        Fight _fight;
        List<PanelCharacter> _panelCharacterList;
        // CONSTUCTOR
        public FightMenu(Character selectedMember, Fight fight, MainForm context, List<PanelCharacter> PanelCharacter, FightUserControl FUC)
        {
            _FUC = FUC;
            _selectedMember = selectedMember;
            _fight = fight;
            InitializeComponent();
            _context = context;
            _panelCharacterList = PanelCharacter;

            // Display the name of the character
            labelCharName.Text = selectedMember.Name;
            // Set the X and Y location of the fight menu
            Location = new Point(0, 440-Height);
            // By default an arrow is displayd near the toolstrip, here we hide the arrows
            toolStripSkills.ShowDropDownArrow = false;
            // We set the value of the HP BAR
            progressBarHP.Maximum = selectedMember.MaxHealthPoint;
            progressBarHP.Value = selectedMember.HealthPoint;
            // We set the value of the STAMINA BAR
            progressBarStamina.Maximum = selectedMember.MaxStaminaPoint;
            progressBarStamina.Value = selectedMember.StaminaPoint;
            ModifyProgressBarColor.SetState(progressBarStamina, 2); // 1 = green, 2 = yellow, 3 = red
            // We add a left click event on the basic attack button
            toolStripAttack.Click += new EventHandler(BasicAttack);
            // We add a left click event on the defense attack button
            toolStripDefense.Click += new EventHandler(Defense);
            // We add a left click event on the run away button
            ButtonRunAway.Click += new EventHandler(RunAway);
            // We add a left click event on the inventory consumable button
            ButtonInventoryConsumable.Click += new EventHandler(AccessInventory);

        }
        // ____Method to get the character who is launching a basic attack
        public void BasicAttack(object sender, EventArgs e)
        {
            _fight.GetMemberWhoAttack(_selectedMember, null, _selectedMember.PhysicalAttack);
            _FUC.EndFight();
        }
        // ____Method to INCREASE ROBUSTNESS by X % of the member during 1 tour, X % is define the character class_____________________________
        public void Defense(object sender, EventArgs e)
        {
            // bool used in case everybody use "defense" button
            bool didAllMemberPlayed = true;
            // Given in parameters the current number turn, used to know when will finish the defense skill
            _selectedMember.Defense(_fight.NumberTurn);
            // Here we say that the member just played
            _selectedMember.DidMemberPlay = true;
            // Check if every member are in defense position
            foreach(Character c in _fight.GetTeam.Members )
                if ( c.DidMemberPlay == false )
                    didAllMemberPlayed = false;
            // If yes, it's monsters to attack the team
            if ( didAllMemberPlayed == true )
            {
                _fight.MonsterAttack();
                foreach ( PanelCharacter pC in _panelCharacterList ) pC.RefreshInformation();
            }
            _FUC.EndFight();
        }
        // ____Method to RUN AWAY
        public void RunAway(object sender, EventArgs e)
        {

            // Check if the member hasn't play yet and if he is still alvie
            if(_selectedMember.DidMemberPlay == false && _selectedMember.isAlive == true )
            {
                // All member are considered that they all played
                foreach ( Character c in _fight.GetTeam.Members )
                    c.DidMemberPlay = true;
                Random r = new Random();
                // Random number between 1 - 4
                int chanceToRunAway = r.Next(1, 5);
                // Create a screen of end fight if they succeed to run away
                if ( chanceToRunAway == 0 ) // CHANGE 0 TO 1
                {
                    EndFight endFight = new EndFight(_context);
                    _context.ChangeUC(endFight, false);
                }
                // If the team don't run away, all the monsters attack, then we color all the members in blue to signal they can play again
                else
                {
                    _fight.MonsterAttack();
                    foreach ( PanelCharacter pC in _panelCharacterList )
                        pC.RefreshInformation();
                }
            }
            // Check if all monster or all members are dead
            _FUC.EndFight();
        }
        //_____Method to open the inventory consumable during fight
        public void AccessInventory(object sender, EventArgs e)
        {
            // if the member hasn't played yet, he can open the inventory of consumable
            if(_selectedMember.DidMemberPlay == false )
            {
                FiltredInventory FIClass = new FiltredInventory(_fight.GetTeam, _selectedMember, "consommable", _context, true);
                FiltredInventoryForm FIForm = new FiltredInventoryForm(FIClass, _panelCharacterList, _fight);
                // Display the windows if the inventory consumables
                FIForm.ShowDialog();
            }
        }

        public List<PanelCharacter> PanelsMembers { get { return _panelCharacterList; } }
    }

    // Change the color of the progress bars
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }


}
