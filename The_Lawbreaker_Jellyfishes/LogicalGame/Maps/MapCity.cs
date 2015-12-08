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

        public MapCity(MapIsland context, string name)
        {
            _name = name;
            _context = context;
        }

        public List<object> Services
        {
            get { return _services; }
            set { _services = value; }
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

        public MapIsland ActualIsland
        {
            get { return _context; }
        }
    }
}
