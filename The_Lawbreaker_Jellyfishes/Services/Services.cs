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
        static Character d = new Character("Georgina", "Dwarf", true);
        static Character f = new Character("Georgette", "Dwarf", true);
        static Character g = new Character("Georgeo", "Dwarf", true);
        static Team t = new Team("lol", c);
        public static Taverne taverne = new Taverne(t);

        ListItems listItems = new ListItems();

        Merchant m = new Merchant(t);

        public Services()
        {
            InitializeComponent();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            m.AddItem(listItems.Items[0]);
            m.AddItem(listItems.Items[1]);
            m.AddItem(listItems.Items[2]);

            t.Invent.AddGold(10000);

            t.AddMembers(d);
            t.AddMembers(f);

            IGMortuary mortuary = new IGMortuary(t);
            IGMerchant merchant = new IGMerchant(t, m);
            taverne.Load += new System.EventHandler(Taverne.Taverne_Load);
            IGTeamManagement tm = new IGTeamManagement(t);

            Controls.Add(tm);
        }

        //=====================TAVERNE========================
       
    }
}
