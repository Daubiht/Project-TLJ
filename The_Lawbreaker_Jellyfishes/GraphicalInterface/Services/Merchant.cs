﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Merchant : UserControl
    {
        MainForm _contextForm;
        Invent _invent;
        LogicalGame.Merchant m;

        public Merchant(MainForm contextForm, LogicalGame.Merchant merchant, Invent invent)
        {
            InitializeComponent();
            _invent = invent;
            m = merchant;
            m.Invent = _invent;
            _contextForm = contextForm;

        }

        internal void Buy_Click (object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int quantity = int.Parse(button.Parent.Controls.Find("NQuantity", false)[0].Text);
            Item item = (Item)button.Tag;

            m.BuyItems(item, quantity);

            LGold.Text = _invent.GetGold.ToString();
            LoadItemToSell();

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
                    m.SellItems(item);
                }
                if (_invent.Inventory.ContainsKey(item) && _invent.Inventory[item] > 0)
                {
                    ((ItemInformations)button.Parent).ItemQuantityLabel.Text = "x " + _invent.Inventory[item].ToString();
                    ((ItemInformations)button.Parent).ItemMaximumQuantity = _invent.Inventory[item];
                }
                else if (PageSell.Controls.Contains(button.Parent)) PageSell.Controls.Remove(button.Parent);
            }
            else
            {
                LError.Text = "Hum...il y a un soucis. C'est pluôt génant";
                LError.Visible = true;
            }

            LGold.Text = _invent.GetGold.ToString() + " PO";
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
            Dictionary<Item, int> items = _invent.Inventory;
            int j = 0;

            PageSell.Controls.Clear();

            foreach (Item i in items.Keys)
            {

                Item item = i;
                ToolTip toolTip = new ToolTip();
                ItemInformations UCItem = new ItemInformations();

                UCItem.Top = j * (3 + UCItem.Height);

                UCItem.ItemName = item.GetName;

                UCItem.ItemQuantity = "1";

                UCItem.ItemQuantityInvent = "x " + items[i].ToString();
                UCItem.ItemQuantityInventVisible = true;

                UCItem.ItemPrice = "" + item.GetValue + " PO";

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

                PageSell.Controls.Add(UCItem);
                UCItem.ItemActionName = "Vendre";
                UCItem.ItemAction(new EventHandler(Sell_Click));

                LGold.Text = _invent.GetGold.ToString() + " PO";

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

                UCItem.Top = i * 55;

                UCItem.ItemName = items[i].GetName;

                UCItem.ItemQuantity = "1";

                UCItem.ItemQuantityInventVisible = false;

                UCItem.ItemPrice = "" + items[i].GetValue + " PO";

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

                PageBuy.Controls.Add(UCItem);
                UCItem.ItemActionName = "Acheter";
                UCItem.ItemAction(new EventHandler(Buy_Click));

                LGold.Text = _invent.GetGold.ToString() + " PO";
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
