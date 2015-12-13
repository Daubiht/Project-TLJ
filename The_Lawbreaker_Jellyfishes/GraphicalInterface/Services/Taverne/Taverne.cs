using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LogicalGame;
using System.Threading;
using Services;

namespace GraphicalInterface
{
    public partial class Taverne : UserControl
    {
        Team t;
        private MainForm _contextForm;
        internal List<Character> _randomCharacterList = new List<Character>();

        public Taverne(Team team, MainForm contextForm, List<Character> randomCharacterList)
        {
            t = team;
            _contextForm = contextForm;
            _randomCharacterList = randomCharacterList;
            InitializeComponent();
        }

        public void ReloadTavern()
        {
            PTavern.Controls.Clear();
            if (_randomCharacterList.Count == 0)
            {
                _contextForm.world.TavernCharactersChange();
            }
            _randomCharacterList = _contextForm.world.TavernCharacters;
                for (int i = 0; i < _randomCharacterList.Count; i++)
                {

                    GroupBox bg = new GroupBox();
                    Label name = new Label();
                    Label level = new Label();
                    Label prix = new Label();
                    Button BRecrut = new Button();
                    Button BInformation = new Button();
                    EventHandler eh = new EventHandler(engageMembre);

                    PTavern.Controls.Add(bg);

                    bg.Height = 70;
                    bg.Top = i * (bg.Height + 2);
                    bg.Width = bg.Parent.Width;

                    bg.Controls.Add(name);
                    bg.Controls.Add(BRecrut);
                    bg.Controls.Add(BInformation);
                    bg.Controls.Add(level);
                    bg.Controls.Add(prix);

                    BRecrut.Text = "Recruter";
                    BRecrut.Click += eh;
                    BRecrut.Name = "name" + i;
                    BRecrut.Top = 10;
                    BRecrut.Left = bg.Width - BRecrut.Width - 10; ;

                    name.Top = bg.Height / 2 - name.Height / 2; ;
                    name.Text = _randomCharacterList[i].Name;
                    name.Name = "name" + i;

                    level.Text = "Niveau " + _randomCharacterList[i].Level.ToString();
                    level.Top = bg.Height / 2 - level.Height / 2;
                    level.Left = name.Right + 10;

                    prix.Text = _randomCharacterList[i].Level * 50 + " pièces d'or";
                    prix.Top = bg.Height / 2 - prix.Height / 2;
                    prix.Left = level.Right + 10;

                    BInformation.Click += BInformation_Click;
                    BInformation.Tag = _randomCharacterList[i];
                    BInformation.Text = "Informations";
                    BInformation.Left = bg.Width - BInformation.Width - 10;
                    BInformation.Top = bg.Height - BInformation.Height - 5;
                }
            
        }

        internal void BInformation_Click (object sender, EventArgs e)
        {
            Character c = (Character)((Button)sender).Tag;

            CharacterInformations uc = new CharacterInformations(c, t, _contextForm, _randomCharacterList);
            _contextForm.ChangeUC(uc, false, true);
        }

        public void Taverne_Load(object sender, EventArgs e)
        {
            _randomCharacterList = _contextForm.world.TavernCharacters;
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
                            LError.Visible = true;
                            LError.Text = "Votre équipe est pleine, vous ne pouvez plus engager de membre";
                            LError.Left = LError.Parent.Width / 2 - LError.Width / 2;
                        }
                    }
                    else
                    {
                        LError.Visible = true;
                        LError.Text = "Vous n'avez pas suffisamment de fonds";
                        LError.Left = LError.Parent.Width / 2 - LError.Width / 2;
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
