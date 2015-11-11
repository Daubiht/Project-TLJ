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
    public partial class IGMortuary : UserControl
    {
        static Character c = new Character("Pjvdnl", "Dwarf", true);
        Mortuary m = new Mortuary();
        Team t = new Team("lol", c);
        EventHandlerList hl = new EventHandlerList();

        Character p = new Character("George", "Dwarf", true);
        Character g = new Character("sgsdf", "Dwarf", true);
        Character h = new Character("sgsdsdff", "Dwarf", true);
        Character k = new Character("sgssdfsdf", "Dwarf", true);
        Character n = new Character("sgqsdsdf", "Dwarf", true);
        Character o = new Character("sgshjkdf", "Dwarf", true);

        int i;

        

        public IGMortuary()
        {
            t.AddMembers(p);
            t.AddMembers(g);
            t.AddMembers(h);
            t.AddMembers(k);

            p.isAlive = false;
            g.isAlive = false;
            k.isAlive = false;

            m.DepositBody(k);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void stock_click(object sender, EventArgs e)
        {
            var parent = Parent;
            Character member;
            string name;
            Button button = ((Button)sender);

            name = button.Parent.Controls.Find("name", false)[0].Text;

            for (int i = 0; i < t.Members.Count; i++)
            {
                member = t.Members[i];
                if (member.Name == name)
                {
                   Console.WriteLine( m.DepositBody(member));
                }
                
            }

            ReloadList();
        }

        private void get_click(object sender, EventArgs e)
        {
            var parent = Parent;
            Character member;
            string name;
            Button button = ((Button)sender);

            name = button.Parent.Controls.Find("name", false)[0].Text;

            for (int i = 0; i < m.BodyList.Count; i++)
            {
                member = m.BodyList[i];
                if (member.Name == name)
                {
                    Console.WriteLine(m.takeBackBody(member, t));
                }

            }

            ReloadList();
        }

        public void ReloadList ()
        {
            if (m.BodyList.Count == 0)
            {
                Label l = new Label();
                l.Text = "Cette morgue n'accueil aucun de vos compagnon. Du moins, pas encore :D";
                l.Top = 150;
                l.Width = this.Width;
                TCMPage1.Controls.Add(l);
            }
            // Mortuary

            TCMPage1.Controls.Clear();
            for (int j = 0; j < m.BodyList.Count; j++)
            {
                GroupBox bg = new GroupBox();
                Label name = new Label();
                Button get = new Button();
                EventHandler eh = new EventHandler(get_click);

                get.Click += eh;
                get.Height = 30;
                get.Width = 30;

                name.Top = 50;
                name.Text = m.BodyList[j].Name;
                name.Name = "name";

                bg.Controls.Add(name);
                bg.Controls.Add(get);

                get.Left = 100;
                get.Top = get.Parent.Height / 2 - get.Width / 2;

                TCMPage1.Controls.Add(bg);

                bg.Top = (j * 100);
                bg.Width = bg.Parent.Width;
            }

            // Team
            i = 0;
            TCMPage2.Controls.Clear();
            foreach (Character chara in t.Members)
            {
                

                if (!chara.isAlive)
                {
                    GroupBox bg = new GroupBox();
                    Label name = new Label();
                    Button stock = new Button();
                    EventHandler eh = new EventHandler(stock_click);

                    hl.AddHandler(stock, eh);
                    stock.Click += eh;

                    stock.Height = 30;
                    stock.Width = 30;

                    name.Top = 50;
                    name.Text = chara.Name;
                    name.Name = "name";

                    bg.Controls.Add(name);
                    bg.Controls.Add(stock);

                    stock.Left = 100;
                    stock.Top = stock.Parent.Height / 2 - stock.Width / 2;

                    TCMPage2.Controls.Add(bg);

                    bg.Top = (i * 100);
                    bg.Width = bg.Parent.Width;

                    i++;
                }

            }

            if (i == 0)
            {
                Label l = new Label();
                l.Text = "Aucun de vos compagnon ne sont des cadavres froids. Dommage :(";
                l.Top = 150;
                l.Width = this.Width;
                TCMPage2.Controls.Add(l);
            }
        }
    }
}
