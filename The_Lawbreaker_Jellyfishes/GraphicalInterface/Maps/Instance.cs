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
    public partial class Instance : UserControl
    {
        MainForm _contextForm;
        MapWorld _world;
        MapInstance _instance;

        public Instance(MainForm context, MapWorld world, MapInstance instance)
        {
            InitializeComponent();
            _contextForm = context;
            _world = world;
            _instance = instance;
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            _world.ActualPosition = _instance.MapIsland;
            Island uc = new Island(_contextForm, _world, _instance.MapIsland);
            _contextForm.ChangeUC(uc, true);
        }

        private void Instance_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < _instance.listZones.Count; i++)
            {
                CreateButton("zone" + i, _instance.listZones[i].PointY, _instance.listZones[i].PointY, _instance.listZones[i]);
            }
        }

        public void CreateButton(string name, int p_x, int p_y, object o)
        {
            Button b = new Button();
            b.Location = new Point(p_x, p_y);
            b.Name = name;
            b.Size = new Size(100, 40);
            b.Tag = o;
            b.Text = name;
            b.UseVisualStyleBackColor = true;
            b.Click += new EventHandler(OnClick);
            Controls.Add(b);
        }

        public void OnClick(object sender, EventArgs e)
        {

        }
    }
}
