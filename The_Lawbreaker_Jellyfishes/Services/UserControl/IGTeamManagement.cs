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
    public partial class IGTeamManagement : UserControl
    {
        Team t;
        EventHandlerList hl = new EventHandlerList();

        public IGTeamManagement(Team team)
        {
            t = team;

            InitializeComponent();
        }

        internal void Info_Click (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Character c = (Character)button.Tag;

            IGCharactereManagement cm = new IGCharactereManagement(c, t);
            Control parent = Parent;
            parent.Controls.Clear();
            parent.Controls.Add(cm);
        }

        internal void Position_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Character c = (Character)button.Tag;

            c.FrontPosition = !c.FrontPosition;

            ReloadTeamManagement();
        }

        internal void ReloadTeamManagement ()
        {
            Controls.Clear();
            int i = 0;

            foreach (Character chara in t.Members)
            {
                GroupBox bg = new GroupBox();
                Label name = new Label();
                Label level = new Label();
                Button infos = new Button();
                Button position = new Button();

                bg.Controls.Add(name);
                bg.Controls.Add(infos);
                bg.Controls.Add(position);
                bg.Controls.Add(level);
                Controls.Add(bg);

                bg.Top = (i * 70);
                bg.Width = bg.Parent.Width;
                bg.Height = 70;

                infos.Height = 30;
                infos.Width = 30;
                infos.Left = bg.Width - infos.Width - 5;
                infos.Top = bg.Height / 2 - infos.Height / 2;
                infos.Click += new EventHandler(Info_Click); ;
                infos.Tag = chara;

                name.Top = bg.Height / 2 - name.Height / 2;
                name.Text = chara.Name;
                name.Name = "name";

                if (chara.FrontPosition)
                {
                    position.Text = "F";
                }
                else
                {
                    position.Text = "B";
                }
                position.Width = 30;
                position.Left = name.Right;
                position.Top = bg.Height / 2 - position.Height / 2;
                position.Click += new EventHandler(Position_Click);
                position.Tag = chara;

                name.Top = bg.Height / 2 - name.Height / 2;
                name.Text = chara.Name;
                name.Name = "name";

                level.Text = "Niveau " + chara.Level;
                level.Top = bg.Height / 2 - level.Height / 2;
                level.Left = position.Right + 30;

                i++;
            }
        }

        private void IGTeamManagement_Load(object sender, EventArgs e)
        {
            ReloadTeamManagement();
        }
    }
}
