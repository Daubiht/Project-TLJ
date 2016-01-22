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
    public partial class ItemInformations : UserControl
    {
        FontFamily[] _fonts;

        public ItemInformations(FontFamily[] fonts)
        {
            _fonts = fonts;
            InitializeComponent();
        }

        public Item ItemTag
        {
            get { return (Item)BBuy.Tag; }
            set { BBuy.Tag = value; }
        }

        public string ItemName
        {
            get { return LName.Text; }
            set { LName.Text = value; }
        }

        public Label ItemNameLabel
        {
            get { return LName; }
        }

        public string ItemPrice
        {
            get { return LPrice.Text; }
            set { LPrice.Text = value; }
        }

        public string ItemQuantity
        {
            get { return NQuantity.Text; }
            set { NQuantity.Text = value; }
        }

        public string ItemActionName
        {
            get { return BBuy.Text; }
            set { BBuy.Text = value; }
        }

        public string ItemQuantityInvent
        {
            get { return LQuantity.Text; }
            set { LQuantity.Text = value; }
        }

        public bool ItemQuantityInventVisible
        {
            get { return LQuantity.Visible; }
            set { LQuantity.Visible = value; }
        }

        public Label ItemQuantityLabel
        {
            get { return LQuantity; }
        }

        public int ItemMaximumQuantity
        {
            get { return (int)NQuantity.Maximum; }
            set { NQuantity.Maximum = value; }
        }
    

        public void ItemAction (EventHandler hEvent)
        {
            BBuy.Click += hEvent;
        }
    }
}
