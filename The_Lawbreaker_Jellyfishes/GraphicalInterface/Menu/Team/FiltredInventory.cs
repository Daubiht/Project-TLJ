﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GraphicalInterface;
using LogicalGame;

namespace Services
{
    public partial class FiltredInventory : UserControl
    {
        Team t;
        Character c;
        MainForm _contextForm;
        string filtre;
        string place;

        public FiltredInventory(Team team, Character chara, string type, MainForm contextForm)
        {
            t = team;
            c = chara;
            filtre = type;
            _contextForm = contextForm;
            InitializeComponent();
        }

        private void BRetour_Click(object sender, EventArgs e)
        {
            CharacterManagement uc = new CharacterManagement(c, t, _contextForm);
            _contextForm.ChangeUC(uc, false, true);
        }

        private void Equip_Click (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Item item = (Item)((Object[])button.Tag)[0];
            Object[] tag;

            if (filtre == "consommable")
            {
                if (!c.UseConsumable(item))
                {
                    LError.Text = "Impossible d'utiliser cet objet";
                    LError.Visible = true;
                }
                else
                {
                    t.Invent.RemoveItem(item);
                }
            }
            else
            {
                tag = (Object[])button.Tag;
                if (button.Tag != null) place = (string)tag[1];

                if (!c.WearItem(item, filtre))
                {
                    LError.Text = "Impossible d'équiper cet objet";
                    LError.Visible = true;
                }

                LNewName.Text = "";
                BEquip.Visible = false;
            }
            Reload();
        }

        private void Desequip_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Item item = (Item)button.Tag;

            LNewName.Text = "";
            BEquip.Visible = false;

            c.UnwearItem(filtre);
            Reload();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Item item = (Item)button.Tag;
            Object[] tag = new Object[2];

            tag[0] = item;
            LNewName.Text = item.GetName;
            LNewName.Left = LNewName.Parent.Width / 2 - LNewName.Width / 2;
            BEquip.Visible = true;
            BEquip.Tag = tag;
        }

        private void Reload ()
        {
            inventory.Controls.Clear();

            ToolTip toolTip = new ToolTip();

            toolTip.InitialDelay = 250;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            inventory.Controls.Clear();
            if (filtre == "consommable")
            {
                PInfoOldItem.Visible = false;
                PInfoItem.Width = Parent.Width - 30;
                PInfoItem.Left = 5;
                BEquip.Text = "Utiliser";
            }

            // Recup of current stuff
            if (!c.Stuffs.ContainsKey(filtre) || c.Stuffs[filtre] == null)
            {
                LOldName.Text = "Aucun";
                LOldName.Top = LOldName.Parent.Height / 2 - LOldName.Height / 2;
                LOldName.Left = LOldName.Parent.Width / 2 - LOldName.Width / 2;
                BDesequip.Visible = false;
            }
            else
            {
                BDesequip.Tag = c.Stuffs[filtre];

                LOldName.Text = c.Stuffs[filtre].GetName;
                LOldName.Left = LOldName.Parent.Width / 2 - LOldName.Width / 2;
                LOldName.Top = 10;

                BDesequip.Visible = true;
            }

            int i = 0;
            int j = 0;
            string ffiltre = filtre;

            if (ffiltre == "gauche" || ffiltre == "droite")
            {
                ffiltre = "arme";
            }

            foreach (Item item in t.Invent.Inventory.Keys)
            {
                if (item.Type == ffiltre)
                {
                    Button b = new Button();

                    string infoItem = item.GetName + " " + "(" + item.Type + ")" + Environment.NewLine + item.GetDescription + Environment.NewLine + "Valeur : " + item.GetValue + Environment.NewLine + "Poids : " + item.GetWeight;

                    if (item.GetRequired.Count != 0)
                    {
                        infoItem += Environment.NewLine + "Requis :";
                        foreach (string requi in item.GetRequired.Keys)
                        {
                            infoItem += Environment.NewLine + item.GetRequired[requi] + " " + requi;
                        }
                    }

                    if (item.GetStats.Count != 0)
                    {
                        infoItem += Environment.NewLine + "Bonus :";
                        foreach (string bonus in item.GetStats.Keys)
                        {
                            infoItem += Environment.NewLine + item.GetStats[bonus] + " " + bonus;
                        }
                    }

                    toolTip.SetToolTip(b, infoItem);
                    b.Tag = item;
                    inventory.Controls.Add(b);

                    b.Width = 75;
                    b.Height = 50;

                    if (i > 4)
                    {
                        i = 0;
                        j++;
                    }

                    b.Left = i * 75;
                    b.Top = j * 50;
                    b.Click += new EventHandler(Info_Click);

                    b.Text = item.GetName + " - x" + t.Invent.Inventory[item];
                    i++;
                }
            }
        }

        private void IGFiltredInventory_Load(object sender, EventArgs e)
        {
            Reload();
        }

        
    }
}
