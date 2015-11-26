using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LogicalGame;
using GraphicalInterface.Services;

namespace GraphicalInterface
{
    public partial class Merchant : UserControl
    {
        private MainForm _contextForm;

        Team _t;
        LogicalGame.Merchant m;

        public Merchant(MainForm contextForm, LogicalGame.Merchant merchant, Team t)
        {
            _t = t;
            m = merchant;
            _contextForm = contextForm;

            m.Invent = t.Invent;

            InitializeComponent();
        }

        internal void Buy_Click (object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int quantity = int.Parse(button.Parent.Controls.Find("NQuantity", false)[0].Text);
            Item item = (Item)button.Tag;

            m.BuyItems(item, quantity);

            LGold.Text = _t.Invent.GetGold.ToString();
            LoadItemToSell();

        }

        internal void Sell_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int quantity = int.Parse(button.Parent.Controls.Find("NQuantity", false)[0].Text);
            Item item = (Item)button.Tag;

            if (_t.Invent.Inventory.ContainsKey(item) && quantity <= _t.Invent.Inventory[item])
            {
                for (int i = 0; i < quantity; i++)
                {
                    m.SellItems(item);
                }
                if (_t.Invent.Inventory.ContainsKey(item) && _t.Invent.Inventory[item] > 0)
                {
                    ((ItemInformations)button.Parent).ItemQuantityLabel.Text = "x " + _t.Invent.Inventory[item].ToString();
                    ((ItemInformations)button.Parent).ItemMaximumQuantity = _t.Invent.Inventory[item];
                }
                else if (PageSell.Controls.Contains(button.Parent)) PageSell.Controls.Remove(button.Parent);
            }
            else
            {
                LError.Text = "Hum...il y a un soucis. C'est pluôt génant";
                LError.Visible = true;
            }

            LGold.Text = _t.Invent.GetGold.ToString() + " PO";
            Arange();

        }

        internal void Arange ()
        {

            TabPage page = ItemLists.SelectedTab;
            int i = 0;

            foreach (Control item in page.Controls)
            {
                item.Top = i * (item.Height + 3);
                i++;
            }
        }

        internal void LoadItemToSell()
        {
            Dictionary<Item, int> items = _t.Invent.Inventory;
            int j = 0;

            PageSell.Controls.Clear();

            foreach (Item i in items.Keys)
            {

                Item item = i;
                ToolTip toolTip = new ToolTip();
                ItemInformations UCItem = new ItemInformations();

                string infoItem;

                UCItem.Top = j * (3 + UCItem.Height);

                UCItem.ItemName = item.GetName;

                UCItem.ItemQuantity = "1";

                UCItem.ItemQuantityInvent = "x " + items[i].ToString();
                UCItem.ItemQuantityInventVisible = true;

                UCItem.ItemPrice = "" + item.GetValue + " PO";

                infoItem = item.GetDescription;

                UCItem.ItemTag = item;

                UCItem.ItemMaximumQuantity = _t.Invent.Inventory[i];

                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.ShowAlways = true;
                toolTip.SetToolTip(UCItem, infoItem);


                PageSell.Controls.Add(UCItem);
                UCItem.ItemActionName = "Vendre";
                UCItem.ItemAction(new EventHandler(Sell_Click));

                LGold.Text = _t.Invent.GetGold.ToString() + " PO";

                j++;
            }
        }

        private void LoadItemToBuy()
        {
            List<Item> items = m.GetItemsAvailable;

            for (int i = 0; i < items.Count; i++)
            {
                Item item = items[i];
                ToolTip toolTip = new ToolTip();
                ItemInformations UCItem = new ItemInformations();

                string infoItem;

                UCItem.Top = i * 55;

                UCItem.ItemName = items[i].GetName;

                UCItem.ItemQuantity = "1";

                UCItem.ItemQuantityInventVisible = false;

                UCItem.ItemPrice = "" + items[i].GetValue + " PO";

                infoItem = items[i].GetDescription;

                UCItem.ItemTag = item;

                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.ShowAlways = true;
                toolTip.SetToolTip(UCItem, infoItem);

                PageBuy.Controls.Add(UCItem);
                UCItem.ItemActionName = "Acheter";
                UCItem.ItemAction(new EventHandler(Buy_Click));

                LGold.Text = _t.Invent.GetGold.ToString() + " PO";
            }
        }
        private void IGMerchant_Load(object sender, EventArgs e)
        {
            if ((String)ItemLists.SelectedTab.Tag == "Sell")
            {
                LoadItemToSell();
            }
            else
            {
                LoadItemToBuy();
            }
        }

        private void TableChanged (object sender, EventArgs e)
        {
            if ((String)ItemLists.SelectedTab.Tag == "Sell")
            {
                LoadItemToSell();
            }
            else
            {
                LoadItemToBuy();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _contextForm.ExitMenu(this);
        }
    }
}
