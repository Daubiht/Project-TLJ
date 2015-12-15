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
                /*if (_fight.SelectedSkill != null)
                {
                    _fight.MemberWhoIsAttacking.UseSkill(_fight.SelectedSkill, _character);
                    //_fight.StopTurnOfPlayer(_fight.MemberWhoIsAttacking);
                }
                else
                {*/
                    // Remove border style of all member's panel
                    ChangeBorderStyle(false);
                    // Assign a special bordel style only to the selected member 
                    ChangeBorderStyle(true);
                    // Create the fight menu of the selected member
                    _FightUserControl.CreateFightMenu(_character);
                //}
            }

            // If the player clicks on a monster's panel, the member attacks the monster
            else if ( _obj is Monster )
            {
                if ( _fight.GetAttackedMonster(_monster) == true ) // True means "All monsters attacked, so we need to refresh the character's panels to display new HP point and stamina"
                {
                    foreach ( PanelCharacter pC in _FightUserControl.GetCharacterPanel )
                    {
                        // We refresh informations on the character's panels
                        pC.RefreshInformation();
                        // We color all the panels character who are alive to say they can play again
                        if ( pC.GetCharacter.isAlive == true)
                            pC.BackColor = Color.LightSkyBlue;
                    }
                }
                // If the members who attack is notn null (because we just start the fight) and didn't succeed to attack because he selected the wrong monster, the selector is still on his panel
                if ( _fight.MemberWhoIsAttacking != null && _fight.MemberWhoIsAttacking.SuccedAttack == false )
                {
                    foreach (PanelCharacter p in _FightUserControl.GetCharacterPanel )
                        if ( _fight.MemberWhoIsAttacking.Name == p.GetCharacter.Name ) p.BackColor = Color.SteelBlue;
                }
                // After the character attacked, we only actualize the HP of the attacked monster
                RefreshInformation();
                // Color the panel of members who played
                ColorPlayedCharacter();
            }
        }
        // Method who dislays actulized informations of monster and character panels, like HP, Stamina etc.
        public void RefreshInformation()
        {
            _FightUserControl.EndFight();
            // Actualize Monster's informations
            if ( _obj is Monster )
            {
                labelHPResult.Text = _monster.Health.ToString();
                labelStaminaResult.Text = _monster.Stamina.ToString();
                // if the monster is dead, we color his panel in black
                if ( _monster.Alive == false ) BackColor = Color.Black;
            }
            // Actualize Member's informations
            else if (_obj is Character )
            {
                labelHPResult.Text = _character.HealthPoint.ToString();
                labelStaminaResult.Text = _character.Stamina.ToString();
                BackColor = Color.LightSkyBlue;
                if ( _character.isAlive == false ) BackColor = Color.Black;
                else if ( _character.isAlive == true ) BackColor = Color.LightSkyBlue;
            }
        }

        // Method who colors the panel of character WHO ALREADY PLAYED
        public void ColorPlayedCharacter()
        {
            foreach ( PanelCharacter p in _FightUserControl.GetCharacterPanel )
                if ( p.GetCharacter.DidMemberPlay == true && p.GetCharacter.isAlive == true)
                    p.BackColor = Color.Gray;
        }
        // Method who changes the border style of the SELECTED CHARACTER'S PANEL
        public void ChangeBorderStyle(bool DoStyle)
        {   // If false, Remove all border style of all members
            if ( DoStyle == false )
            { 
                foreach ( PanelCharacter pC in _FightUserControl.GetCharacterPanel )
                {
                    pC.BorderStyle = BorderStyle.None;
                    // If the member is DEAD, the panel is colored in BLACK
                    if ( pC.GetCharacter.isAlive == false ) pC.BackColor = Color.Black;
                    // If the member is ALIVE, the panel is colored in LIGHT
                    if ( pC.GetCharacter.isAlive == true ) pC.BackColor = Color.LightSkyBlue;
                    // If the member is ALIVE and already PLAYED, the panel is in GRAY
                    if ( pC._character.DidMemberPlay == true && pC.GetCharacter.isAlive == true ) pC.BackColor = Color.Gray;
                }
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
