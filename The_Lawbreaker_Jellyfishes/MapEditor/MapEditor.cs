using LogicalGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IGMapEditor
{
    public partial class MapEditor : Form
    {
        public MapWorld world;
        public static int button;
        public Button thingToLink;

        public MapEditor()
        {
            InitializeComponent();
        }

        public MapWorld World
        {
            get { return world; }
        }

        private void MapEditor_Load(object sender, EventArgs e)
        {
            world = new MapWorld();

            Menu menu = new Menu();
            Map map = new Map();

            GBMap.Controls.Add(map);
            Controls.Add(menu);
            menu.Left = this.Width - 214;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
