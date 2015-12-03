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
        MainForm _contextForm;
        MapWorld _world;
        MapIsland _island;

        public Island(MainForm contextForm, MapWorld world, MapIsland island)
        {
            InitializeComponent();
            _contextForm = contextForm;
            _world = world;
            _island = island;
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            World uc = new World(_world, _contextForm,false);
            _contextForm.ChangeUC(uc, true);
        }

        private void Island_Load(object sender, EventArgs e)
        {
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
            b.Click += new EventHandler(Click);
            Controls.Add(b);
        }

        public void Click(object sender, EventArgs e)
        {
            if(((Button)sender).Tag is MapInstance)
            {
                //Instance uc = new Instance(_contextForm, _w, ((Button)sender).Tag);
                //_contextForm.ChangeUC(uc, true);
            }
            else if (((Button)sender).Tag is MapCity)
            {
                //City uc = new City(_contextForm, _w, ((Button)sender).Tag);
                //_contextForm.ChangeUC(uc, true);
            }
        }
    }
}
