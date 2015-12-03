﻿using System;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class CharacterBar : UserControl
    {
        Character _c;
        MainForm _contextForm;
        TeamManagement _context;

        public CharacterBar(Character c, MainForm contextForm, TeamManagement context)
        {
            _c = c;
            _contextForm = contextForm;
            _context = context;

            InitializeComponent();

            LName.Text = c.Name;
            LLevel.Text = "Niveau " + c.Level;
            PBHealth.Maximum = c.MaxHealthPoint;
            PBHealth.Value = c.HealthPoint;
            PBStamina.Maximum = c.MaxStaminaPoint;
            PBStamina.Value = c.StaminaPoint;
            BInfos.Tag = c;
            BPosition.Tag = c;

            if (c.FrontPosition) BPosition.Text = "CaC";
            else BPosition.Text = "PO";
        }

        internal void Info_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Character c = (Character)button.Tag;

            CharacterManagement cm = new CharacterManagement(_c, _c.InTeam, _contextForm);
            _contextForm.ChangeUC(cm, false, true);
        }

        internal void Position_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Character c = (Character)button.Tag;

            c.FrontPosition = !c.FrontPosition;

            _context.ReloadTeamManagement();
        }

        private void BPosition_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Character c = (Character)button.Tag;
            Team team = c.InTeam;
            bool allInBack;

            c.FrontPosition = !c.FrontPosition;

            if (c.FrontPosition) button.Text = "CaC";
            else button.Text = "PO";

            if (!c.FrontPosition)
            {
                allInBack = true;
                foreach (Character member in team.Members)
                {
                    if (member.FrontPosition) allInBack = false;
                }

                if (allInBack)
                {
                    foreach (CharacterBar bar in Parent.Controls)
                    {
                        Character currentChara = (Character)bar.Tag;
                        currentChara.FrontPosition = true;
                        bar.BPosition.Text = "CaC";
                    }
                    ((TeamManagement)(Parent.Parent)).Error.Text = "Attention ! Il faut au moins un membre de l'équipe au corp à corp.";
                    ((TeamManagement)(Parent.Parent)).Error.Visible = true;
                }
                else
                {
                    ((TeamManagement)(Parent.Parent)).Error.Visible = false;
                }
            }


        }
    }
}
