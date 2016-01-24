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
    public partial class City : UserControl
    {
        Controller _ctrler;
        MapWorld _world;
        MapCity _city;

        public City(Controller ctrler, MapWorld world, MapCity City)
        {
            _ctrler = ctrler;
            _world = world;
            _city = City;
            InitializeComponent();
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            _ctrler.ToIsland(_city.ActualIsland);
        }

        private void City_Load(object sender, EventArgs e)
        {
            foreach (object service in _city.Services)
            {
                if(service is LogicalGame.Militia)
                {
                    CreateButton("Milice", ((LogicalGame.Militia)service).PointX, ((LogicalGame.Militia)service).PointY, service);
                }
                else if(service is LogicalGame.Mortuary)
                {
                    CreateButton("Morgue", ((LogicalGame.Mortuary)service).PointX, ((LogicalGame.Mortuary)service).PointY, service);
                }
                else if(service is LogicalGame.Merchant)
                {
                    CreateButton(((LogicalGame.Merchant)service).Name, ((LogicalGame.Merchant)service).PointX, ((LogicalGame.Merchant)service).PointY, service);
                }
                else if(service is LogicalGame.Taverne)
                {
                    CreateButton("Taverne", ((LogicalGame.Taverne)service).PointX, ((LogicalGame.Taverne)service).PointY, service);

                }
            }
            LogicalGame.Taverne taverne = new LogicalGame.Taverne();
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
            Controls.Add(b);
        }

        public void OnClick(object sender, EventArgs e)
        {
            _ctrler.ToService(((Button)sender).Tag);
        }
    }
}
