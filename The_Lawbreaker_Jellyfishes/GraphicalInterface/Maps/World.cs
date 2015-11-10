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
            if (_w.ActualIsland == "Ponyoland")
            {
                Ponyoland.Text = "Ponyoland(*)";
                IlePerdue.Text = "L'île perdue";
                IleDevastee.Text = "L'île dévastée";
                Genefort.Text = "Genefort";
            }
            else if(_w.ActualIsland == "L'île dévastée")
            {
                IleDevastee.Text = "L'île dévastée(*)";
                IlePerdue.Text = "L'île perdue";
                Ponyoland.Text = "Ponyoland";
                Genefort.Text = "Genefort";
            }
            else if (_w.ActualIsland == "L'île perdue")
            {
                IlePerdue.Text = "L'île perdue(*)";
                Ponyoland.Text = "Ponyoland";
                IleDevastee.Text = "L'île dévastée";
                Genefort.Text = "Genefort";
            }
            else if (_w.ActualIsland == "Genefort")
            {
                Genefort.Text = "Genefort(*)";
                IlePerdue.Text = "L'île perdue";
                Ponyoland.Text = "Ponyoland";
                IleDevastee.Text = "L'île dévastée";
            }
        }

        public void ChangeIsland(string IslandName)
        {
            foreach (MapIsland island in _w.Islands.Values)
            {
                if (island.IslandName == IslandName)
                {
                    if (_w.ChangeActualIsland(island, _militia))
                    {
                        if(_militia == false) ok.Visible = true;
                        _militia = false;
                    }
                    World_Load(null, null);
                }
            }
        }

        private void Ponyoland_Click(object sender, EventArgs e)
        {
            if (_w.ActualIsland == "Ponyoland")
            {
                Ponyoland uc = new Ponyoland(_contextForm, _w);
                _contextForm.ChangeUC(uc, true);
            }
            else
            {
                ChangeIsland("Ponyoland");
            }
        }

        private void IlePerdue_Click(object sender, EventArgs e)
        {
            ChangeIsland("L'île perdue");
        }

        private void IleDevastee_Click(object sender, EventArgs e)
        {
            ChangeIsland("L'île dévastée");
        }

        private void Genefort_Click(object sender, EventArgs e)
        {
            ChangeIsland("Genefort");
        }

        private void ok_Click(object sender, EventArgs e)
        {
            ok.Visible = false;
        }
    }
}
