using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class MapInstance
    {
        readonly MapIsland _context;
        readonly string _name;
        readonly Dictionary<MapZone, List<MapZone>> _listZones;
        MapZone _actualZone;

        public MapInstance(MapIsland context, string name, Dictionary<MapZone, List<MapZone>> listzone)
        {
            _name = name;
            _context = context;
            _listZones = listzone;
        }

        public string InstanceName
        {
            get { return _name; }
        }

        public Dictionary<MapZone, List<MapZone>> listZones
        {
            get { return _listZones; }
        }

        public MapZone ActualZone
        {
            get { return _actualZone; }
            set
            {
                for (int i = 0; i < _listZones[_actualZone].Count; i++)
                {
                    if ((_listZones[_actualZone][i] == value) && (_context.ActualPlace == this))
                    {
                        _actualZone = value;
                        //Provok an event when arrive
                    }
                }
            }
        }
    }
}
