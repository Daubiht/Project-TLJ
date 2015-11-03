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
        Merchant _merchant;

        public MapCity(MapIsland context, string name, List<Services> listServices)
        {
            _merchant = new Merchant(null, this);
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

        public Merchant Merchant
        {
            get { return _merchant; }
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
