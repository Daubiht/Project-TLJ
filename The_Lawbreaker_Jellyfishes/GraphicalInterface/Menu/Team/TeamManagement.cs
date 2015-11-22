using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GraphicalInterface;
using LogicalGame;
using GraphicalInterface.Services;

namespace Services
{
    public partial class TeamManagement : UserControl
    {
        Team _t;
        private MainForm _contextForm;
        EventHandlerList hl = new EventHandlerList();

        public TeamManagement(Team team, MainForm contextForm)
        {
            _t = team;
            _contextForm = contextForm;
            InitializeComponent();
            ReloadTeamManagement();
        }

        

        internal void ReloadTeamManagement()
        {
            PTeam.Controls.Clear();

            int i = 0;

            foreach (Character chara in _t.Members)
            {
                CharacterBar character = new CharacterBar(chara, _contextForm, this);

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
