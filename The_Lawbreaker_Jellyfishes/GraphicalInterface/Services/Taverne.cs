using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LogicalGame;
using System.Threading;

namespace GraphicalInterface
{
    public partial class Taverne : UserControl
    {
        Team t;
        private MainForm _contextForm;
        internal List<Character> randomCharacterList = new List<Character>();

        public Taverne(Team team, MainForm contextForm)
        {
            t = team;
            _contextForm = contextForm;
            InitializeComponent();
        }

        public void ReloadTavern()
        {
            GBCharacter.Controls.Clear();
            for (int i = 0; i < randomCharacterList.Count; i++)
            {

                GroupBox bg = new GroupBox();
                Label name = new Label();
                Button get = new Button();
                EventHandler eh = new EventHandler(engageMembre);

                get.Height = 30;
                get.Width = 30;
                get.Click += eh;
                get.Name = "name" + i;

                name.Top = 50;
                name.Text = randomCharacterList[i].Name;
                name.Name = "name" + i;

                bg.Controls.Add(name);
                bg.Controls.Add(get);

                get.Left = 100;
                get.Top = get.Parent.Height / 2 - get.Width / 2;

                GBCharacter.Controls.Add(bg);

                bg.Top = (i * 100);
                bg.Width = bg.Parent.Width;
            }
        }

        public void Taverne_Load(object sender, EventArgs e)
        {
            
            Random ran = new Random();
            RandomCharacter rc = new RandomCharacter();
            

            int newCharacterNumber = ran.Next(2, 5);

            for (int i = 0 ; i < newCharacterNumber ; i++)
            {
                Thread.Sleep(30);
                randomCharacterList.Add(rc.New(1, 10));
            }

            ReloadTavern();
        }

        private void engageMembre (object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            string name = button.Parent.Controls.Find(button.Name, false)[0].Text;
            Character member;
            bool find = false;

            for (int i = 0 ; i < randomCharacterList.Count ; i++)
            {
                member = randomCharacterList[i];
                if (member.Name == name && find == false)
                {
                    
                    Console.WriteLine(button.Name);
                    Console.WriteLine(member.Name);
                    Console.WriteLine(name);
                    find = true;
                    if (t.Members.Count < 4)
                    {
                        randomCharacterList.Remove(member);
                        t.AddMembers(member);
                    }
                    else
                    {
                        LError.Visible = true;
                    }
                }
            }

            ReloadTavern();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            _contextForm.ExitMenu(this);
        }
    }
}
