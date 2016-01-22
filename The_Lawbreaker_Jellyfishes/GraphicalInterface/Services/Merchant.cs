using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Merchant : UserControl
    {
        Controller _ctrler;
        Dictionary<Item, int> _requiredItem = new Dictionary<Item, int>();
        Invent _invent;
        LogicalGame.Merchant _m;
        string _page;

        public Merchant(Controller ctrler, LogicalGame.Merchant merchant, Invent invent)
        {
            _invent = invent;
            _m = merchant;
            _ctrler = ctrler;
            InitializeComponent();
            _page = "Buy";

            LGold.Location = new Point(LGold.Parent.Width / 2 - LGold.Width / 2, LGold.Top);

            _requiredItem.Add(new ListItems().Items[4], 10);
            _requiredItem.Add(new ListItems().Items[5], 2);
            _requiredItem.Add(new ListItems().Items[6], 5);
        }

        internal void Buy_Click (object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int quantity = int.Parse(button.Parent.Controls.Find("NQuantity", false)[0].Text);
            Item item = (Item)button.Tag;

            _m.BuyItems(item, quantity);

            LGold.Text = _invent.GetGold.ToString();
            LGold.Location = new Point(LGold.Parent.Width / 2 - LGold.Width / 2, LGold.Top);
            LoadItemToBuy();

        }

        private double countReduce ()
        {
            int count = 0;
            foreach (Character chara in _invent.Context.Members)
            {
                if (chara.Race == "Human" || chara.Race == "human" || chara.Race == "Humain")
                {
                    count++;
                }
            }
            return count * 0.05;
        }

        internal void Sell_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int quantity = int.Parse(button.Parent.Controls.Find("NQuantity", false)[0].Text);
            Item item = (Item)button.Tag;

            if (_invent.Inventory.ContainsKey(item) && quantity <= _invent.Inventory[item])
            {
                for (int i = 0; i < quantity; i++)
                {
                    _m.SellItems(item);
                }
                if (_invent.Inventory.ContainsKey(item) && _invent.Inventory[item] > 0)
                {
                    ((ItemInformations)button.Parent).ItemQuantityLabel.Text = "x " + _invent.Inventory[item].ToString();
                    ((ItemInformations)button.Parent).ItemMaximumQuantity = _invent.Inventory[item];
                }
                else if (Page.Controls.Contains(button.Parent)) Page.Controls.Remove(button.Parent);
            }
            else
            {
                LError.Text = "Hum...il y a un soucis. C'est plutôt génant";
                LError.Visible = true;
            }

            LGold.Text = "Poids : " + _invent.weight + "/" + _invent.MaxWeight + " - " + _invent.GetGold + " pièces d'or";
            LGold.Location = new Point(LGold.Parent.Width / 2 - LGold.Width / 2, LGold.Top);
            Arange();

        }

        internal void Arange ()
        {
            int i = 0;

            foreach (Control item in Page.Controls)
            {
                item.Top = i * (item.Height + 3);
                i++;
            }
        }

        internal void LoadItemToSell()
        {
            Dictionary<Item, int> items = _invent.Inventory;
            int j = 0;

            Page.Controls.Clear();

            foreach (Item i in items.Keys)
            {

                Item item = i;
                ToolTip toolTip = new ToolTip();
                ItemInformations UCItem = new ItemInformations(_ctrler.Font.Families);

                UCItem.Top = j * (3 + UCItem.Height);

                UCItem.ItemName = item.GetName;

                UCItem.ItemQuantity = "1";

                UCItem.ItemQuantityInvent = "x " + items[i].ToString();
                UCItem.ItemQuantityInventVisible = true;

                UCItem.ItemPrice = (int)Math.Round(item.GetValue*0.8) + (int)Math.Round(countReduce()*0.8*item.GetValue) + " PO";

                string infoItem = i.GetName + " " + "(" + i.Type + ")" + Environment.NewLine + i.GetDescription + Environment.NewLine + "Valeur : " + i.GetValue + Environment.NewLine + "Poids : " + i.GetWeight;

                if (i.GetRequired.Count != 0)
                {
                    infoItem += Environment.NewLine + "Requis :";
                    foreach (string requi in i.GetRequired.Keys)
                    {
                        infoItem += Environment.NewLine + i.GetRequired[requi] + " " + requi;
                    }
                }

                if (i.GetStats.Count != 0)
                {
                    infoItem += Environment.NewLine + "Bonus :";
                    foreach (string bonus in i.GetStats.Keys)
                    {
                        infoItem += Environment.NewLine + i.GetStats[bonus] + " " + bonus;
                    }
                }

                UCItem.ItemTag = item;

                UCItem.ItemMaximumQuantity = _invent.Inventory[i];

                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.ShowAlways = true;
                toolTip.SetToolTip(UCItem, infoItem);
                toolTip.SetToolTip(UCItem.ItemNameLabel, infoItem);

                Page.Controls.Add(UCItem);
                UCItem.ItemActionName = "vendre";
                UCItem.ItemAction(new EventHandler(Sell_Click));

                LGold.Text = "Poids : " + _invent.weight + "/" + _invent.MaxWeight + " - " + _invent.GetGold + " pièces d'or";
                LGold.Location = new Point(LGold.Parent.Width / 2 - LGold.Width / 2, LGold.Top);

                j++;
            }
        }

        private void LoadItemToBuy()
        {
            List<Item> items = _m.GetItemsAvailable;

            Page.Controls.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                Item item = items[i];
                ToolTip toolTip = new ToolTip();
                ItemInformations UCItem = new ItemInformations(_ctrler.Font.Families);

                UCItem.Top = i * 55;

                UCItem.ItemName = items[i].GetName;

                UCItem.ItemQuantity = "1";

                UCItem.ItemQuantityInventVisible = false;

                UCItem.ItemPrice = _m.ItemToBuyPrice(item) + " PO";

                string infoItem = items[i].GetName + " " + "(" + items[i].Type + ")" + Environment.NewLine + items[i].GetDescription + Environment.NewLine + "Valeur : " + items[i].GetValue + Environment.NewLine + "Poids : " + items[i].GetWeight;

                if (items[i].GetRequired.Count != 0)
                {
                    infoItem += Environment.NewLine + "Requis :";
                    foreach (string requi in items[i].GetRequired.Keys)
                    {
                        infoItem += Environment.NewLine + items[i].GetRequired[requi] + " " + requi;
                    }
                }

                if (items[i].GetStats.Count != 0)
                {
                    infoItem += Environment.NewLine + "Bonus :";
                    foreach (string bonus in items[i].GetStats.Keys)
                    {
                        infoItem += Environment.NewLine + items[i].GetStats[bonus] + " " + bonus;
                    }
                }

                UCItem.ItemTag = item;

                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.ShowAlways = true;
                toolTip.SetToolTip(UCItem, infoItem);
                toolTip.SetToolTip(UCItem.ItemNameLabel, infoItem);

                Page.Controls.Add(UCItem);
                UCItem.ItemActionName = "acheter";
                UCItem.ItemAction(new EventHandler(Buy_Click));

                LGold.Text = "Poids : " + _invent.weight + "/" + _invent.MaxWeight + " - " + _invent.GetGold + " pièces d'or";
                LGold.Location = new Point(LGold.Parent.Width / 2 - LGold.Width / 2, LGold.Top);
            }
        }

        private void CraftLoad (bool isSuccess)
        {
            Page.Controls.Clear();
            

            Label resource = new Label();
            Label error = new Label();
            Label LSuccess = new Label();
            Button BCraft = new Button();

            BCraft.AutoSize = true;
            BCraft.BackColor = Color.Transparent;
            BCraft.Cursor = Cursors.Hand;
            BCraft.FlatAppearance.BorderSize = 0;
            BCraft.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BCraft.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BCraft.FlatStyle = FlatStyle.Flat;
            BCraft.Font = new Font(_ctrler.Font.Families[0], 30);

            resource.Font = new Font(_ctrler.Font.Families[1], 18);
            error.Font = new Font(_ctrler.Font.Families[1], 18);
            LSuccess.Font = new Font(_ctrler.Font.Families[1], 18);

            LSuccess.Text = "Vous avez fabriqué une orbe de résurrection.";
            LSuccess.ForeColor = Color.Green;
            LSuccess.Name = "LSuccess";
            if (!isSuccess)
            {
                LSuccess.Visible = false;
            }

            BCraft.Click += Craft_Click;

            BCraft.Text = "fabriquer";
            resource.Text = "Ce marchand vous propose de créer" + Environment.NewLine + "une orbe de résurrection permettant" + Environment.NewLine + "de ramener à la vie un membre de votre équipe" + Environment.NewLine+"pour cela il vous faut : " + Environment.NewLine;
            error.Text = "";

            foreach (Item item in _requiredItem.Keys)
            {
                resource.Text = resource.Text + " - " + item.GetName + " : " + _requiredItem[item] + Environment.NewLine;
                bool find = false;
                Item itemUse = null;
                foreach (Item itemInvent in _invent.Inventory.Keys)
                {
                    if (itemInvent.GetName == item.GetName)
                    {
                        find = true;
                        itemUse = itemInvent;
                    }
                }

                if (find == true)
                {
                    if (_invent.Inventory[itemUse] < _requiredItem[item])
                    {
                        if (error.Text == "")
                        {
                            error.Text = error.Text + "Il vous manque encore : " + Environment.NewLine;
                        }
                        error.Text = error.Text + " - " + item.GetName + " : " + (_requiredItem[item] - _invent.Inventory[itemUse]) + Environment.NewLine;
                        BCraft.Enabled = false;
                    }
                }
                else
                {
                    if (error.Text == "")
                    {
                        error.Text = error.Text + "Il vous manque encore : " + Environment.NewLine;
                    }
                    error.Text = error.Text + " - " + item.GetName + " : " + _requiredItem[item] + Environment.NewLine;
                    BCraft.Enabled = false;
                }
            }

            if (error.Text == "") error.Text = "Vous pouvez fabriquer cet objet.";

            Page.Controls.Add(resource);
            Page.Controls.Add(error);
            Page.Controls.Add(BCraft);
            Page.Controls.Add(LSuccess);

            error.AutoSize = true;
            resource.AutoSize = true;

            resource.Left = Page.Width / 2 - resource.Width / 2;
            resource.Top = 10;
            error.Left = Page.Width / 2 - error.Width / 2;
            error.Top = resource.Bottom + 100;

            BCraft.Top = Page.Height - BCraft.Height - 10;
            BCraft.Left = Page.Width / 2 - BCraft.Width / 2;

            LSuccess.AutoSize = true;
            LSuccess.Left = LSuccess.Parent.Width / 2 - LSuccess.Width / 2;
            LSuccess.Top = BCraft.Top - 10 - LSuccess.Height;

            error.Visible = false;
            resource.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void Craft_Click (object sender, EventArgs e)
        {
            Item itemInvent = null;
            foreach (Item item in _requiredItem.Keys)
            {
                foreach(Item itemTemp in _invent.Inventory.Keys)
                {
                    if (itemTemp.GetName == item.GetName)
                    {
                        itemInvent = itemTemp;
                    }
                }
                _invent.Inventory[itemInvent] -= _requiredItem[item];
                if (_invent.Inventory[itemInvent] == 0) _invent.Inventory.Remove(itemInvent);
            }

            _invent.AddItem(new ListItems().Items[3], 1);

            //((Label)(ItemLists.SelectedTab.Controls.Find("LSuccess", false)[0])).Visible = true;

            CraftLoad(true);

        }

        private void IGMerchant_Load(object sender, EventArgs e)
        {
            if (_page == "Sell")
            {
                LoadItemToSell();
            }
            else
            {
                LoadItemToBuy();
            }

            if (_m.Name == "herboriste")
            {
                BAlchemist.Visible = true;
            }
        }

        private void TableChanged ()
        {
            if (_page == "Sell")
            {
                LoadItemToSell();
            }
            else if (_page == "Buy")
            {
                LoadItemToBuy();
            }
            else
            {
                CraftLoad(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ctrler.ExitMenu(this);
        }

        private void ChangePage(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string page = (string)button.Tag;

            if(page == "Sell")
            {
                BSell.Font = new Font(_ctrler.Font.Families[0], 25, FontStyle.Underline);
                BBuy.Font = new Font(_ctrler.Font.Families[0], 25);
                BAlchemist.Font = new Font(_ctrler.Font.Families[0], 25);
            }
            else if(page == "Buy")
            {
                BSell.Font = new Font(_ctrler.Font.Families[0], 25);
                BBuy.Font = new Font(_ctrler.Font.Families[0], 25, FontStyle.Underline);
                BAlchemist.Font = new Font(_ctrler.Font.Families[0], 25);
            }
            else
            {
                BSell.Font = new Font(_ctrler.Font.Families[0], 25);
                BBuy.Font = new Font(_ctrler.Font.Families[0], 25);
                BAlchemist.Font = new Font(_ctrler.Font.Families[0], 25, FontStyle.Underline);
            }

            _page = page;
            TableChanged();
        }
    }
}
