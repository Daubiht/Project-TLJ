using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IGMapEditor;
using LogicalGame;
using MapEditor;

namespace IGMapEditor
{
    public partial class Map : UserControl
    {
        MapWorld world;
        Editor _context;
        MapIsland _firstIsland;
        MapIsland _secondIsland;

        public Map(Editor context)
        {
            _context = context;
            world = new MapWorld();

            InitializeComponent();
        }

        private void Map_Click(object sender, EventArgs e)
        {
            if (_context.Button == "island")
            {

                string name = Parent.Parent.Controls.Find("GBProperties", false)[0].Controls.Find("TBElementName", false)[0].Text;

                if (!world.Islands.ContainsKey(name))
                {
                    MapIsland island = new MapIsland(world, name);
                    world.Islands.Add(name, island);
                    island.PointX = this.PointToClient(Cursor.Position).X;
                    island.PointY = this.PointToClient(Cursor.Position).Y;

                    Button BIsland = new Button();
                    BIsland.Tag = island;

                    BIsland.Click += Island_Click;

                    BIsland.Text = name;
                    BIsland.Left = this.PointToClient(Cursor.Position).X - BIsland.Width / 2;
                    BIsland.Top = this.PointToClient(Cursor.Position).Y - BIsland.Height / 2;

                    Controls.Add(BIsland);
                }
            }
        }

        private void Map_Load(object sender, EventArgs e)
        {
            
        }

        private void Island_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MapIsland island = (MapIsland)button.Tag;

            if (_context.Button == "link")
            {
                if (_firstIsland == null)
                {
                    _firstIsland = island;
                }
                else
                {
                    _secondIsland = island;
                    LinkIslands();
                }
            }
        }

        private void LinkIslands()
        {
            if (_firstIsland.ListLink == null) _firstIsland.ListLink = new List<MapIsland>();
            if (_secondIsland.ListLink == null) _secondIsland.ListLink = new List<MapIsland>();

            _firstIsland.ListLink.Add(_secondIsland);
            _secondIsland.ListLink.Add(_firstIsland);

            _firstIsland = null;
            _secondIsland = null;
        }

    }
}
