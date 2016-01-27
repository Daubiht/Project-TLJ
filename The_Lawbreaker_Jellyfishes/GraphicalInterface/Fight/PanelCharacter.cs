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
        Controller _ctrler;
        // _obj will contain a monster OR a character, to know if we must call fight.GetMemberWhoAttack or fight.AttackedMonster
        Object _obj;

        // CONSTRUCTORS OF PANELS, in argument we get a monster or a character object
        public PanelCharacter(Object obj, Fight Fight, FightUserControl FightUserControl, Controller ctrler)
        {
            _ctrler = ctrler;
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
                labelCharName.TextAlign = System.Drawing.ContentAlignment.TopCenter;

                // Height of character's panel
                Height = 50;
                Width = 62;
                panelInformation.Width = Width;
                panelInformation.Height = Height;
                panelInformation.Location = new Point(0, 0);
                labelCharName.Height = 13;
                BarHp.Visible = false;
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
                Width = Image.FromFile(@"../../../Ressources/Mob/"+_monster.Race+@"/"+_monster.Name+".png").Width + 70; 
                Height = Image.FromFile(@"../../../Ressources/Mob/" + _monster.Race + @"/" + _monster.Name + ".png").Height; 
                pictureBox1.Visible = true;

                pictureBox1.BackgroundImage = Image.FromFile(@"../../../Ressources/Mob/" + _monster.Race + @"/" + _monster.Name + ".png");
                pictureBox1.Size = new Size(Image.FromFile(@"../../../Ressources/Mob/" + _monster.Race + @"/" + _monster.Name + ".png").Width, Image.FromFile(@"../../../Ressources/Mob/" + _monster.Race + @"/" + _monster.Name + ".png").Height);

                panelInformation.Location = new Point(pictureBox1.BackgroundImage.Width, 0);
                panelInformation.Height = pictureBox1.BackgroundImage.Height;
                panelInformation.BackColor = System.Drawing.Color.Sienna;

                // We set the value of the HP BAR
                BarHp.Maximum = _monster.MaxHealthPoint;
                BarHp.Value = _monster.Health;
                ModifyProgressBarColor.SetState(BarHp, 1); // 1 = green, 2 = yellow, 3 = red

            }
            labelHPResult.BringToFront();


        }

        // Call the method from Fight.cs and give him the character
        private void PanelCharacter_Load(object sender, EventArgs e)
        {
            // Add an event handler to the left click
            Click += new EventHandler(SelectMemberMonster);
        }

        // Define the treatment of the left click event on a panel
        public void SelectMemberMonster( object sender, EventArgs e )
        {
            // If the player clicks on a character's panel, we create a menu which display information about the member, and change his bordel style
            if ( _obj is Character )
            {
                if ( _fight.SelectedSkill == null )
                {
                    // Create the fight menu of the selected member
                    _FightUserControl.CreateFightMenu(_character);
                    // Get the character we click on it
                    _fight.SelectedCharacter = _character;
                    _FightUserControl.ChangeColorPanel();
                }
                else
                {
                    if ( _fight.SelectedCharacter.DidMemberPlay == false && _fight.SelectedCharacter.isAlive )
                    {
                        if ( _fight.SelectedCharacter.UseSkill(_fight.SelectedSkill, _character) )
                        {
                            _fight.SelectedCharacter.DidMemberPlay = true;
                            _FightUserControl.NextMember();
                            _FightUserControl.ChangeColorPanel();
                            RefreshInformation();
                        }
                    }
                    _fight.SelectedSkill = null;
                }
            }

            // If the player clicks on a monster's panel, the member attacks the monster
            else if ( _obj is Monster )
            {
                if ( _fight.SelectedSkill == null )
                {
                    // We save the selected the monster
                    _fight.SelectedMonster = _monster;
                    // Color the selected monster
                    _FightUserControl.ChangeColorPanel();
                }
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
            else if ( _obj is Character )
            {
                labelHPResult.Text = _character.HealthPoint.ToString();
                labelStaminaResult.Text = _character.Stamina.ToString();
                BackColor = Color.LightSkyBlue;
                if ( _character.isAlive == false ) BackColor = Color.Black;
                else if ( _character.isAlive == true ) BackColor = Color.LightSkyBlue;
                // Refresh HP BAR of our SELECTED CHARACTER if he is attacked
                foreach ( Character c in _fight.GetTeam.Members )
                    if ( c.Name == _fight.SelectedCharacter.Name && c.HealthPoint != _fight.OldLifeSelectedMember )
                        _FightUserControl.CreateFightMenu(c);
            }
        }


        public Character GetCharacter{get { return _character; }}
        public Monster GetMonster { get { return _monster; } }
        public Panel Information { get { return panelInformation; } set { panelInformation = value; }}
        public ProgressBar ProgressBarHp { get { return BarHp; } set { BarHp = value; } }

    }
}
