using System;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class FiltredInventory : UserControl
    {
        Team _team;
        Character _c;
        object _contextForm;
        string _filtre;
        string _place;
        bool _inFight;


        public FiltredInventory(Team team, Character chara, string type, object contextForm, bool InFight)
        {
            this._team = team;
            _inFight = InFight;
            _c = chara;
            _filtre = type;
            _contextForm = contextForm;
            InitializeComponent();
        }

        private void BRetour_Click(object sender, EventArgs e)
        {
            if (_inFight)
            {
                ((FiltredInventoryForm)_contextForm).Close();
            }
            else
            {
                CharacterManagement uc = new CharacterManagement(_c, _team, (MainForm)_contextForm);
                ((MainForm)_contextForm).ChangeUC(uc, false, true);
            }
        }

        private void Equip_Click (object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Item item = (Item)((Object[])button.Tag)[0];
            Object[] tag;

            if (item.Type == "resurrection")
            {
                DeadMenList list = new DeadMenList(_team, _c, item);
                list.ShowDialog();
            }
            else if (_filtre == "consommable")
            {
                // If it doens't consume we display "impossible d'utiliser"
                if (!_c.UseConsumable(item))
                {
                    LError.Text = "Impossible d'utiliser cet objet";
                    LError.Visible = true;
                }
                // If it consumes the item, we delete it and display the another number
                else
                {
                    // The member is considered he played when he consumes a potion
                    if ( _inFight )
                    {
                        bool didAllmemberPlay = true;
                        _c.DidMemberPlay = true;
                        // Refresh information of all panels
                        foreach(PanelCharacter p in ((FiltredInventoryForm)Parent).PanelCharacter )
                            p.RefreshInformation();
                        // If anot all member played, the monster don't attack
                        foreach ( Character c in ((FiltredInventoryForm)Parent).Fight.GetTeam.Members )
                            if ( c.DidMemberPlay == false )
                                didAllmemberPlay = false;
                        // if all member played, the monsers attack
                        if ( didAllmemberPlay == true )
                        {
                            ((FiltredInventoryForm)Parent).Fight.MonsterAttack();
                            // Refresh information of all panels
                            foreach ( PanelCharacter p in ((FiltredInventoryForm)Parent).PanelCharacter )
                                p.RefreshInformation();
                        }
                        // Close the windown of consumable during fight
                        ((Form)Parent).Close();
                    }
                    _team.Invent.RemoveItem(item);
                    Reload();
                }
            }
            else
            {
                tag = (Object[])button.Tag;
                if (button.Tag != null) _place = (string)tag[1];

                if (!_c.WearItem(item, _filtre))
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

            _c.UnwearItem(_filtre);
            Reload();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Item item = (Item)button.Tag;
            Object[] tag = new Object[2];

            string infoItem = item.GetName + Environment.NewLine;
            tag[0] = item;
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

            LNewName.Text = infoItem;
            LNewName.Left = LNewName.Parent.Width / 2 - LNewName.Width / 2;
            BEquip.Visible = true;
            BEquip.Tag = tag;
        }

        // Load of all items 
        private void Reload ()
        {
            inventory.Controls.Clear();

            ToolTip toolTip = new ToolTip();

            toolTip.InitialDelay = 250;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;

            inventory.Controls.Clear();
            if (_filtre == "consommable")
            {
                PInfoOldItem.Visible = false;
                PInfoItem.Width = Parent.Width - 30;
                PInfoItem.Left = 5;
                BEquip.Text = "Utiliser";
            }

            // Recup of current stuff
            if (!_c.Stuffs.ContainsKey(_filtre) || _c.Stuffs[_filtre] == null)
            {
                LOldName.Text = "Aucun";
                LOldName.Top = LOldName.Parent.Height / 2 - LOldName.Height / 2;
                LOldName.Left = LOldName.Parent.Width / 2 - LOldName.Width / 2;
                BDesequip.Visible = false;
            }
            else
            {
                BDesequip.Tag = _c.Stuffs[_filtre];

                string infoItem = _c.Stuffs[_filtre].GetName + Environment.NewLine;
                if (_c.Stuffs[_filtre].GetRequired.Count != 0)
                {
                    infoItem += Environment.NewLine + "Requis :";
                    foreach (string requi in _c.Stuffs[_filtre].GetRequired.Keys)
                    {
                        infoItem += Environment.NewLine + _c.Stuffs[_filtre].GetRequired[requi] + " " + requi;
                    }
                }

                if (_c.Stuffs[_filtre].GetStats.Count != 0)
                {
                    infoItem += Environment.NewLine + "Bonus :";
                    foreach (string bonus in _c.Stuffs[_filtre].GetStats.Keys)
                    {
                        infoItem += Environment.NewLine + _c.Stuffs[_filtre].GetStats[bonus] + " " + bonus;
                    }
                }

                LOldName.Text = infoItem;
                LOldName.Left = LOldName.Parent.Width / 2 - LOldName.Width / 2;
                LOldName.Top = 10;

                BDesequip.Visible = true;
            }

            int i = 0;
            int j = 0;
            string ffiltre = _filtre;

            if (ffiltre == "gauche" || ffiltre == "droite")
            {
                ffiltre = "arme";
            }

            // Recup and display items
            foreach (Item item in _team.Invent.Inventory.Keys)
            {
                if (item.Type == ffiltre || (ffiltre == "consommable" && item.Type == "resurrection"))
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

                    b.Text = item.GetName + " - x" + _team.Invent.Inventory[item];
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
