using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    public class MapIsland
    {
        readonly MapWorld _context;
        readonly string _name;
        List<MapInstance> _listInstance;
        MapCity _city;
        object _actualPlace;
        List<MapIsland> _listLink;

        public MapIsland(MapWorld context, string name)
        {
            _name = name;
            _context = context;
        }

        public List<MapIsland> ListLink
        {
            get { return _listLink; }
            set { _listLink = value; }
        }

        public MapWorld ActualWorld
        {
            get { return _context; }
        }

        public string IslandName
        {
            get { return _name; }
        }

        public MapCity IslandCity
        {
            get { return _city; }
        }

        public List<MapInstance> IslandInstances
        {
            get { return _listInstance; }
        }

        public MapCity AddCity(MapCity city)
        {
            _city = city;
            return _city;
        }

        public List<MapInstance> AddInstances(List<MapInstance> listInstance)
        {
            _listInstance = listInstance;
            return listInstance;
        }

        public object ActualPlace
        {
            get { return _actualPlace; }
            set
            {
                if (_context.ActualIsland == _name)
                {
                    _actualPlace = value;
                }
            }

        }
    }
}
