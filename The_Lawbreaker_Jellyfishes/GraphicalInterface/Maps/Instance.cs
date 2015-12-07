using System;
using System.Drawing;
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

        public void Reload()
        {
            foreach (object zone_b in Controls)
            {
                if (zone_b is Button)
                {
                    if (((Button)zone_b).Tag == (MapZone)_world.ActualPosition)
                    {
                        ((Button)zone_b).ForeColor = SystemColors.HotTrack;
                    }
                    else
                    {
                        ((Button)zone_b).ForeColor = SystemColors.ControlText;
                    }
                }
            }
        }

        public void OnClick(object sender, EventArgs e)
        {
            if (_world.ActualPosition is MapZone)
            {
                if ((MapZone)_world.ActualPosition != ((MapZone)((Button)sender).Tag))
                {
                    foreach (MapZone zone in _instance.listZones)
                    {
                        if (zone == ((MapZone)((Button)sender).Tag))
                        {
                            if (_instance.ChangeActualZone(zone))
                            {
                                Reload();
                                Meet uc = new Meet(_instance.EventRandom(zone.Visited), _contextForm, _world, zone);
                                zone.Visited = true;
                                _contextForm.ToMenu(uc, false);
                            }
                        }
                    }
                }
            }
            else
            {
                if(((MapZone)((Button)sender).Tag) == _instance.listZones[0])
                {
                    _world.ActualPosition = ((MapZone)((Button)sender).Tag);
                    Reload();
                }
            }
        }
    }
}
