using System;
using System.Collections.Generic;

namespace LogicalGame
{
    [Serializable]
    public class MapCity
    {
        readonly MapIsland _context;
        readonly string _name;
        int _x;
        int _y;

        List<Merchant> _merchants;
        Mortuary _mortuary;

        public MapCity(MapIsland context, string name, List<Merchant> Merchants)
        {
            _name = name;
            _context = context;
            _merchants = Merchants;
            _mortuary = new Mortuary(this);
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

        public string CityName
        {
            get { return _name; }
        }

        public List<Merchant> Merchant
        {
            get { return _merchants; }
        }

        public MapIsland ActualIsland
        {
            get { return _context; }
        }

        public Mortuary Mortuary
        {
            get { return _mortuary; }
        }
    }
}
