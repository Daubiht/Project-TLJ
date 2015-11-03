using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    [Serializable]
    public class MapCity
    {
        readonly MapIsland _context;
        readonly string _name;

        public MapCity(MapIsland context, string name)
        {
            _name = name;
            _context = context;
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
