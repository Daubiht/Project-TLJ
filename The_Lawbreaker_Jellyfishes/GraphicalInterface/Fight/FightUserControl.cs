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

namespace GraphicalInterface
{
    public partial class FightUserControl : UserControl
    {
        List<PanelCharacter> _panelMembers;
        List<PanelCharacter> _panelMonsters;

        List<Monster> _monsters;
        Team _team;
        Fight _fight;


        // Need the context to give it to the end fight, end fight will go back to the context
        MainForm _context;
        // Fight menu displays attack, skill, informations about the selected member
        FightMenu _currentMemberMenu;

        // Front members
        List<Character> _frontMembers = new List<Character>();
        // Hidden members
        List<Character> _hiddenMembers = new List<Character>();
        // Front monsters
        List<Monster> _frontMonsters = new List<Monster>();
        // hidden monsters
        List<Monster> _hiddenMonsters = new List<Monster>();

        // Set X positions of members and monsters
        int _posX1Member = 350, _posX2Member = 200, _posX3Member = 200, _posX4Member = 130;
        // Set Y position of monsters
        int _posYFrontMonster = 90, _posYHiddenMonster = 0;
        // Set Y position of members
        int _posYFrontMember = 190, _posYHiddenMember = 250;
        // Set the space between each panel
        int _spaceBetweenPanels = 150;

        // This bools are used to avoid bugs, if 4 members/monsters are set to hidden position, they will be set in front position
        bool _isAllMembersFrontPositionFalse;
        bool _isAllMonstersFrontPositionFalse;

        // CONSTRUCTOR
        public FightUserControl(List<Monster> MonstersToKill, Team TeamWhoFight, MainForm context)
        {
            InitializeComponent();
            // Get the monsters list and and team
            _monsters = MonstersToKill;
            _team = TeamWhoFight;
            // Need the context to create the end fight screen
            _context = context;
            _fight = new Fight(_monsters, _team);
            _panelMembers = new List<PanelCharacter>();
            _panelMonsters = new List<PanelCharacter>();

            // INCREASE basic stats of members thanks to their stuff
            IncreaseBasicsStatsThanksStuff(TeamWhoFight, true);

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

            // Select the first member who plays
            foreach(Character c in _team.Members )
            {
                if( c.isAlive )
                {
                    CreateFightMenu(c);
                    _fight.SelectedCharacter = c;
                    break;
                }
            }
            ChangeColorPanel();
        }

        private void FightUserControl_Load(object sender, EventArgs e)
        {

        }

        // Panel's position
        public void SetPanelPosition<T>(List<T> MonsterOrMemberList, int posY)
        { 
            // Place the 1 front member/monster in the middle
            if (MonsterOrMemberList.Count == 1)
            {
                int localPosX1Member = _posX1Member;
                foreach ( T t in MonsterOrMemberList)
                {
                    PanelCharacter p = new PanelCharacter(t, _fight, this, _context);
                    int localPosXMonster = 375 - p.Width/2;
                    p.Location = new Point(localPosX1Member, posY);
                    Controls.Add(p);
                    if ( t is Character )
                        _panelMembers.Add(p);
                    else
                    {
                        p.Location = new Point(localPosXMonster, p.Location.Y);
                        _panelMonsters.Add(p);
                    }
                }
            }
            // Place the 2 front members/monster in the middle
            else if (MonsterOrMemberList.Count == 2)
            {
                int localPosX2Member = _posX2Member;
                int localPosXMonster = 250;
                foreach (T t in MonsterOrMemberList)
                {
                    PanelCharacter p = new PanelCharacter(t, _fight, this, _context);
                    p.Location = new Point(localPosX2Member, posY);
                    Controls.Add(p);
                    localPosX2Member += _spaceBetweenPanels;
                    if ( t is Character )
                        _panelMembers.Add(p);
                    else
                    {
                        p.Location = new Point(localPosXMonster,p.Location.Y);
                        localPosXMonster += p.Width + 10;
                        _panelMonsters.Add(p);
                    }
                }
            }
            // Place 3 front members/monster in the middle
            else if (MonsterOrMemberList.Count == 3)
            {
                int localPosX3Member = _posX3Member;
                int localPosXMonster = 200;

                foreach ( T t in MonsterOrMemberList)
                {
                    PanelCharacter p = new PanelCharacter(t, _fight, this, _context);
                    p.Location = new Point(localPosX3Member, posY);
                    Controls.Add(p);
                    localPosX3Member += _spaceBetweenPanels;
                    if ( t is Character )
                        _panelMembers.Add(p);
                    else
                    {
                        p.Location = new Point(localPosXMonster, p.Location.Y);
                        localPosXMonster += p.Width + 10;
                        _panelMonsters.Add(p);
                    }
                }
            }
            // Place 4 front members/monster
            else if (MonsterOrMemberList.Count == 4)
            {
                int localPosX4Member = _posX4Member;
                int localPosXMonster = 20;
                foreach ( T t in MonsterOrMemberList)
                {
                    PanelCharacter p = new PanelCharacter(t, _fight, this, _context);
                    p.Location = new Point(localPosX4Member, posY);
                    Controls.Add(p);
                    localPosX4Member += _spaceBetweenPanels;
                    if ( t is Character )
                        _panelMembers.Add(p);
                    else
                    {
                        p.Location = new Point(localPosXMonster, p.Location.Y);
                        localPosXMonster += p.Width + 10;
                        _panelMonsters.Add(p);
                    }
                }
            }
        }

        // Create fight menu
        public void CreateFightMenu(Character DisplayedCharacter)
        {
            Controls.Remove(_currentMemberMenu);
            _currentMemberMenu = new FightMenu(DisplayedCharacter, _fight, _context, _panelMembers, this);
            Controls.Add(_currentMemberMenu);
        }
        // Create end fight screen
        public void EndFight()
        {
            // Defeat screen
            if ( _fight.AreAllMembersDead )
            {
                // DECREASE basic stats of members because of their stuff
                IncreaseBasicsStatsThanksStuff(_team, false);
                _team.MainCharacter.isAlive = true;
                _team.MainCharacter.Heal(_team.MainCharacter.MaxHealthPoint * 5 / 100);
                EndFightDefeat EFDefeat = new EndFightDefeat(_context, true);
                _context.ChangeUC(EFDefeat, false, true);
            }
            // Victory screen
            else if ( _fight.AreAllMonstersDead  )
            {
                if(_fight.IsEndFight == false )
                {
                    // DECREASE basic stats of members because of their stuff
                    IncreaseBasicsStatsThanksStuff(_team, false);
                    EndFightVictory EFVictory = new EndFightVictory(_context, _monsters, false);
                    _context.ChangeUC(EFVictory, true, true);
                    // Avoid to gain a lot of level
                    _fight.IsEndFight = true;
                }
            }
        }
        // Increase or decrease the basic stattistics of a member thanks to his equiped stuff
        public void IncreaseBasicsStatsThanksStuff(Team Team, bool Equiped)
        {
            // We INCREASE the basic stats thanks to the stuff, usefull when we START THE FIGHT
            if( Equiped == true )
            {
                foreach ( Character c in Team.Members )
                {
                    if( c.StatsStuff.ContainsKey("attaque physique") ) { c.PhysicalAttack = c.PhysicalAttack + c.StatsStuff["attaque physique"]; }
                    if( c.StatsStuff.ContainsKey("attaque magique") )  { c.MagicAttack = c.MagicAttack       + c.StatsStuff["attaque magique"]; }
                    if( c.StatsStuff.ContainsKey("esquive") )          { c.Dodge = c.Dodge                   + c.StatsStuff["esquive"]; }
                    if( c.StatsStuff.ContainsKey("robustesse") )       { c.HealthPoint = c.Robustness        + c.StatsStuff["robustesse"]; }
                }
            }
            // Decrease the basic stats when we finish the fight
            else if ( Equiped == false )
            {
                // We reset basic stats of all member to their original basic stats
                foreach(Character c in _team.Members )
                {
                    if ( _fight.OriginalStats.ContainsKey(c) )
                    {
                        c.PhysicalAttack = _fight.OriginalStats[c]["attaque physique"];
                        c.MagicAttack = _fight.OriginalStats[c]["attaque magique"];
                        c.Dodge = _fight.OriginalStats[c]["esquive"];
                        c.Robustness = _fight.OriginalStats[c]["robustesse"];
                    }
                }
            }
        }
        // Select the next member who plays
        public void NextMember()
        {
            foreach ( Character c in _fight.GetTeam.Members )
            {
                if ( c.isAlive == true && c.DidMemberPlay == false )
                {
                    foreach ( PanelCharacter PC in GetCharacterPanel )
                    {
                        if ( PC.GetCharacter == c )
                        {
                            PC.BackColor = Color.SteelBlue;
                            // Create the fight menu of the selected member
                            CreateFightMenu(c);
                            // Get the character we click on it
                            _fight.WhoIsSelected(c);
                        }
                    }
                    break;
                }
            }
        }

        // Change color of panels
        public void ChangeColorPanel()
        {   // If false, Remove all border style of all members
            foreach ( PanelCharacter pC in GetCharacterPanel )
            {
                // BLACK If the member is DEAD
                if ((pC.GetCharacter !=null && !pC.GetCharacter.isAlive)) pC.BackColor = Color.Black;
                // LIGHT BLUE If the member is ALIVE
                if ( pC.GetCharacter.isAlive == true ) pC.BackColor = Color.LightSkyBlue;
                // GRAY color If the member is ALIVE and already PLAYED
                if ( pC.GetCharacter.DidMemberPlay == true && pC.GetCharacter.isAlive == true ) pC.BackColor = Color.Gray;
                // BLUE FONCE if panel is selected
                if ( pC.GetCharacter == _fight.SelectedCharacter ) pC.BackColor = Color.SteelBlue;
            }

            foreach (PanelCharacter pC in GetMonsterPanel )
            {
                // LIGHT BLUE If the MONSTER is ALIVE
                if ( pC.GetMonster.Alive ) pC.BackColor = Color.LightSkyBlue;
                // BLACK If the member is DEAD
                if ( (pC.GetMonster != null && !pC.GetMonster.Alive) ) pC.BackColor = Color.Black;
                // BLUE FONCE if panel is selected
                if ( pC.GetMonster == _fight.SelectedMonster ) pC.BackColor = Color.Brown;
            }
        }

        // Choose automatically the next alive monster
        public void NextMonster()
        {
            if ( !_fight.SelectedMonster.Alive )
            {
                foreach(Monster m in _fight.GetFrontMonsters )
                {
                    if ( m.Alive )
                    {
                        foreach(PanelCharacter pc in _panelMonsters )
                        {
                            if( m == pc.GetMonster )
                            {
                                _fight.SelectedMonster = m;
                                ChangeColorPanel();
                                return;
                            }
                        }
                    }
                }
            }
        }

        public List<PanelCharacter> GetCharacterPanel { get { return _panelMembers;  } }
        public List<PanelCharacter> GetMonsterPanel { get { return _panelMonsters; } }
        public FightMenu GetCurrentFightMenu { get { return _currentMemberMenu; } set { _currentMemberMenu = value; } }
    }
}
