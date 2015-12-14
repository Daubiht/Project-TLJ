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
    public partial class EndFightVictory : UserControl
    {
        List<Monster> _monsters;
        MainForm _context;
        Random ran;
        Invent _invent;
        Dictionary<Item, int> _dropedItem;
        int _gold;
        int _xp;
        bool _isRunAway;

        public EndFightVictory(MainForm Context, List<Monster> monsters, bool isRunAway)
        {
            _monsters = monsters;
            InitializeComponent();
            _context = Context;
            _invent = _context.world.Team.Invent;
            _dropedItem = new Dictionary<Item, int>();
            ran = _context.world.Random;
            _gold = 0;
            _xp = 0;
            _isRunAway = isRunAway;

            if (!_isRunAway)
            {
                foreach (Monster monster in _monsters)
                {
                    foreach (Item item in monster.Drop.Keys)
                    {
                        int random = ran.Next(1, 101);

                        if (random <= monster.Drop[item])
                        {
                            if (!_dropedItem.ContainsKey(item)) _dropedItem.Add(item, 1);
                            else _dropedItem[item]++;
                            _invent.AddItem(item, 1);
                        }
                    }

                    _gold += monster.Gold;
                    _xp += monster.XP;
                    DisplayDrop(_dropedItem);
                }


                int dwarf = 0;
                foreach (Character member in _invent.Context.Members)
                {
                    if (member.isAlive) member.EarnXp(_xp);
                    if (member.Race == "NAIN") dwarf++;
                }
                _invent.AddGold(_gold);

                LGolds.Text = _gold + (int)Math.Round(_gold * (0.05 * dwarf)) + " Pièce d'Or";
                LXP.Text = _xp + " Points d'experience";
            }
            else
            {
                LGolds.Visible = false;
                LXP.Visible = false;
                labelVictory.Text = "Fuite réussie";
                LInfo.Visible = false;
            }
        }

        private void DisplayDrop (Dictionary<Item, int> dropedItem)
        {
            int i = 0;
            foreach (Item item in dropedItem.Keys)
            {
                Label name = new Label();
                name.Text = item.GetName + " x " + dropedItem[item];
                name.Top = i * (name.Height + 5);
                PDrop.Controls.Add(name);
                i++;
            }
        }
        private void LGolds_Click(object sender, EventArgs e)
        {

        }

        private void EndFightVictory_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _context.ExitMenu(this);
        }
    }
}
