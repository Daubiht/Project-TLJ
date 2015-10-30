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
        readonly List<Services> _listServices;
        Services _actualService;

        public MapCity(MapIsland context, string name, List<Services> listServices)
        {
            _name = name;
            _context = context;
            _listServices = listServices;
        }

        public string CityName
        {
            get { return _name; }
        }

        public List<Services> listServices
        {
            get { return _listServices; }
        }

        public Services ActualService
        {
            get { return _actualService; }
            set
            {
                if (_context.ActualPlace == this)
                {
                    _actualService = value;
                }
            }
        }

        public MapIsland ActualIsland
        {
            get { return _context; }
        }
    }
}
