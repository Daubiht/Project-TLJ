using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;
using System.Threading;

namespace GraphicalInterface
{
    public partial class Meet : UserControl
    {
        Controller _ctrler;
        MapWorld _world;
        MapZone _mapZone;
        int _result;
        string _answerRiddle;

        public Meet(int result, Controller ctrler, MapWorld World, MapZone zone)
        {
            _ctrler = ctrler;
            _world = World;
            _result = result;
            _mapZone = zone;
            InitializeComponent();

            if (result == 1)
            {
                //merchant
                if(_mapZone.Context.Between)
                {
                    label5.Text = "Vous apercevez au loin une embarcation, vous décidez de vous en approcher et découvrez qu'il s'agit d'une embarcation marchande.";
                }
                else
                {
                    label5.Text = "Une silhouette se forme à l'horizon. A mesure que vous vous en approchez, la silhouette fini par devenir une carriole de marchand ambulant.";
                }

                label1.Text = "Passer votre chemin";
                label2.Text = "Engager la conversation avec le marchand";
                label3.Text = "Attaquer le marchand";
                pictureBox1.BackgroundImage = Image.FromFile(@"../../../Ressources/img-thing.png");
            }
            else if (result == 2)
            {
                //vieux
                string[] elder = zone.EventElder();

                if (_mapZone.Context.Between)
                {
                    label5.Text = "Un canoé s'approche de vous et vous y décrouvrez un vieille homme à son bord. Il décide de vous proposer une énigme : " + Environment.NewLine + elder[0];
                }
                else
                {
                    label5.Text = "Un vieille homme s'approche de vous, vous fixe étrangement du regarde puis vous propose une énigme : " + Environment.NewLine + elder[0];
                }
                label1.Text = "Non, merci.";

                Label[] listlabel = { label2, label3, label4 };
                int ran = _world.Random.Next(0, 3);

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

                pictureBox1.BackgroundImage = Image.FromFile(@"../../../Ressources/img-thing.png");
            }
            else if (result == 3)
            {
                //rien
                label5.Text = "La zone semble déserte.";
                label1.Text = "Quitter";
                pictureBox1.BackgroundImage = Image.FromFile(@"../../../Ressources/img-thing.png");
            }
            else if (result == 5)
            {
                //bandit
                if (_mapZone.Context.Between)
                {
                    label5.Text = "Un navire s'approche dangereusement de vous. Vous apercevez un pavillon pirate puis des silouhettes s'apprêter à vous aborder.";
                }
                else
                {
                    label5.Text = "Une silhouette se forme à l'horizon. A mesure que vous vous en approchez, la silhouette fini par devenir une carriole de marchand ambulant.";
                }
                label1.Text = "Tenter de fuir";
                label2.Text = "Vous soumettre et donner " + _world.Team.Invent.GetGold * 25 / 100 + " pièces d'or";
                label3.Text = "Combattre les assailants";
                pictureBox1.BackgroundImage = Image.FromFile(@"../../../Ressources/img-thing.png");
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

                label5.Text = "Vous répondez avec succés à l'énigme, le vieille homme vous récompense : " + Environment.NewLine + "Expérience gagnée, " + plusGold + " pièces d'or gagnées.";
            }
            else
            {
                label5.Text = "Vous échouez à l'énigme posée, le vieille homme reprend sa route.";
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
                    _ctrler.ExitMenu(this);
                }
            }
            else
            {
                _ctrler.ExitMenu(this);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Accepter
            if(_result == 1)
            {
                _ctrler.ToService(_mapZone.EventMerchant());
            }
            else if(_result == 5)
            {
                _world.Team.Invent.RemoveGold(_world.Team.Invent.GetGold * 25 / 100);
                _ctrler.ExitMenu(this);
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
            }
            else if(_result == 5)
            {
                ListMonsters Mobs = new ListMonsters();
                List<Monster> ListM =  Mobs.GetListMonsters.FindAll(
                    delegate (Monster m)
                    {
                        return m.Name != "Marchand" && m.Race == "Humain";
                    }
                );

                _ctrler.ToFight(ListM);
            }
            else if(_result == 1)
            {
                ListMonsters Mobs = new ListMonsters();
                List<Monster> ListM = new List<Monster>();

                List<Monster> M = Mobs.GetListMonsters.FindAll(
                    delegate (Monster m)
                    {
                        return m.Name == "Marchand";
                    }
                );
                M[0].FrontPosition = false;
                ListM.Add(M[0]);

                M = Mobs.GetListMonsters.FindAll(
                    delegate (Monster m)
                    {
                        return m.Race == "Merchant" && m.Name != "Marchand";
                    }
                );

                Random r = new Random();

                for(int i = 0; i < 3; i++)
                {
                    ListM.Add(M[r.Next(0, M.Count)]);
                    Thread.Sleep(50);
                }

                _ctrler.ToFight(ListM);
            }
        }

        private void Meet_Load(object sender, EventArgs e)
        {
            if(_result == 4)
            {
                _ctrler.ToFight(_mapZone.EventFightRandom(0, null));
            }
        }
    }
}
