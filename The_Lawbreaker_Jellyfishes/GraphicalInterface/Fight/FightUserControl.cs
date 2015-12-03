using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;
using GraphicalInterface;

namespace GraphicalInterface.Fighting
{
    public partial class FightUserControl : UserControl
    {

        List<Monster> _monsters;
        Team _team;
        Fight _fight;

        // Fight menu displays attack, skill, informations about the selected member
        FightMenu _currentMemberMenu;

        // List used to select FRONT MEMBERS
        List<Character> _frontMembers = new List<Character>();
        // list used to select HIDDEN MEMBERS
        List<Character> _hiddenMembers = new List<Character>();
        // List used to select FRONT MONSTERS
        List<Monster> _frontMonsters = new List<Monster>();
        // list used to select HIDDEN MONSTERS
        List<Monster> _hiddenMonsters = new List<Monster>();

        // Set X positions of members and monsters
        int _posX1Member = 170, _posX2Member = 130, _posX3Member = 85, _posX4Member = 45;
        // Set Y position of monsters
        int _posYFrontMonster = 112, _posYHiddenMonster = 25;
        // Set Y position of members
        int _posYFrontMember = 214, _posYHiddenMember = 293;
        // Set the space between each panel
        int _spaceBetweenPanels = 85;


        bool _isAllMembersFrontPositionFalse;
        bool _isAllMonstersFrontPositionFalse;

        // CONSTRUCTOR
        public FightUserControl(List<Monster> MonstersToKill, Team TeamWhoFight)
        {
            InitializeComponent();
            // Get the monsters list and and team
            _monsters = MonstersToKill;
            _team = TeamWhoFight;
            _fight = new Fight(_monsters, _team);

            // Check if all 4 members's front position are setted to false, if yes, we set all front position to true
            if (_team.Members.Count == 4)
            {
                foreach ( Character c in _team.Members)
                {
                    // if one member's front position is true, we don't modify the front position
                    if (c.FrontPosition == true)
                    {
                        _isAllMembersFrontPositionFalse = false;
                        break;
                    }
                    // if all member's front position are false, we set all them to true
                    else _isAllMembersFrontPositionFalse = true;
                }
                // Change all position to true
                if ( _isAllMembersFrontPositionFalse == true)           
                    foreach (Character c in _team.Members) c.FrontPosition = true;
            }
            // Check if all 4 monster's front position are setted to false, if yes, we set all front position to true
            if (_monsters.Count == 4)
            {
                foreach ( Monster m in _monsters)
                {
                    // if one monster's front position is true, we don't modify the front position
                    if (m.FrontPosition == true)
                    {
                        _isAllMonstersFrontPositionFalse = false;
                        break;
                    }
                    // if all monster's front position are false, we set all them to true
                    else _isAllMonstersFrontPositionFalse = true;
                }
                // Change all position to true
                if (_isAllMonstersFrontPositionFalse == true)           
                    foreach (Monster m in _monsters) m.FrontPosition = true;
            }

            // Select members to place them in front or hidden member list
            foreach ( Character c in _team.Members )
            {
                // Select FRONT MEMBERS
                if ( c.FrontPosition == true ) _frontMembers.Add(c);
                // Select HIDDEN MEMBERS
                else if ( c.FrontPosition == false ) _hiddenMembers.Add(c);
            }
            // Select monsters to place them in front or hidden monster list
            foreach ( Monster m in _monsters)
            {
                // Select FRONT MONSTERS
                if (m.FrontPosition == true) _frontMonsters.Add(m);
                // Select HIDDEN MONSTERS
                else if (m.FrontPosition == false) _hiddenMonsters.Add(m);
            }

            // Place all members and monsters on the screen with the good positions
            SetPanelPosition(_frontMembers, _posYFrontMember);
            SetPanelPosition(_hiddenMembers, _posYHiddenMember);
            SetPanelPosition(_frontMonsters, _posYFrontMonster);
            SetPanelPosition(_hiddenMonsters, _posYHiddenMonster);
        }
        // Method who sets the PANEL'S POSITION
        public void SetPanelPosition<T>(List<T> MonsterOrMemberList, int posY)
        { 
            // Place the 1 front member/monster in the middle
            if (MonsterOrMemberList.Count == 1)
            {
                int localPosX1Member = _posX1Member;
                foreach (T t in MonsterOrMemberList)
                {
                    PanelCharacter p = new PanelCharacter(t, _fight, this);
                    p.Location = new Point(localPosX1Member, posY);
                    Controls.Add(p);
                }
            }
            // Place the 2 front members/monster in the middle
            else if (MonsterOrMemberList.Count == 2)
            {
                int localPosX2Member = _posX2Member;
                foreach (T t in MonsterOrMemberList)
                {
                    PanelCharacter p = new PanelCharacter(t, _fight, this);
                    p.Location = new Point(localPosX2Member, posY);
                    Controls.Add(p);
                    localPosX2Member += _spaceBetweenPanels;
                }
            }
            // Place 3 front members/monster in the middle
            else if (MonsterOrMemberList.Count == 3)
            {
                int localPosX3Member = _posX3Member;
                foreach (T t in MonsterOrMemberList)
                {
                    PanelCharacter p = new PanelCharacter(t, _fight, this);
                    p.Location = new Point(localPosX3Member, posY);
                    Controls.Add(p);
                    localPosX3Member += _spaceBetweenPanels;
                }
            }
            // Place 4 front members/monster
            else if (MonsterOrMemberList.Count == 4)
            {
                int localPosX4Member = _posX4Member;
                foreach (T t in MonsterOrMemberList)
                {
                    PanelCharacter p = new PanelCharacter(t, _fight, this);
                    p.Location = new Point(localPosX4Member, posY);
                    Controls.Add(p);
                    localPosX4Member += _spaceBetweenPanels;
                }
            }
        }

        // Create fight menu
        public void CreateFightMenu(Character DisplayedCharacter)
        {
            Controls.Remove(_currentMemberMenu);
            _currentMemberMenu = new FightMenu(DisplayedCharacter, _fight);
            Controls.Add(_currentMemberMenu);
        }

        private void FightUserControl_Load(object sender, EventArgs e)
        {
            _fight.gameLoop();
        }



    }
}
