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
        private Controller _ctrler;
        MapWorld _world;
        internal List<Character> _randomCharacterList = new List<Character>();

        public Taverne(Team team, Controller ctrler, MapWorld w)
        {
            t = team;
            _world = w;
            _ctrler = ctrler;
            InitializeComponent();
            PTavern.Location = new System.Drawing.Point(Width / 2 - PTavern.Width / 2, PTavern.Top);
        }

        public void ReloadTavern()
        {
            label2.Text = t.Invent.GetGold + " pièces d'or";
            label2.Location = new System.Drawing.Point(Width / 2 - label2.Width / 2, label2.Top);
            PTavern.Controls.Clear();


            for (int i = 0; i < _randomCharacterList.Count; i++)
            {
                Panel bg = new Panel();
                Label name = new Label();
                Label level = new Label();
                Label prix = new Label();
                Button BRecrut = new Button();
                Button BInformation = new Button();
                EventHandler eh = new EventHandler(engageMembre);
                
                PTavern.Controls.Add(bg);

                bg.Height = 50;
                bg.Top = i * (bg.Height + 2) + 20;
                bg.Width = bg.Parent.Width;

                bg.Controls.Add(name);
                bg.Controls.Add(BRecrut);
                bg.Controls.Add(BInformation);
                bg.Controls.Add(level);
                bg.Controls.Add(prix);

                BRecrut.Text = "recruter";
                BRecrut.Click += eh;
                BRecrut.Name = "name" + i;
                BRecrut.Font = new System.Drawing.Font(_ctrler.Font.Families[0], 25);
                BRecrut.FlatAppearance.BorderSize = 0;
                BRecrut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                BRecrut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                BRecrut.FlatStyle = FlatStyle.Flat;
                BRecrut.AutoSize = true;
                BRecrut.BackColor = System.Drawing.Color.Transparent;
                BRecrut.Cursor = Cursors.Hand;
                if (t.Members.Count == 4) BRecrut.Enabled = false;
                if (t.Invent.GetGold < _randomCharacterList[i].Level * 50) BRecrut.Enabled = false;

                name.Top = bg.Height / 2 - name.Height / 2; ;
                name.Text = _randomCharacterList[i].Name;
                name.Name = "name" + i;
                name.Font = new System.Drawing.Font(_ctrler.Font.Families[1], 15);
                
                level.Text = "niv. " + _randomCharacterList[i].Level.ToString();
                level.Top = bg.Height / 2 - level.Height / 2;
                level.Left = name.Right + 10;
                level.Font = new System.Drawing.Font(_ctrler.Font.Families[1], 18);


                prix.Text = _randomCharacterList[i].Level * 50 + " pièces d'or";
                prix.Top = bg.Height / 2 - prix.Height / 2;
                prix.Left = level.Right + 4;
                prix.Font = new System.Drawing.Font(_ctrler.Font.Families[1], 15);

                BInformation.Click += BInformation_Click;
                BInformation.Tag = _randomCharacterList[i];
                BInformation.Text = "info";
                BInformation.Left = prix.Right + 5;
                BInformation.Font = new System.Drawing.Font(_ctrler.Font.Families[0], 25);
                BInformation.FlatAppearance.BorderSize = 0;
                BInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                BInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                BInformation.FlatStyle = FlatStyle.Flat;
                BInformation.AutoSize = true;
                BInformation.BackColor = System.Drawing.Color.Transparent;
                BInformation.Cursor = Cursors.Hand;

                BRecrut.Left = BInformation.Right + 5;
            }

        }

        internal void BInformation_Click (object sender, EventArgs e)
        {
            _ctrler.ToCharacterInfoTaverne((Character)((Button)sender).Tag);
        }

        public void Taverne_Load(object sender, EventArgs e)
        {
            if (_world.TavernCharacters == null || _world.TavernCharacters.Count == 0)
            {
                 _world.TavernCharactersChange();
            }
            _randomCharacterList = _world.TavernCharacters;

            ReloadTavern();
        }

        private void engageMembre (object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            string name = button.Parent.Controls.Find(button.Name, false)[0].Text;
            Character member;
            bool find = false;

            for (int i = 0 ; i < _randomCharacterList.Count ; i++)
            {
                member = _randomCharacterList[i];
                if (member.Name == name && find == false)
                {
                    if (t.Invent.GetGold >= member.Level * 50)
                    {
                        t.Invent.RemoveGold(member.Level * 50);

                        find = true;
                        if (t.Members.Count < 4)
                        {
                            _randomCharacterList.Remove(member);
                            t.AddMembers(member);
                        }
                        else
                        {
                            LError.Visible = false;
                            LError.Text = "Votre équipe est pleine, vous ne pouvez plus engager de membre";
                            LError.Left = LError.Parent.Width / 2 - LError.Width / 2;
                        }
                    }
                    else
                    {
                        LError.Visible = false;
                        LError.Text = "Vous n'avez pas suffisamment de fonds";
                        LError.Left = LError.Parent.Width / 2 - LError.Width / 2;
                    }
                }
            }

            ReloadTavern();
        }

        private void retour_Click(object sender, EventArgs e)
        {
            _ctrler.ExitMenu(this);
        }

    }
}
