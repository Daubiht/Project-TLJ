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

        List<object> _services;
        Mortuary _mortuary;

        public MapCity(MapIsland context, string name, List<object> Services)
        {
            _name = name;
            _context = context;
            _services = Services;
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

        public List<object> Services
        {
            get { return _services; }
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
