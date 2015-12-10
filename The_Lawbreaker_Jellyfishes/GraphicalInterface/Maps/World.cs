using System;
using System.Drawing;
using System.Windows.Forms;
using LogicalGame;
using GraphicalInterface;
using System.Collections.Generic;

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
            foreach (MapIsland island in _w.Islands.Values)
            {
                Button isl_Button = new Button();
                isl_Button.Location = new Point(island.PointX, island.PointY);
                isl_Button.Name = island.IslandName;
                isl_Button.Size = new Size(100, 50);
                isl_Button.Text = island.IslandName;
                isl_Button.UseVisualStyleBackColor = true;
                isl_Button.Click += new EventHandler(Isl_Click);
                Controls.Add(isl_Button);

                if(island == _w.ActualPosition) isl_Button.ForeColor = SystemColors.HotTrack;
            }
        }

        public void Reload()
        {
            foreach (Button isl_Button in Controls)
            {
                if (isl_Button.Text == ((MapIsland)_w.ActualPosition).IslandName)
                {
                    isl_Button.ForeColor = SystemColors.HotTrack;
                }
                else
                {
                    isl_Button.ForeColor = SystemColors.ControlText;
                }
            }
        }

        public void Isl_Click(object sender, EventArgs e)
        {
            if (((MapIsland)_w.ActualPosition).IslandName == ((Button)sender).Text)
            {
                Island uc = new Island(_contextForm, _w, _w.Islands[((Button)sender).Text]);
                _contextForm.ChangeUC(uc, true);
            }
            else
            {
                foreach (MapIsland island in _w.Islands.Values)
                {
                    if (island.IslandName == ((Button)sender).Text)
                    {
                        if (_w.ChangeActualIsland(island, _militia))
                        {
                            if (_militia == false) ok.Visible = true;
                            _militia = false;
                        }
                        Reload();
                    }
                }
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            // Create monsters
            List<Monster> _monsters = new List<Monster>();

            // Create monsters
            Monster m1 = new Monster("M1", 2, "slime", 1, 0, 5, 0, 5, 0);
            Monster m2 = new Monster("M2", 2, "slime", 5, 0, 100, 0, 5, 5);
            Monster m3 = new Monster("M3", 2, "slime", 5, 0, 100, 0, 5, 5);
            Monster m4 = new Monster("M4", 2, "slime", 5, 0, 100, 0, 5, 5);

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
            m3.FrontPosition = false;
            m4.FrontPosition = false;
            // Set positions to members
            c1.IsMain = true;
            c1.FrontPosition = true;
            c2.FrontPosition = true;
            c3.FrontPosition = true;
            c4.FrontPosition = false;

            // Add monsters in list
            _monsters.Add(m1);
           //_monsters.Add(m2);
     //       _monsters.Add(m3);
       //     _monsters.Add(m4);
            // Add members in team, 
            //_w.Team.AddMembers(c2);
            //_w.Team.AddMembers(c3);
            //_w.Team.AddMembers(c4);
            //_team.AddMembers(c2);
            //    _team.AddMembers(c3);
            //       _team.AddMembers(c4);

            // CREATE POTION ITEM TO ADD IN THE INVENTORY AND USE IN THE FIGHT
            Item i1 = new Item("Potion de soin légers", 1, 10, "Soigne légerement", "consommable");
            i1.AddStats("heal", 10);
            _w.Team.Invent.AddItem(i1, 15);

            // ok.Visible = false;
            // TEST
            //FightUserControl fightIG = new FightUserControl(_monsters, _team, _contextForm);
            FightUserControl fightIG = new FightUserControl(_monsters, _w.Team, _contextForm);
            _contextForm.ToMenu(fightIG, false);
        }
    }
}
