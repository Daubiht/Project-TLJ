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
        Controller _ctrler;
        bool _allDead;
        object _actualPosition;

        public EndFightDefeat(Controller ctrler, bool AllDead, object ActualPosition)
        {
            InitializeComponent();
            _ctrler = ctrler;
            _allDead = AllDead;
            _actualPosition = ActualPosition;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(_allDead)
            {
                if(_actualPosition is MapZone)
                {
                    _ctrler.ToCity(((MapZone)_actualPosition).Context.MapIsland.IslandCity);
                }
                else if(_actualPosition is MapIsland)
                {
                    _ctrler.ToCity(((MapIsland)_actualPosition).IslandCity);
                }
            }
            else
            {
                _ctrler.ExitMenu(this);
            }
        }
    }
}
