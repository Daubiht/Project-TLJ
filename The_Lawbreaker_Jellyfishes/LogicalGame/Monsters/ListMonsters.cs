using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    public class ListMonsters
    {
        readonly List<Monster> _listMonsters = new List<Monster>();

        public List<Monster> AddMonster(Monster M)
        {
            _listMonsters.Add(M);
            return _listMonsters;
        }
        public List<Monster> AddMonster(List<Monster> M)
        {
            for(int i = 0; i < M.Count; i++)
            {
                _listMonsters.Add(M[i]);

            }
            return _listMonsters;
        }

        public List<Monster> GetListMonsters
        {
            get { return _listMonsters; }
        }
    }
}
