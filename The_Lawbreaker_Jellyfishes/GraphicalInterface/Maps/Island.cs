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
    public partial class Island : UserControl
    {
        Controller _ctrler;
        MapWorld _world;
        MapIsland _island;
        ComponentResourceManager resources;

        public Island(Controller ctrler, MapWorld world, MapIsland island)
        {
           resources = new ComponentResourceManager(typeof(Island));
            _ctrler = ctrler;
            _world = world;
            _island = island;
            InitializeComponent();
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            _ctrler.ToWorld(_world, false);
        }

        private void Island_Load(object sender, EventArgs e)
        {
            if(_island.IslandName == "Poniénne")
            {
                this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("poni")));
            }
            else if(_island.IslandName == "Belegaer")
            {
                this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bele")));
            }
            else
            {
                this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("fine")));
            }

            foreach (MapInstance instance in _island.IslandInstances)
            {
                CreateButton(instance.InstanceName, instance.PointX, instance.PointY, instance);
            }
            CreateButton(_island.IslandCity.CityName, _island.IslandCity.PointX, _island.IslandCity.PointY, _island.IslandCity);
        }

        public void CreateButton(string name, int p_x, int p_y, object o)
        {
            Button b = new Button();
            b.Location = new Point(p_x, p_y);
            b.Name = name;
            b.Size = new Size(100, 50);
            b.Tag = o;
            b.Text = name;
            b.UseVisualStyleBackColor = true;
            b.Click += new EventHandler(OnClick);
            pictureBox1.Controls.Add(b);
        }

        public void OnClick(object sender, EventArgs e)
        {
            if(((Button)sender).Tag is MapInstance)
            {
                _ctrler.ToInstance((MapInstance)((Button)sender).Tag);
            }
            else if (((Button)sender).Tag is MapCity)
            {
                _ctrler.ToCity((MapCity)((Button)sender).Tag);
            }
        }
    }
}
