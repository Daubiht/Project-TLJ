using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace Services
{
    public partial class IGMerchant : UserControl
    {
        Team t;
        Merchant m;

        public IGMerchant(Team team, Merchant merchant)
        {
            t = team;
            m = merchant;

            InitializeComponent();
        }

        private void IGMerchant_Load(object sender, EventArgs e)
        {
            List<Item> items = m.GetItemsAvailable;

            for (int i = 0; i < items.Count ; i++)
            {
                Panel PObj = new Panel();
                PObj.Top = i * 70;
                PObj.Width = 300;

                PObjects.Controls.Add(PObj);
            }
            
           

            
        }
    }
}
