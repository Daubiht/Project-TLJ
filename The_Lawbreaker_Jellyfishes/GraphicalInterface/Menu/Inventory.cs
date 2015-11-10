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
    public partial class Inventory : UserControl
    {
        MapWorld _contextWorld;
        MainForm _contextForm;

        public Inventory(MainForm contextForm, MapWorld contextWorld)
        {
            InitializeComponent();
            _contextWorld = contextWorld;
            _contextForm = contextForm;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            label1.Text = "Poids : " + _contextWorld.Team.Invent.weight + "/" + _contextWorld.Team.Invent.MaxWeight;

            int i = 0;
            int j = 0;
            foreach (var item in _contextWorld.Team.Invent.Inventory.Keys)
            {
                Button b = new Button();
                panel1.Controls.Add(b);
                b.Width = 75;
                b.Height = 50;
                if (i > 4)
                {
                    i = 0;
                    j++;
                }
                b.Left = i*75;
                b.Top = j*50;
                b.Text = item.GetName + " - x" + _contextWorld.Team.Invent.Inventory[item];
                i++;
            }
        }
    }
}