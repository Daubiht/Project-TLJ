using System;
using System.Collections.Generic;

namespace LogicalGame
{
    [Serializable]
    public class MapZone
    {
        List<MapZone> _listLink = new List<MapZone>();
        MapInstance _context;
        int _zoneLevel;

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

        public object Event()
        {
            Random rand = new Random();
            int result = rand.Next(0, 2);

            if (result == 0)
            {
                ListMonsters EntirelistM = new ListMonsters();
                List<Monster> listMByLevel = EntirelistM.GetListMonsters.FindAll(
                    delegate (Monster m)
                    {
                        return m.Level > (_zoneLevel - 3) && m.Level < (_zoneLevel + 3);
                    }
                );

                int nbrM = rand.Next(1, 5);
                List<Monster> listMForFight = new List<Monster>();
                for(int i = 0; i < nbrM; i ++)
                {
                    int wanted = rand.Next(0, listMByLevel.Count);
                    listMForFight.Add(listMByLevel[wanted]);
                    listMByLevel.RemoveAt(wanted);
                }
                return listMForFight;

            }
            else if(result == 1)
            {

            }

        }
    }
}
