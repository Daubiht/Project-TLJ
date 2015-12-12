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
    public partial class EndFightDefeat : UserControl
    {
        MainForm _context;
        bool _allDead;
        public EndFightDefeat(MainForm Context, bool AllDead)
        {
            InitializeComponent();
            _context = Context;
            _allDead = AllDead;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(_allDead)
            {
                if(_context.world.ActualPosition is MapZone)
                {
                    _context.world.ActualPosition = ((MapZone)_context.world.ActualPosition).Context.MapIsland.IslandCity;
                    City uc = new City(_context, _context.world, (MapCity)_context.world.ActualPosition);
                    _context.ChangeUC(uc, true);
                }
                else if(_context.world.ActualPosition is MapIsland)
                {
                    _context.world.ActualPosition = ((MapIsland)_context.world.ActualPosition).IslandCity;
                    City uc = new City(_context, _context.world, (MapCity)_context.world.ActualPosition);
                    _context.ChangeUC(uc, true);
                }
            }
            else
            {
                _context.ExitMenu(this);
            }
        }
    }
}
