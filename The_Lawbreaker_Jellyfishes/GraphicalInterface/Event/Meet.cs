using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Meet : UserControl
    {
        MainForm _context;
        MapWorld _world;
        MapZone _mapZone;
        int _result;
        string _answerRiddle;

        public Meet(int result, MainForm Context, MapWorld World, MapZone zone)
        {
            InitializeComponent();
            _context = Context;
            _world = World;
            _result = result;
            _mapZone = zone;

            if (result == 1)
            {
                //merchant
                label5.Text = "Ah ! Mais que vois-je ? Je suis un marchand ambulant, venez voir mes marchandises !";
                label1.Text = "Non, merci.";
                label2.Text = "Oui, bien sûr !";
                label3.Text = "Et si je me servais gratuitement ?";
                pictureBox1.BackgroundImage = Image.FromFile(@"../../../Ressources/marchand.jpg");
            }
            else if (result == 2)
            {
                //vieux
                string[] elder = zone.EventElder();

                label5.Text = "Seriez-vous intéressé par une enigme ? La voilà : " + Environment.NewLine + elder[0];
                label1.Text = "Non, merci.";

                Label[] listlabel = { label2, label3, label4 };
                int ran = _context.world.Random.Next(0, 3);

                for (int i = 0; i < 3; i++)
                {
                    if (i == ran)
                    {
                        listlabel[i].Text = elder[1];
                        _answerRiddle = elder[1];
                    }
                    else
                    {
                        if (elder[2] != null)
                        {
                            listlabel[i].Text = elder[2];
                            elder[2] = null;
                        }
                        else
                        {
                            listlabel[i].Text = elder[3];
                        }
                    }
                }

                pictureBox1.BackgroundImage = Image.FromFile(@"../../../Ressources/elder.png");
            }
            else if (result == 3)
            {
                //rien
                label5.Text = "La zone semble déserte.";
                label1.Text = "Quitter";
                pictureBox1.BackgroundImage = Image.FromFile(@"../../../Ressources/desert.png");
            }
            else if (result == 5)
            {
                //bandit
                label5.Text = "Halte là ! La bourse ou la vie ?!";
                label1.Text = "Fuir";
                label2.Text = "Oui, tenez " + _world.Team.Invent.GetGold * 25 / 100 + " pièces d'or.";
                label3.Text = "Jamais !";
                pictureBox1.BackgroundImage = Image.FromFile(@"../../../Ressources/bandit.jpg");
            }
            label5.Location = new Point(label5.Parent.Width / 2 - label5.Width / 2, label5.Parent.Height / 2 - label5.Height / 2);
        }

        public void ElderAnswer(object sender, EventArgs e)
        {
            if (((Label)sender).Text == _answerRiddle)
            {
                int plusGold;
                if (_world.Team.Invent.GetGold > 100)
                {
                    plusGold = _world.Team.Invent.GetGold * 10 / 100;
                }
                else
                {
                    plusGold = 10;
                }

                _world.Team.Invent.AddGold(plusGold);
                foreach (Character c in _world.Team.Members)
                {
                    c.EarnXp(c.Level * 10);
                }

                label5.Text = "Pas mal petit. Tiens, quelques pièces pour ta route." + Environment.NewLine + "Expérience gagnée, " + plusGold + " pièces d'or gagnées.";
            }
            else
            {
                label5.Text = "Elle était facile pourtant... Dommage.";
            }

            label1.Text = "Quitter";
            label5.Location = new Point(label5.Parent.Width / 2 - label5.Width / 2, label5.Parent.Height / 2 - label5.Height / 2);

            label2.Click -= new EventHandler(label2_Click);
            label2.Text = "";
            label3.Click -= new EventHandler(label3_Click);
            label3.Text = "";
            label4.Click -= new EventHandler(label4_Click);
            label4.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(_result == 2)
            {
                ElderAnswer(sender, e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Refus, partir
            if(_result == 5)
            {
                if(_world.Random.Next(0, 2) == 1)
                {
                    label3_Click(sender, e);
                }
                else
                {
                    _context.ExitMenu(this);
                }
            }
            else
            {
                _context.ExitMenu(this);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Accepter
            if(_result == 1)
            {
                Merchant uc = new Merchant(_context, _mapZone.EventMerchant(),_world.Team.Invent);
                _context.ToMenu(uc, true);
            }
            else if(_result == 5)
            {
                _world.Team.Invent.RemoveGold(_world.Team.Invent.GetGold * 25 / 100);
                _context.ExitMenu(this);
            }
            else if (_result == 2)
            {
                ElderAnswer(sender, e);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Attaquer
            if (_result == 2)
            {
                ElderAnswer(sender, e);
            } else if(_result == 5)
            {
                FightUserControl uc = new FightUserControl(_mapZone.EventFightRandom(2, null), _world.Team, _context);
                _context.ChangeUC(uc, false, true);
            } else if(_result == 1)
            {
                FightUserControl uc = new FightUserControl(_mapZone.EventFightRandom(2, null), _world.Team, _context);
                _context.ChangeUC(uc, false, true);
            }
        }

        private void Meet_Load(object sender, EventArgs e)
        {
            if(_result == 4)
            {
                FightUserControl uc = new FightUserControl(_mapZone.EventFightRandom(0, null), _world.Team, _context);
                _context.ChangeUC(uc, false, true);
            }
        }
    }
}
