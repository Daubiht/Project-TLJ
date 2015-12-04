using System;
using System.Drawing;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class World : UserControl
    {
        readonly MapWorld _w;
        readonly MainForm _contextForm;
        bool _militia;

        public World(MapWorld w, MainForm contextForm, bool militia)
        {
            InitializeComponent();
            _w = w;
            _contextForm = contextForm;
            _militia = militia;
        }

        private void World_Load(object sender, EventArgs e)
        {
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

                if(island == _w.ActualPosition) isl_Button.ForeColor = SystemColors.HotTrack;
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
                Island uc = new Island(_contextForm, _w, _w.Islands[((Button)sender).Text]);
                _contextForm.ChangeUC(uc, true);
            }
            else
            {
                foreach (MapIsland island in _w.Islands.Values)
                {
                    if (island.IslandName == ((Button)sender).Text)
                    {
                        if (_w.ChangeActualIsland(island, _militia))
                        {
                            if (_militia == false) ok.Visible = true;
                            _militia = false;
                        }
                        Reload();
                    }
                }
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            ok.Visible = false;
        }
    }
}
