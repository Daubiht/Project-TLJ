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

        public Meet(int result, MainForm Context, MapWorld World, MapZone zone)
        {
            InitializeComponent();
            _context = Context;
            _world = World;
            _result = result;
            _mapZone = zone;

            if(result == 1)
            {
                //merchant
                label5.Text = "Ah ! Mais que vois-je ? Je suis un marchand ambulant, venez voir mes marchandises !";
                label1.Text = "Non, merci.";
                label2.Text = "Oui, bien sûr !";
                label3.Text = "Et si je me servais gratuitement ?";
                pictureBox1.BackgroundImage = Image.FromFile(@"../../../Ressources/marchand.jpg");
            }
            else if(result == 2)
            {
                //vieux
                label5.Text = "Seriez-vous intéressé par une enigme ? La voilà : ";
                label1.Text = "Non, merci.";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                pictureBox1.BackgroundImage = Image.FromFile(@"../../../Ressources/elder.png");
            }
            else if(result == 3)
            {
                //rien
                label5.Text = "La zone semble déserte.";
                label1.Text = "Quitter";
                pictureBox1.BackgroundImage = Image.FromFile(@"../../../Ressources/desert.png");
            }
            else if(result == 4)
            {
                //fight
                label1.Text = "Quitter";
            }
            else if(result == 5)
            {
                //bandit
                label5.Text = "Alte là ! La bourse ou la vie ?!";
                label1.Text = "Fuir";
                label2.Text = "Oui, tenez " +_world.Team.Invent.GetGold * 25 / 100 + " pièce d'or.";
                label3.Text = "Jamais !";
                pictureBox1.BackgroundImage = Image.FromFile(@"../../../Ressources/bandit.jpg");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Refus, partir
            _context.ExitMenu(this);
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
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Attaquer
        }
    }
}
