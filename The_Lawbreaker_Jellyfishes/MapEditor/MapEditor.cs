using LogicalGame;
using MapEditor;
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
        
        Button thingToLink;
        Editor _context;

        public MapEditor(Editor context)
        {
            _context = context;

            InitializeComponent();
        }

        

        private void MapEditor_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu(_context);
            Map map = new Map(_context);

            GBMap.Controls.Add(map);
            Controls.Add(menu);
            menu.Left = this.Width - 214;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            _context.World.Save(3);
        }
    }
}
