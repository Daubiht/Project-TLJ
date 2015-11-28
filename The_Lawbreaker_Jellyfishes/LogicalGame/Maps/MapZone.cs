using System;
using System.Collections.Generic;
using System.Threading;

namespace LogicalGame
{
    [Serializable]
    public class MapZone
    {
        List<MapZone> _listLink = new List<MapZone>();
        MapInstance _context;
        int _zoneLevel;

        public MapZone(MapInstance context, bool WithInstance, int zoneLevel)
        {
            _zoneLevel = zoneLevel;
            if(WithInstance)
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

        /// <summary>
        /// Choose the difficulty of the fight and it will return a list of monster to fight
        /// the difficulty is a possibility, not an obligation (except for boss)
        /// </summary>
        /// <param name="difficulty">0 easy, 1 normal, 2 hard</param>
        /// <returns></returns>
        public List<Monster> EventFightRandom(int difficulty)
        {
            if(difficulty > 2 || difficulty < 0) throw  new ArgumentException();

            Random rand = new Random();

            ListMonsters EntirelistM = new ListMonsters();
            List<Monster> listMByLevel = EntirelistM.GetListMonsters.FindAll(
                delegate (Monster m)
                {
                    return m.Level >= (_zoneLevel) && m.Level <= (_zoneLevel + difficulty);
                }
            );

            int nbrM = rand.Next(1 + difficulty, 3 + difficulty);

            List<Monster> listMForFight = new List<Monster>();

            for(int i = 0; i < nbrM; i ++)
            {
                int wanted = rand.Next(0, listMByLevel.Count);
                Thread.Sleep(50);
                listMForFight.Add(listMByLevel[wanted]);
            }

            return listMForFight;
        }
    }
}
