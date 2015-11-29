using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;
using GraphicalInterface.Fight;

namespace GraphicalInterface.FightIGFolder
{
    public partial class FightUserControl : UserControl
    {

        List<Monster> _monsters;
        Team _team;
        LogicalGame.Fight _fight;

        // List used to place front members on the screen
        List<Character> _frontMembers;
        // List used to place hidden members on the screen
        List<Character> _hiddenMembers;
        // Set the panel characters on the good positions X on the screen
        //     3        1       2       4
        int _posX3, _posX1, _posX2, _posX4;
        int _posY;
        
        // CONSTRUCTOR
        public FightUserControl(List<Monster> MonstersToKill, Team TeamWhoFight)
        {
            InitializeComponent();

            _monsters = MonstersToKill;
            _team = TeamWhoFight;
            LogicalGame.Fight _fight = new LogicalGame.Fight(_monsters, _team);

            // Select members to place them in front or hidden list
            foreach ( Character c in _team.Members )
            {
                if ( c.FrontPosition == true ) _frontMembers.Add(c);
                else if ( c.FrontPosition == false ) _hiddenMembers.Add(c);
            }

            foreach ( Character c in _frontMembers )
            {
                if ( c.IsMain == true )
                {
                    PanelCharacter p = new PanelCharacter(c);
                    p.Location = new Point(_posX1, _posY);
                }

            }
        }
    }
}
