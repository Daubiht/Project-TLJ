
using System;

namespace LogicalGame
{
    [Serializable]
    public class Militia
    {
        MapCity _context;
        int _x;
        int _y;

        public Militia(MapCity context)
        {
            _context = context;
        }

        public int PointX
        {
            get { return _x; }
            set { _x = value; }
        }

        public int PointY
        {
            get { return _y; }
            set { _y = value; }
        }

        public void UseMilitia(Team T, MapIsland I)
        {
            T.Invent.RemoveGold(10);
            _context.ActualIsland.ActualWorld.ChangeActualIsland(I, true);
        }
    }
}
