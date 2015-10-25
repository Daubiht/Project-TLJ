using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class MapCity
    {
        readonly MapIsland _context;
        readonly string _name;
        readonly List<Services> _listServices;
        Services _actualService;

        public MapCity(MapIsland context, string name, List<Services> listServices)
        {
            _name = name;
            _context = context;
            _listServices = listServices;
        }

        public Services ActualService
        {
            get { return _actualService; }
            set { _actualService = value; }
        }
    }
}
