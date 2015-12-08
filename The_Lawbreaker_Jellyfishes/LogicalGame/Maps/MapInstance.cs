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
        /// 1 : Merchant, 2 : Elderman, 3 : Nothing, 4 : Fight, 5 : Thiefs
        /// </summary>
        /// <returns></returns>
        public int EventRandom(bool visited)
        {
            int percent = _rand.Next(0, 101);
            int merch;
            int elder;
            int empty;
            int thief;
            int fight;

            if (visited)
            {
                merch = 5;
                elder = 5;
                empty = 80;
                thief = 5;
                fight = 5;
            }
            else if (_context == null)
            {
                merch = 15;
                elder = 15;
                empty = 15;
                thief = 15;
                fight = 40;
            }
            else
            {
                merch = 6;
                elder = 6;
                empty = 5;
                thief = 8;
                fight = 75;
            }

            if (percent < merch)
            {
                return 1;
            }
            else if(percent > merch && percent < elder+merch)
            {
                return 2;
            }
            else if(percent > elder+merch && percent < empty+elder+merch)
            {
                return 3;
            }
            else if(percent > empty+elder+merch && percent < fight+empty+elder+merch)
            {
                return 4;
            }
            else
            {
                return 5;
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
