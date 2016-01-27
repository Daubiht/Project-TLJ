using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LogicalGame
{
    [Serializable]
    public class MapZone
    {
        List<MapZone> _listLink = new List<MapZone>();
        MapInstance _context;
        int _zoneLevel;
        Random _rand;
        bool _visited;
        int _x;
        int _y;

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

        public bool Visited
        {
            get { return _visited; }
            set { _visited = value; }
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

            if(race == null)
            {
                List<Monster> M = EntirelistM.GetListMonsters.FindAll(
                    delegate (Monster m)
                {
                    return m.Race != "Merchant";
                });

                race = M[_rand.Next(0, M.Count)].Race;
            }

            List<Monster> listMByLevel = EntirelistM.GetListMonsters.FindAll(
                delegate (Monster m)
                {
                     return race == m.Race;
                }
            );

            int nbrM = _rand.Next(1 + difficulty, 3 + difficulty);

            List<Monster> listMForFight = new List<Monster>();

            for (int i = 0; i < nbrM; i++)
            {
                if(listMByLevel.Count > 0)
                {
                    int wanted = _rand.Next(0, listMByLevel.Count);
                    Monster mob = listMByLevel[wanted];
                    Monster NewMob = new Monster(mob.Name, mob.Level, mob.Race, mob.PhysicalAttack, mob.MagicAttack, mob.Health, mob.Stamina, mob.Robustness, mob.Dodge);
                    NewMob.Gold = mob.Gold;
                    NewMob.XP = mob.XP;
                    NewMob.Drop = mob.Drop;
                    listMForFight.Add(NewMob);
                }
                else
                {
                    int wanted = _rand.Next(0, EntirelistM.GetListMonsters.Count);
                    Monster mob = EntirelistM.GetListMonsters[wanted];
                    Monster NewMob = new Monster(mob.Name, mob.Level, mob.Race, mob.PhysicalAttack, mob.MagicAttack, mob.Health, mob.Stamina, mob.Robustness, mob.Dodge);
                    listMForFight.Add(NewMob);
                }
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
            Merchant merchant;

            int nbrItems = _rand.Next(1, 6);

            for(int i = 0; i < nbrItems; i++)
            {
                int wanted = _rand.Next(0, listItems.Items.Count);

                if(!listSellable.Contains(listItems.Items[wanted]))
                {
                    listSellable.Add(listItems.Items[wanted]);
                }
            }
            merchant = new Merchant("Marchand itinérant", listSellable);
            if(_context != null) merchant.Invent = _context.MapIsland.ActualWorld.Team.Invent;
            return merchant;
        }

        public string[] EventElder()
        {
            string[] riddles = File.ReadAllLines(@"../../../Ressources/enigme.txt");
            _rand = new Random();
            int Wanted = _rand.Next(0, riddles.Length / 4);

            string[] riddleAndAnswer = { riddles[Wanted * 4], riddles[Wanted * 4 + 1], riddles[Wanted * 4 + 2], riddles[Wanted * 4 + 3] };

            return riddleAndAnswer;
        }
    }
}
