using System;
using System.ComponentModel;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class TeamManagement : UserControl
    {
        Team _t;
        private Controller _ctrler;

        public TeamManagement(Team team, Controller ctrler)
        {
            _t = team;
            _ctrler = ctrler;
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
                CharacterBar character = new CharacterBar(chara, _ctrler, this);
                character.Tag = chara;

                character.Top = i * (character.Height + 5);

                PTeam.Controls.Add(character);

                i++;
            }
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            _ctrler.ExitMenu(this);
        }
    }
}
