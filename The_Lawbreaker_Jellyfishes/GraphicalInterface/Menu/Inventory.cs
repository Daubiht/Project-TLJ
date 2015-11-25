using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Inventory : UserControl
    {
        Invent _inventory;
        MainForm _contextForm;

        public Inventory(MainForm contextForm, Invent inventory)
        {
            InitializeComponent();
            _inventory = inventory;
            _contextForm = contextForm;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            label1.Text = "Poids : " + _inventory.weight + "/" + _inventory.MaxWeight;

            ToolTip toolTip = new ToolTip();
            toolTip.InitialDelay = 250;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.AutoPopDelay = 32000;
            
            panel1.Controls.Clear();

            int i = 0;
            int j = 0;
            foreach (Item item in _inventory.Inventory.Keys)
            {
                Button b = new Button();

                string infoItem = item.GetName + " " + "(" + item.Type + ")" + Environment.NewLine + item.GetDescription +
                                  Environment.NewLine + "Valeur : " + item.GetValue + Environment.NewLine + "Poids : " + item.GetWeight;

                if (item.GetRequired.Count != 0)
                {
                    infoItem += Environment.NewLine + "Requis :";
                    foreach (string requi in item.GetRequired.Keys)
                    {
                        infoItem += Environment.NewLine + item.GetRequired[requi] + " " + requi;
                    }
                }

                if (item.GetStats.Count != 0)
                {
                    infoItem += Environment.NewLine + "Bonus :";
                    foreach (string bonus in item.GetStats.Keys)
                    {
                        infoItem += Environment.NewLine + item.GetStats[bonus] + " " + bonus;
                    }
                }
                
                toolTip.SetToolTip(b, infoItem);

                b.Click += Remove_It;
                b.Width = 75;
                b.Height = 50;
                b.Tag = item;
                panel1.Controls.Add(b);
                if (i > 4)
                {
                    i = 0;
                    j++;
                }
                b.Left = i*75;
                b.Top = j*50;
                b.Text = item.GetName + " - x" + _inventory.Inventory[item];


                i++;
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            _contextForm.ExitMenu(this);
        }
        private void Remove_It(object sender, EventArgs e)
        {
            if (jeter.BackColor == Color.DarkRed)
            {
                Item i = ((Button)sender).Tag as Item;
                if (_inventory.RemoveItem(i) == 0)
                {
                    int j = 0;
                    int k = 0;

                    panel1.Controls.Remove((Button) sender);

                    foreach (Button button in panel1.Controls)
                    {
                        if (j > 4)
                        {
                            j = 0;
                            k++;
                        }
                        button.Left = j * 75;
                        button.Top = k * 50;
                        j++;
                    }
                }
            }
        }
        private void jeter_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.DarkRed)
            {
                ((Button)sender).BackColor = Color.DarkRed;
                ((Button)sender).ForeColor = Color.White;
            }
            else
            {
                ((Button)sender).BackColor = Color.Transparent;
                ((Button)sender).ForeColor = Color.Black;
            }
        }
    }
}