using System;
using System.Drawing;
using System.Windows.Forms;
using LogicalGame;
using GraphicalInterface;
using System.Collections.Generic;
using GraphicalInterface.Fighting;

namespace GraphicalInterface
{
    public partial class World : UserControl
    {
        readonly MapWorld _w;
        readonly MainForm _contextForm;
        bool _militia;

        public World(MapWorld w, MainForm contextForm, bool militia)
        {
            InitializeComponent();
            _w = w;
            _contextForm = contextForm;
            _militia = militia;
        }


        private void World_Load(object sender, EventArgs e)
        {
            foreach (Button button in Controls)
            {
                if (button.Text == _w.ActualIsland)
                {
                    button.ForeColor = SystemColors.HotTrack;
                }
                else
                {
                    button.ForeColor = SystemColors.ControlText;
                }
            }
        }

        public void ChangeIsland(string IslandName)
        {
            foreach (MapIsland island in _w.Islands.Values)
            {
                if (island.IslandName == IslandName)
                {
                    if (_w.ChangeActualIsland(island, _militia))
                    {
                        if(_militia == false) ok.Visible = true;
                        _militia = false;
                    }
                    World_Load(null, null);
                }
            }
        }

        private void Ponyoland_Click(object sender, EventArgs e)
        {
            if (_w.ActualIsland == "Ponyoland")
            {
                Ponyoland uc = new Ponyoland(_contextForm, _w);
                _contextForm.ChangeUC(uc, true);
            }
            else
            {
                ChangeIsland("Ponyoland");
            }
        }

        private void IlePerdue_Click(object sender, EventArgs e)
        {
            ChangeIsland("L'île perdue");
        }

        private void IleDevastee_Click(object sender, EventArgs e)
        {
            ChangeIsland("L'île dévastée");
        }

        private void Genefort_Click(object sender, EventArgs e)
        {
            ChangeIsland("Genefort");
        }

        private void ok_Click(object sender, EventArgs e)
        {
            // Create monsters
            List<Monster> _monsters = new List<Monster>();

            // Create monsters
            Monster m1 = new Monster("M1", "slime", 5, 0, 100, 0, 5, 5);
            Monster m2 = new Monster("M2", "slime", 5, 0, 100, 0, 5, 5);
            Monster m3 = new Monster("M3", "slime", 5, 0, 100, 0, 5, 5);
            Monster m4 = new Monster("M4", "slime", 5, 0, 100, 0, 5, 5);

            // Create members
            Character c1 = new Character("C1", "HUMAIN", false);
            Character c2 = new Character("C2", "ELF", false);
            Character c3 = new Character("C3", "NAIN", false);
            Character c4 = new Character("C4", "NAIN", false);
            // Create team
            Team _team = new Team("MyTeam");

            // Set positions to monsters
            m1.FrontPosition = true;
            m2.FrontPosition = true;
            m3.FrontPosition = true;
            m4.FrontPosition = false;
            // Set positions to members
            c1.IsMain = true;
            c1.FrontPosition = true;
            c2.FrontPosition = false;
            c3.FrontPosition = false;
            c4.FrontPosition = false;

            // Add monsters in list
            _monsters.Add(m1);
            _monsters.Add(m2);
            _monsters.Add(m3);
            _monsters.Add(m4);
            // Add members in team, 
            _team.AddMembers(c1);
            _team.AddMembers(c2);
            _team.AddMembers(c3);
            _team.AddMembers(c4);

            // ok.Visible = false;
            FightUserControl fightIG = new FightUserControl(_monsters, _team);
            _contextForm.ChangeUC(fightIG, false);
        }
    }
}
