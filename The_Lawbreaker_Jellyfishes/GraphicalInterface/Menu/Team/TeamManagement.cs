using System;
using System.ComponentModel;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class TeamManagement : UserControl
    {
        Team _t;
        private MainForm _contextForm;

        public TeamManagement(Team team, MainForm contextForm)
        {
            _t = team;
            _contextForm = contextForm;
            InitializeComponent();
            ReloadTeamManagement();
        }
        
        internal Label Error
        {
            get { return LError; }
        }

        internal void ReloadTeamManagement()
        {
            PTeam.Controls.Clear();

            int i = 0;

            foreach (Character chara in _t.Members)
            {
                CharacterBar character = new CharacterBar(chara, _contextForm, this);
                character.Tag = chara;

                character.Top = i * (character.Height + 5);

                PTeam.Controls.Add(character);

                i++;
            }
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            _contextForm.ExitMenu(this);
        }
    }
}
