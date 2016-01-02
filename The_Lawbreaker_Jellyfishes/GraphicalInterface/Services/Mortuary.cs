using System;
using System.ComponentModel;
using System.Windows.Forms;
using LogicalGame;


namespace GraphicalInterface
{
    public partial class Mortuary : UserControl
    {
        private LogicalGame.Mortuary m;
        private Team t;
        private Controller _ctrler;
        EventHandlerList hl = new EventHandlerList();

        int i;

        public Mortuary(Team team, Controller ctrler, LogicalGame.Mortuary mortuary)
        {
            t = team;
            m = mortuary;
            _ctrler = ctrler;

            InitializeComponent();
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
                   m.DepositBody(member);
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
                    m.takeBackBody(member);
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

        private void retour_Click(object sender, EventArgs e)
        {
            _ctrler.ExitMenu(this);
        }

        private void Mortuary_Load(object sender, EventArgs e)
        {
            ReloadList();
        }
    }
}
