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
        List<MapInstance> _listInstance;
        MapCity _city;
        object _actualPlace;

        public MapIsland(MapWorld context, string name)
        {
            _name = name;
            _context = context;
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
            set { _actualPlace = value; }
        }
    }
}
