using System;
using System.Collections.Generic;

namespace LogicalGame
{
    [Serializable]
    public class MapZone
    {
        List<MapZone> _listLink = new List<MapZone>();
        MapInstance _context;

        public MapZone(MapInstance context, bool WithInstance)
        {
            if(WithInstance == true)
            {
                _context = context;
            }
        }

        public MapInstance Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public List<MapZone> ListLink
        {
            get { return _listLink; }
            set { _listLink = value; }
        }

    }
}
