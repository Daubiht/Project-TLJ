using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class MapIsland
    {
        readonly MapWorld _context;
        readonly string _name;

        public MapIsland(MapWorld context, string name)
        {
            _name = name;
            _context = context;
        }
    }
}
