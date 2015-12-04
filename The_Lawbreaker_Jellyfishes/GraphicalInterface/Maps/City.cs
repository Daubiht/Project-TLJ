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
        MainForm _contextForm;
        MapWorld _world;
        MapCity _city;

        public City(MainForm contextForm, MapWorld world, MapCity City)
        {
            InitializeComponent();
            _contextForm = contextForm;
            _world = world;
            _city = City;
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            _world.ActualPosition = _city.ActualIsland;
            Island uc = new Island(_contextForm, _world, _city.ActualIsland);
            _contextForm.ChangeUC(uc, true);
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
            if (((Button)sender).Tag is LogicalGame.Militia)
            {
                 Militia uc = new Militia(_contextForm, _world);
                _contextForm.ToMenu(uc, true);
            }
            else if (((Button)sender).Tag is LogicalGame.Mortuary)
            {
                Mortuary uc = new Mortuary(_world.Team, _contextForm, ((LogicalGame.Mortuary)((Button)sender).Tag));
                _contextForm.ToMenu(uc, true);
            }
            else if (((Button)sender).Tag is LogicalGame.Merchant)
            {
                Merchant uc = new Merchant(_contextForm, ((LogicalGame.Merchant)((Button)sender).Tag), _world.Team.Invent);
                _contextForm.ToMenu(uc, true);
            }
            else if (((Button)sender).Tag is LogicalGame.Taverne)
            {
                Taverne uc = new Taverne(_world.Team, _contextForm);
                _contextForm.ToMenu(uc, true);
            }
        }
    }
}
