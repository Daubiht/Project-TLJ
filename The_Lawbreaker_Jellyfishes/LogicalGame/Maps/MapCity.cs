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

        Merchant _merchant;

        public MapCity(MapIsland context, string name)
        {
            _name = name;
            _context = context;
            _merchant = new Merchant(null);
        }

        public string CityName
        {
            get { return _name; }
        }

        public Merchant Merchant
        {
            get { return _merchant; }
        }

        public MapIsland ActualIsland
        {
            get { return _context; }
        }
    }
}
