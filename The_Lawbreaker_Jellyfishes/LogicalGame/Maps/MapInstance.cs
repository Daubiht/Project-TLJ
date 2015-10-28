using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    public class MapInstance
    {
        readonly MapIsland _context;
        readonly string _name;
        readonly Dictionary<string, MapZone> _listZones;
        MapZone _actualZone;

        public MapInstance(MapIsland context, string name, Dictionary<string, MapZone> listzone)
        {
            _name = name;
            _context = context;
            _listZones = listzone;
        }

        public string InstanceName
        {
            get { return _name; }
        }

        public Dictionary<string, MapZone> listZones
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
            throw new NotImplementedException();
        }
    }
}
