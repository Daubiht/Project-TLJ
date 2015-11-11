using LogicalGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Services
{
    public partial class Services : Form
    {
        static Character c = new Character("George", "Dwarf", true);
        static Team t = new Team("lol", c);
        public static Taverne taverne = new Taverne(t);

        Merchant m = new Merchant(t, null);

        public Services()
        {
            InitializeComponent();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            m.

            IGMortuary mortuary = new IGMortuary();
            IGMerchant merchant = new IGMerchant(t, );
            taverne.Load += new System.EventHandler(Taverne.Taverne_Load);

            Controls.Add(merchant);
        }

        //=====================TAVERNE========================
       
    }
}
