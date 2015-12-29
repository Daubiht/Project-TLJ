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
            _inventory = inventory;
            _contextForm = contextForm;
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            label1.Text = "Poids : " + _inventory.weight + "/" + _inventory.MaxWeight + " - " + _inventory.GetGold + " pièces d'or";
            label1.Location = new Point(Width / 2 - label1.Width / 2, 0);

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
                b.BackColor = Color.Transparent;
                b.FlatAppearance.MouseDownBackColor = Color.Transparent;
                b.FlatAppearance.MouseOverBackColor = Color.Transparent;
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.Font = new System.Drawing.Font(_contextForm.Font.Families[0], 11);


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
                b.Width = 88;
                b.Height = 50;
                b.Tag = item;

                panel1.Controls.Add(b);
                if (i > 7)
                {
                    i = 0;
                    j++;
                }
                b.Left = i*90;
                b.Top = j*52;
                b.Text = item.GetName + " - " + _inventory.Inventory[item];


                i++;
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            _contextForm.ExitMenu(this);
        }
        private void Remove_It(object sender, EventArgs e)
        {
            if (jeter.ForeColor == Color.Red)
            {
                Item i = ((Button)sender).Tag as Item;
                if (_inventory.RemoveItem(i) == 0)
                {
                    int j = 0;
                    int k = 0;

                    panel1.Controls.Remove((Button) sender);

                    foreach (Button button in panel1.Controls)
                    {
                        if (j > 7)
                        {
                            j = 0;
                            k++;
                        }
                        button.Left = j * 90;
                        button.Top = k * 52;
                        j++;
                    }
                }
            }
        }
        private void jeter_Click(object sender, EventArgs e)
        {
            if (((Button)sender).ForeColor != Color.Red)
            {
                ((Button)sender).ForeColor = Color.Red;
            }
            else
            {
                ((Button)sender).ForeColor = Color.Black;
            }
        }
    }
}