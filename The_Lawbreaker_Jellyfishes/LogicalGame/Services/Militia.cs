using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    public class Militia
    {
        MapCity _context;

        public Militia(MapCity context)
        {
            _context = context;
        }

        public void UseMilitia(Team T, MapIsland I)
        {
            T.Invent.RemoveGold(10);
            _context.ActualIsland.ActualWorld.ChangeActualIsland(I, true);
        }
    }
}
