using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface.Fighting
{
    public partial class PanelCharacter : UserControl
    {
        Character _character;
        Monster _monster;
        Fight _fight;
        FightUserControl _FightUserControl;
        // _obj will contain a monster OR a character, to know if we must call fight.GetMemberWhoAttack or fight.AttackedMonster
        Object _obj;

        // CONSTRUCTORS OF PANELS, in argument we get a monster or a character object
        public PanelCharacter(Object obj, Fight Fight, FightUserControl FightUserControl)
        {
            // We need the fight user control to display on it a new fight menu
            _FightUserControl = FightUserControl;
            // We need fight to use some methods
            _fight = Fight;
            // If the object is a character, we create a character's panel
            if ( obj is Character )
            {
                _obj = obj;
                _character = (Character)obj;
                InitializeComponent();
                labelCharName.Text = _character.Name;
                labelHPResult.Text = _character.HealthPoint.ToString();
                labelStaminaResult.Text = _character.Stamina.ToString();
            }
            // if the object is a monster, we create a monster's panel
            else if ( obj is Monster)
            {
                _obj = obj;
                _monster = (Monster)obj;
                InitializeComponent();
                labelCharName.Text = _monster.Name;
                labelHPResult.Text = _monster.Health.ToString();
                labelStaminaResult.Text = _monster.Stamina.ToString();
            }
        }

        // Call the method from Fight.cs and give him the character
        private void PanelCharacter_Load(object sender, EventArgs e)
        {
            // Add an event handler to the left click
            Click += new EventHandler(SelectMemberMonster);
        }

        // Define the treatment of the left click event on a panel
        public void SelectMemberMonster(object sender, EventArgs e)
        {
            // If the player clicks on a character's panel, we create a menu which display information about the member, and change his bordel style
            if ( _obj is Character )
            {
                // Remove border style of all member's panel
                ChangeBorderStyle(false);
                // Assign a special bordel style only to the selected member 
                ChangeBorderStyle(true);
                // Create the fight menu of the selected member
                _FightUserControl.CreateFightMenu(_character);
            }

            // If the player clicks on a monster's panel, the member attacks the monster
            else if ( _obj is Monster )
            {
                if ( _fight.GetAttackedMonster(_monster) == true ) // True means "All monsters attacked, so we need to refresh the character's panels to display new HP point and stamina"
                {
                    foreach ( PanelCharacter pC in _FightUserControl.GetCharacterPanel )
                        // We refresh informations on the character's panels
                        pC.RefreshInformation();
                }
                // After the character attacked, we actualize the HP of the monster
                RefreshInformation();
                // Color the panel of members who played
                ColorPlayedCharacter();
            }
        }
        // Method who dislays actulised informations of monster and character panels, like HP, Stamina etc.
        public void RefreshInformation()
        {
            // Actualize Monster's informations
            if( _obj is Monster )
            {
                labelHPResult.Text = _monster.Health.ToString();
                labelStaminaResult.Text = _monster.Stamina.ToString();
            }
            // Actualize Member's informations
            else if (_obj is Character )
            {
                labelHPResult.Text = _character.HealthPoint.ToString();
                labelStaminaResult.Text = _character.Stamina.ToString();
            }
        }

        // Method who colors the panel of character WHO ALREADY PLAYED
        public void ColorPlayedCharacter()
        {
            foreach ( PanelCharacter p in _FightUserControl.GetCharacterPanel )
                if ( p.GetCharacter.DidMemberPlay == true )
                    p.BackColor = Color.Gray;
            else if ( p.GetCharacter.DidMemberPlay == false )
                    p.BackColor = Color.LightSkyBlue;
        }
        // Method who changes the border style of the SELECTED CHARACTER'S PANEL
        public void ChangeBorderStyle(bool DoStyle)
        {   // If false, Remove all border style of all members
            if ( DoStyle == false )
                foreach ( PanelCharacter pC in _FightUserControl.GetCharacterPanel )
                {
                    pC.BorderStyle = BorderStyle.None;
                    pC.BackColor = Color.LightSkyBlue;
                    if( pC._character.DidMemberPlay == true ) pC.BackColor = Color.Gray;
                }
            // If true, assign a special border style to the selected member's panel
            if ( DoStyle == true )
            {
                BorderStyle = BorderStyle.FixedSingle;
                BackColor = Color.SteelBlue;
            }
        }

        public Character GetCharacter{get { return _character; }}
    }
}
