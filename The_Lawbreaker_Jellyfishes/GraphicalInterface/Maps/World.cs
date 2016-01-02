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
        readonly Controller _ctrler;
        bool _militia;

        public World(MapWorld w, Controller ctrler, bool militia)
        {
            InitializeComponent();
            _w = w;
            _ctrler = ctrler;
            _militia = militia;
        }

        private void World_Load(object sender, EventArgs e)
        {
            if (!(_w.ActualPosition is MapIsland))
            {
                if (_w.ActualPosition is MapZone)
                {
                    _w.ActualPosition = ((MapZone)_w.ActualPosition).Context.MapIsland;
                }
                else if (_w.ActualPosition is MapInstance)
                {
                    _w.ActualPosition = ((MapInstance)_w.ActualPosition).MapIsland;
                }
                else if (_w.ActualPosition is MapCity)
                {
                    _w.ActualPosition = ((MapCity)_w.ActualPosition).ActualIsland;
                }
            }

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

                if (island == _w.ActualPosition) isl_Button.ForeColor = SystemColors.HotTrack;
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
                _ctrler.ToIsland(_w.Islands[((Button)sender).Text]);
            }
            else
            {
                foreach (MapIsland island in _w.Islands.Values)
                {
                    if (island.IslandName == ((Button)sender).Text)
                    {
                        if (_w.ChangeActualIsland(island, _militia))
                        {
                            if (!_militia)
                            {
                                MapInstance instance = _w.CreateRandomInstance(((MapIsland)_w.ActualPosition));
                                instance.Target = island;
                                _ctrler.ToInstance(instance);
                            }
                            else
                            {
                                Reload();
                            }
                            _militia = false;
                        }
                    }
                }
            }
        }

    }
}
