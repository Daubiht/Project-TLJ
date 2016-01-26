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
        bool _Dragging;
        int _xPos;
        int _yPos;

        public World(MapWorld w, Controller ctrler, bool militia)
        {
            InitializeComponent();
            _w = w;
            _ctrler = ctrler;
            _militia = militia;

            pictureBox1.Location = new Point(pictureBox1.Parent.Width / 2 - pictureBox1.Width / 2, pictureBox1.Parent.Height / 2 - pictureBox1.Height / 2);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) { _Dragging = false; }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _Dragging = true;
                _xPos = e.X;
                _yPos = e.Y;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (_Dragging && c != null)
            {
                if (c.Parent.Top > e.Y + c.Top - _yPos && c.Parent.Bottom < e.Y + c.Bottom - _yPos)
                {
                    c.Top = e.Y + c.Top - _yPos;
                }
                if (c.Parent.Left > e.X + c.Left - _xPos && c.Parent.Right < e.X + c.Right - _xPos)
                {
                    c.Left = e.X + c.Left - _xPos;
                }
            }
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

                isl_Button.BackColor = Color.Transparent;
                isl_Button.BackgroundImage = Image.FromFile(@"../../../Ressources/sign.png");
                isl_Button.BackgroundImageLayout = ImageLayout.Stretch;
                isl_Button.Cursor = Cursors.Hand;
                isl_Button.FlatStyle = FlatStyle.Flat;
                isl_Button.FlatAppearance.BorderSize = 0;
                isl_Button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                isl_Button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                isl_Button.Location = new Point(island.PointX, island.PointY);
                isl_Button.Name = island.IslandName;
                isl_Button.Size = new Size(150, 112);
                isl_Button.Font = new Font(_ctrler.Font.Families[0], 20);
                isl_Button.Text = island.IslandName;
                isl_Button.UseVisualStyleBackColor = true;
                isl_Button.Click += new EventHandler(Isl_Click);

                panel1.Controls.Add(isl_Button);

                Point pos = PointToScreen(isl_Button.Location);
                pos = pictureBox1.PointToClient(pos);
                isl_Button.Parent = pictureBox1;
                isl_Button.Location = pos;

                if (island == _w.ActualPosition) isl_Button.ForeColor = SystemColors.HotTrack;
            }

            if(((MapIsland)_w.ActualPosition).IslandName == "Poniénne")
            {
                pictureBox1.Location = new Point(-75, -175);
            }
            else if(((MapIsland)_w.ActualPosition).IslandName == "Belegaer")
            {
                pictureBox1.Location = new Point(-75, -550);
            }
            else
            {
                pictureBox1.Location = new Point(-575, -650);
            }

        }

        public void Reload()
        {
            foreach (var isl_Button in panel1.Controls)
            {
                if (isl_Button is Button)
                { 
                    if (((Button)isl_Button).Text == ((MapIsland)_w.ActualPosition).IslandName)
                    {
                        ((Button)isl_Button).ForeColor = SystemColors.HotTrack;
                    }
                    else
                    {
                        ((Button)isl_Button).ForeColor = SystemColors.ControlText;
                    }
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
                            Reload();
                            _militia = false;      
                        }
                    }
                }
            }
        }

    }
}
