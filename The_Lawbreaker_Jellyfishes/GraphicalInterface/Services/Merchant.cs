﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LogicalGame;

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

            InitializeComponent();
        }

        internal void Buy_Click (object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int quantity = int.Parse(button.Parent.Controls.Find("quantity", false)[0].Text);
            Item item = (Item)button.Tag;

            m.BuyItems(item, quantity);

            LGold.Text = _t.Invent.GetGold.ToString();
            LoadItemToSell();

        }

        internal void Sell_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int quantity = int.Parse(button.Parent.Controls.Find("quantity", false)[0].Text);
            Item item = (Item)button.Tag;

            Console.WriteLine(_t.Invent.Inventory.ContainsKey(item));
            Console.WriteLine(_t.Invent.Inventory[item]);
            Console.WriteLine(quantity);

            if (_t.Invent.Inventory.ContainsKey(item) && quantity <= _t.Invent.Inventory[item])
            {
                for (int i = 0; i < quantity; i++)
                {
                    m.SellItems(item);
                }
            }
            else
            {
                LError.Text = "Hum...il y a un soucis LOL";
                LError.Visible = true;
            }

            LGold.Text = _t.Invent.GetGold.ToString();
            LoadItemToSell();

        }

        internal void Plus_Click_Sell(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Object[] tag = (Object[])button.Tag;
            TextBox quantity = (TextBox)tag[0];

            int quant = int.Parse(quantity.Text) + 1;

            if (quant <= _t.Invent.Inventory[(Item)tag[1]])
            {
                quantity.Text = "" + quant;
            }
        }

        internal void Plus_Click (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Object[] tag = (Object[])button.Tag;
            TextBox quantity = (TextBox)tag[0];
            int quant = int.Parse(quantity.Text) + 1;

            quantity.Text = quant.ToString();
        }

        internal void Minus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            TextBox quantity = (TextBox)button.Tag;

            if (int.Parse(quantity.Text) - 1 > 0)
            {
                int quant = int.Parse(quantity.Text) - 1;
                quantity.Text = quant.ToString();
            }
        }

        internal void LoadItemToSell()
        {
            Dictionary<Item, int> items = _t.Invent.Inventory;
            int j = 0;

            PageSell.Controls.Clear();

            foreach (Item i in items.Keys)
            {
                
                Panel PObj = new Panel();
                Label name = new Label();
                Label LQuantity = new Label();
                Button sell = new Button();
                Button plus = new Button();
                Button minus = new Button();
                TextBox quantity = new TextBox();
                ToolTip toolTip = new ToolTip();
                Label cost = new Label();

                string infoItem;

                PObj.BorderStyle = BorderStyle.FixedSingle;
                PObj.Top = j * 55;
                PObj.Width = 387;
                PObj.Height = 50;
                PObj.BackColor = Color.FromArgb(250, 244, 211);

                name.Text = i.GetName;
                name.Top = PObj.Height / 2 - name.Height / 2;

                sell.Text = "Vendre";
                sell.Top = (PObj.Height / 2) - (sell.Height / 2);
                sell.Left = PObj.Width - sell.Width - 10;
                sell.Tag = i;
                sell.Click += new EventHandler(Sell_Click);

                quantity.Text = "1";
                quantity.Width = 20;
                quantity.Top = (PObj.Height / 2) - (quantity.Height / 2);
                quantity.Left = PObj.Width - sell.Width - quantity.Width - 50;
                quantity.Name = "quantity";

                LQuantity.Text = "x " + items[i];
                LQuantity.Width = 40;
                LQuantity.Top = (PObj.Height / 2) - (LQuantity.Height / 2);
                LQuantity.Left = name.Right + 10;

                plus.Text = "+";
                plus.Left = quantity.Left + quantity.Width + 5;
                plus.Top = (PObj.Height / 2) - (plus.Height / 2);
                plus.Width = 20;
                plus.Tag = new Object[] { quantity, i };
                plus.Click += new EventHandler(Plus_Click_Sell);

                minus.Text = "-";
                minus.Width = 20;
                minus.Left = quantity.Left - minus.Width - 5;
                minus.Top = (PObj.Height / 2) - (minus.Height / 2);
                minus.TabIndex = 0;
                minus.Tag = quantity;
                minus.Click += new EventHandler(Minus_Click);

                cost.Text = "" + i.GetValue + " PO";
                cost.Width = 70;
                cost.Left = minus.Left - cost.Width;

                cost.Top = (PObj.Height / 2) - (cost.Height / 2);

                infoItem = i.GetDescription;

                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.ShowAlways = true;
                toolTip.SetToolTip(PObj, infoItem);


                PObj.Controls.Add(name);
                PObj.Controls.Add(sell);
                PObj.Controls.Add(quantity);
                PObj.Controls.Add(LQuantity);
                PObj.Controls.Add(plus);
                PObj.Controls.Add(minus);
                PObj.Controls.Add(cost);

                PageSell.Controls.Add(PObj);

                LGold.Text = _t.Invent.GetGold.ToString();
                j++;
            }
        }

        private void IGMerchant_Load(object sender, EventArgs e)
        {
            List<Item> items = m.GetItemsAvailable;

            for (int i = 0; i < items.Count ; i++)
            {
                Panel PObj = new Panel();
                Label name = new Label();
                Button plus = new Button();
                Button minus = new Button();
                Button buy = new Button();
                TextBox quantity = new TextBox();
                ToolTip toolTip = new ToolTip();
                Label cost = new Label();

                string infoItem;

                PObj.BorderStyle = BorderStyle.FixedSingle;
                PObj.Top = i * 55;
                PObj.Width = 387;
                PObj.Height = 50;
                PObj.BackColor = Color.FromArgb(250, 244, 211);

                name.Text = items[i].GetName;
                name.Top = PObj.Height / 2 - name.Height / 2;

                buy.Text = "Acheter";
                buy.Top = (PObj.Height / 2) - (buy.Height / 2);
                buy.Left = PObj.Width - buy.Width - 10;
                buy.Tag = items[i];
                buy.Click += new EventHandler(Buy_Click);

                quantity.Text = "1";
                quantity.Width = 20;
                quantity.Top = (PObj.Height / 2) - (quantity.Height / 2);
                quantity.Left = PObj.Width - buy.Width - quantity.Width - 50;
                quantity.Name = "quantity";

                plus.Text = "+";
                plus.Left = quantity.Left + quantity.Width + 5;
                plus.Top = (PObj.Height / 2) - (plus.Height / 2);
                plus.Width = 20;
                plus.Tag = new Object[] { quantity, i };
                plus.Click += new EventHandler(Plus_Click);

                minus.Text = "-";
                minus.Width = 20;
                minus.Left = quantity.Left - minus.Width - 5;
                minus.Top = (PObj.Height / 2) - (minus.Height / 2);
                minus.TabIndex = 0;
                minus.Tag = quantity;
                minus.Click += new EventHandler(Minus_Click);

                cost.Text = "" + items[i].GetValue + " PO";
                cost.Left = minus.Left - cost.Width;
                cost.Top = (PObj.Height / 2) - (cost.Height / 2);

                infoItem = items[i].GetDescription;

                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 500;
                toolTip.ShowAlways = true;
                toolTip.SetToolTip(PObj, infoItem);

                PObj.Controls.Add(name);
                PObj.Controls.Add(buy);
                PObj.Controls.Add(quantity);
                PObj.Controls.Add(plus);
                PObj.Controls.Add(minus);
                PObj.Controls.Add(cost);

                PageBuy.Controls.Add(PObj);

                LGold.Text = _t.Invent.GetGold.ToString();

                LoadItemToSell();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _contextForm.ExitMenu(this);
        }
    }
}