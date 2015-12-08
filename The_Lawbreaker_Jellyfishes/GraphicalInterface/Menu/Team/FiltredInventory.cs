using System;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class FiltredInventory : UserControl
    {
        Team team;
        Character c;
        MainForm _contextForm;
        string filtre;
        string place;

        public FiltredInventory(Team team, Character chara, string type, MainForm contextForm)
        {
            this.team = team;
            c = chara;
            filtre = type;
            _contextForm = contextForm;
            InitializeComponent();
        }

        private void BRetour_Click(object sender, EventArgs e)
        {
            CharacterManagement uc = new CharacterManagement(c, team, _contextForm);
            _contextForm.ChangeUC(uc, false, true);
        }

        private void Equip_Click (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Item item = (Item)((Object[])button.Tag)[0];
            Object[] tag;

            if (item.Type == "resurection")
            {
                DeadMenList list = new DeadMenList(team, c, item);
                list.ShowDialog();
            }
            else if (filtre == "consommable")
            {
                if (!c.UseConsumable(item))
                {
                    LError.Text = "Impossible d'utiliser cet objet";
                    LError.Visible = true;
                }
                else
                {
                    team.Invent.RemoveItem(item);
                }
            }
            else
            {
                tag = (Object[])button.Tag;
                if (button.Tag != null) place = (string)tag[1];

                if (!c.WearItem(item, filtre))
                {
                    LError.Text = "Impossible d'équiper cet objet";
                    LError.Visible = true;
                }

                LNewName.Text = "";
                BEquip.Visible = false;
            }
            Reload();
        }

        private void Desequip_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Item item = (Item)button.Tag;

            LNewName.Text = "";
            BEquip.Visible = false;

            c.UnwearItem(filtre);
            Reload();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Item item = (Item)button.Tag;
            Object[] tag = new Object[2];

            string infoItem = item.GetName + Environment.NewLine;
            tag[0] = item;
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

            LNewName.Text = infoItem;
            LNewName.Left = LNewName.Parent.Width / 2 - LNewName.Width / 2;
            BEquip.Visible = true;
            BEquip.Tag = tag;
        }

        // Load of all items 
        private void Reload ()
        {
            inventory.Controls.Clear();

            ToolTip toolTip = new ToolTip();

            toolTip.InitialDelay = 250;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            inventory.Controls.Clear();
            if (filtre == "consommable")
            {
                PInfoOldItem.Visible = false;
                PInfoItem.Width = Parent.Width - 30;
                PInfoItem.Left = 5;
                BEquip.Text = "Utiliser";
            }

            // Recup of current stuff
            if (!c.Stuffs.ContainsKey(filtre) || c.Stuffs[filtre] == null)
            {
                LOldName.Text = "Aucun";
                LOldName.Top = LOldName.Parent.Height / 2 - LOldName.Height / 2;
                LOldName.Left = LOldName.Parent.Width / 2 - LOldName.Width / 2;
                BDesequip.Visible = false;
            }
            else
            {
                BDesequip.Tag = c.Stuffs[filtre];

                string infoItem = c.Stuffs[filtre].GetName + Environment.NewLine;
                if (c.Stuffs[filtre].GetRequired.Count != 0)
                {
                    infoItem += Environment.NewLine + "Requis :";
                    foreach (string requi in c.Stuffs[filtre].GetRequired.Keys)
                    {
                        infoItem += Environment.NewLine + c.Stuffs[filtre].GetRequired[requi] + " " + requi;
                    }
                }

                if (c.Stuffs[filtre].GetStats.Count != 0)
                {
                    infoItem += Environment.NewLine + "Bonus :";
                    foreach (string bonus in c.Stuffs[filtre].GetStats.Keys)
                    {
                        infoItem += Environment.NewLine + c.Stuffs[filtre].GetStats[bonus] + " " + bonus;
                    }
                }

                LOldName.Text = infoItem;
                LOldName.Left = LOldName.Parent.Width / 2 - LOldName.Width / 2;
                LOldName.Top = 10;

                BDesequip.Visible = true;
            }

            int i = 0;
            int j = 0;
            string ffiltre = filtre;

            if (ffiltre == "gauche" || ffiltre == "droite")
            {
                ffiltre = "arme";
            }

            // Recup and display items
            foreach (Item item in team.Invent.Inventory.Keys)
            {
                if (item.Type == ffiltre || (ffiltre == "consommable" && item.Type == "resurection"))
                {
                    Button b = new Button();

                    string infoItem = item.GetName + " " + "(" + item.Type + ")" + Environment.NewLine + item.GetDescription + Environment.NewLine + "Valeur : " + item.GetValue + Environment.NewLine + "Poids : " + item.GetWeight;

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
                    b.Tag = item;
                    inventory.Controls.Add(b);

                    b.Width = 75;
                    b.Height = 50;

                    if (i > 4)
                    {
                        i = 0;
                        j++;
                    }

                    b.Left = i * 75;
                    b.Top = j * 50;
                    b.Click += new EventHandler(Info_Click);

                    b.Text = item.GetName + " - x" + team.Invent.Inventory[item];
                    i++;
                }
            }
        }

        private void IGFiltredInventory_Load(object sender, EventArgs e)
        {
            Reload();
        }

        
    }
}
