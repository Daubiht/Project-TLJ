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

        public EndFightVictory(MainForm Context, List<Monster> _monsters)
        {
            _monsters = _monsters;
            InitializeComponent();
            _context = Context;
            _invent = _context.world.Team.Invent;
            _dropedItem = new Dictionary<Item, int>();
            ran = _context.world.Random;
            int gold = 0;

            foreach (Monster monster in _monsters)
            {
                foreach(Item item in monster.Drop.Keys)
                {
                    int random = ran.Next(1, 101);

                    if (random <= monster.Drop[item])
                    {
                        if (!_dropedItem.ContainsKey(item)) _dropedItem.Add(item, 1);
                        else _dropedItem[item]++;
                        _invent.AddItem(item, 1);
                    }
                }
                
                gold += monster.Gold;
                DisplayDrop(_dropedItem);
            }

            _invent.AddGold(gold);
            LGolds.Text = gold + " Pièce d'Or";
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
    }
}
