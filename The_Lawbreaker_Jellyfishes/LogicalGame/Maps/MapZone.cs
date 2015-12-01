using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace LogicalGame
{
    [Serializable]
    public class MapZone
    {
        List<MapZone> _listLink = new List<MapZone>();
        MapInstance _context;
        int _zoneLevel;
        Random _rand;

        public MapZone(MapInstance context, bool WithInstance, int zoneLevel)
        {
            _zoneLevel = zoneLevel;
            if(WithInstance)
            {
                _context = context;
                _rand = _context.MapIsland.ActualWorld.Random;
            } 
            else
            {
                _rand = new Random();
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
        /// <param name="type">input race to get specific monster or put it null</param>
        /// <returns>List of monster to fight</returns>
        public List<Monster> EventFightRandom(int difficulty, string race)
        {
            if (difficulty > 2 || difficulty < 0) throw new ArgumentException();

            ListMonsters EntirelistM = new ListMonsters();
            List<Monster> listMByLevel = EntirelistM.GetListMonsters.FindAll(
                delegate (Monster m)
                {
                    if (race == null)
                    {
                        return m.Level >= (_zoneLevel) && m.Level <= (_zoneLevel + difficulty);
                    } 
                    else
                    {
                        return race == m.Race;
                    }
                }
            );

            int nbrM = _rand.Next(1 + difficulty, 3 + difficulty);

            List<Monster> listMForFight = new List<Monster>();

            for (int i = 0; i < nbrM; i++)
            {
                int wanted = _rand.Next(0, listMByLevel.Count);
                listMForFight.Add(listMByLevel[wanted]);
            }

            foreach (Monster m in listMForFight)
            {
                if (m.MagicAttack > m.PhysicalAttack)
                {
                    m.FrontPosition = false;
                }
                else
                {
                    m.FrontPosition = true;
                }
            }

            if (listMForFight.All(m => m.FrontPosition == false))
            {
                foreach (Monster m in listMForFight)
                {
                    m.FrontPosition = true;
                }
            }

            return listMForFight;
        }

        public Merchant EventMerchant()
        {
            ListItems listItems = new ListItems();
            List<Item> listSellable = new List<Item>();

            int nbrItems = _rand.Next(1, 6);

            for(int i = 0; i < nbrItems; i++)
            {
                int wanted = _rand.Next(0, listItems.Items.Count);

                if(!listSellable.Contains(listItems.Items[wanted]))
                {
                    listSellable.Add(listItems.Items[wanted]);
                }
            }

            return new Merchant("Marchand itinérant", listSellable);
        }

        public string[] EventElder()
        {
            string[] riddles = File.ReadAllLines(@"../../../Ressources/enigme.txt");

            int Wanted = _rand.Next(0, riddles.Length / 2);

            string[] riddleAndAnswer = { riddles[Wanted * 2], riddles[Wanted * 2 + 1]};

            return riddleAndAnswer;
        }
    }
}
