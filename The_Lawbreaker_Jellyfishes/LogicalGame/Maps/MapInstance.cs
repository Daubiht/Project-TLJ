using System;
using System.Collections.Generic;

namespace LogicalGame
{
    [Serializable]
    public class MapInstance
    {
        readonly MapIsland _context;
        readonly string _name;
        List<MapZone> _listZones;
        int _x;
        int _y;

        public MapInstance(MapIsland context, string name)
        {
            _name = name;
            _context = context;
        }

        public int PointX
        {
            get { return _x; }
            set { _x = value; }
        }
        public int PointY
        {
            get { return _y; }
            set { _y = value; }
        }

        public string InstanceName
        {
            get { return _name; }
        }

        public List<MapZone> listZones
        {
            get { return _listZones; }
            set { _listZones = value; }
        }

        public MapZone ChangeActualZone(MapZone Z)
        {
            MapZone actualZone = ((MapZone)_context.ActualWorld.ActualPosition);
            for (int i = 0; i < actualZone.ListLink.Count; i++)
            {
                if (actualZone.ListLink[i] == Z)
                {
                    actualZone = Z;
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
