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
        Random _rand;

        public MapInstance(MapIsland context, string name)
        {
            _name = name;
            _context = context;
            if(_context != null)
            {
                _rand = _context.ActualWorld.Random;
            }
            else
            {
                _rand = new Random();
            }
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

        /// <summary>
        /// Choose randomly the event
        /// 1 : Merchant, 2 : Olderman, 3 : Fight
        /// </summary>
        /// <returns>1 : Merchant, 2 : Olderman, 3 : Fight</returns>
        public int EventRandom()
        {
            int percent = _rand.Next(0, 101);
            int merch;
            int older;

            if (_context == null)
            {
                merch = 15;
                older = 30;
            }
            else
            {
                merch = 10;
                older = 20;

            }

            if (percent <= older)
            {
                if (percent <= merch)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 3;
            }
        }

        public List<MapZone> listZones
        {
            get { return _listZones; }
            set { _listZones = value; }
        }

        public bool ChangeActualZone(MapZone Z)
        {
            MapZone actualZone = ((MapZone)_context.ActualWorld.ActualPosition);
            for (int i = 0; i < actualZone.ListLink.Count; i++)
            {
                if (actualZone.ListLink[i] == Z)
                {
                    _context.ActualWorld.ActualPosition = Z;
                    return true;
                }
            }
            return false;
        }

        public MapIsland MapIsland
        {
            get { return _context; }
        }
    }
}
