using System;
using System.Collections.Generic;

namespace LogicalGame
{
    [Serializable]
    public class MapInstance
    {
        readonly MapIsland _context;
        readonly string _name;
        readonly List<MapZone> _listZones;
        MapZone _actualZone;

        public MapInstance(MapIsland context, string name, List<MapZone> listzone)
        {
            _name = name;
            _context = context;
            _listZones = listzone;
        }

        public string InstanceName
        {
            get { return _name; }
        }

        public List<MapZone> listZones
        {
            get { return _listZones; }
        }

        public MapZone ActualZone
        {
            get { return _actualZone; }
        }

        public MapZone ChangeActualZone(MapZone Z)
        {
            for (int i = 0; i < _actualZone.ListLink.Count; i++)
            {
                if ((_actualZone.ListLink[i] == Z) && (_context.ActualPlace == this))
                {
                    _actualZone = Z;
                    //Provok an event when arrive
                    return Z;
                }
            }
            throw new ArgumentException();
        }

        public MapIsland MapIsland
        {
            get { return _context; }
        }
    }
}
