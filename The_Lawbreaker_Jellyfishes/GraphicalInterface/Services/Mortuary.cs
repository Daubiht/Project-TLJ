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
        private MainForm _contextForm;
        EventHandlerList hl = new EventHandlerList();

        int i;

        public Mortuary(Team team, MainForm contextForm, LogicalGame.Mortuary mortuary)
        {
            t = team;
            m = mortuary;
            _contextForm = contextForm;

            InitializeComponent();
        }

        private void stock_click(object sender, EventArgs e)
        {
            var parent = Parent;
            Character member;
            Character c = (Character)((Button)sender).Tag;

            for (int i = 0; i < t.Members.Count; i++)
            {
                member = t.Members[i];
                if (member.Name == c.Name)
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
            Character c = (Character)((Button)sender).Tag;

            for (int i = 0; i < m.BodyList.Count; i++)
            {
                member = m.BodyList[i];
                if (member.Name == c.Name)
                {
                    m.takeBackBody(member);
                }
            }

            ReloadList();
        }

        public void ReloadList ()
        {
            TCMPage1.Controls.Clear();

            if (m.BodyList.Count == 0)
            {
                Label l = new Label();
                l.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 18);
                l.Text = "Aucun corps n'est préservé ici.";
                l.Top = 10;
                l.Width = this.Width;
                TCMPage1.Controls.Add(l);
            }
            // Mortuary

            for (int j = 0; j < m.BodyList.Count; j++)
            {
                Panel bg = new Panel();
                Label name = new Label();
                Button get = new Button();
                EventHandler eh = new EventHandler(get_click);

                get.Click += eh;
                get.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 20);
                get.Text = "récupérer";
                get.AutoSize = true;
                get.BackColor = System.Drawing.Color.Transparent;
                get.Cursor = Cursors.Hand;
                get.FlatAppearance.BorderSize = 0;
                get.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                get.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                get.FlatStyle = FlatStyle.Flat;

                name.AutoSize = true;
                name.Text = m.BodyList[j].Name + " - Level : " + m.BodyList[j].Level;
                name.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 16);
                name.Name = "name";

                bg.Controls.Add(name);
                bg.Controls.Add(get);

                get.Left = 220;
                get.Top = 10;
                get.Tag = m.BodyList[j];

                TCMPage1.Controls.Add(bg);

                bg.Top = (j * 65 + 10);
                if (j == 0) bg.Top = 10;
                bg.Height = 50;
                bg.Left = 10;
                bg.Width = bg.Parent.Width - 20;
                bg.BorderStyle = BorderStyle.FixedSingle;
            }

            // Team
            i = 0;
            TCMPage2.Controls.Clear();
            foreach (Character chara in t.Members)
            {
                if (!chara.isAlive)
                {
                    Panel bg = new Panel();
                    Label name = new Label();
                    Button stock = new Button();
                    EventHandler eh = new EventHandler(stock_click);

                    hl.AddHandler(stock, eh);
                    stock.Click += eh;
                    stock.Font = new System.Drawing.Font(_contextForm.Font.Families[0], 20);
                    stock.Text = "déposer";
                    stock.AutoSize = true;
                    stock.BackColor = System.Drawing.Color.Transparent;
                    stock.Cursor = Cursors.Hand;
                    stock.FlatAppearance.BorderSize = 0;
                    stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                    stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                    stock.FlatStyle = FlatStyle.Flat;

                    name.AutoSize = true;
                    name.Text = chara.Name + " - Level : " + chara.Level;
                    name.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 16);
                    name.Name = "name";

                    bg.Controls.Add(name);
                    bg.Controls.Add(stock);

                    stock.Left = 220;
                    stock.Top = 10;
                    stock.Tag = chara;

                    TCMPage2.Controls.Add(bg);

                    bg.Top = (i * 65 + 10);
                    if (i == 0) bg.Top = 10;
                    bg.Height = 50;
                    bg.Left = 10;
                    bg.Width = bg.Parent.Width - 20;
                    bg.BorderStyle = BorderStyle.FixedSingle;

                    i++;
                }

            }

            if (i == 0)
            {
                Label l = new Label();
                l.Text = "Aucun membre de l'équipe est mort.";
                l.Font = new System.Drawing.Font(_contextForm.Font.Families[1], 18);
                l.Top = 10;
                l.Width = this.Width;
                TCMPage2.Controls.Add(l);
            }
        }

        private void retour_Click(object sender, EventArgs e)
        {
            _contextForm.ExitMenu(this);
        }

        private void Mortuary_Load(object sender, EventArgs e)
        {
            ReloadList();
        }
    }
}
