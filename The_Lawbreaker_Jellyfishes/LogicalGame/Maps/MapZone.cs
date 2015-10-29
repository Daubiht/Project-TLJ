using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    public class MapZone
    {
        List<MapZone> _listLink = new List<MapZone>();
        readonly MapInstance _context;

        public MapZone(MapInstance context, bool WithInstance)
        {
            if(WithInstance == true)
            {
                _context = context;
            }
        }

        public List<MapZone> ListLink
        {
            get { return _listLink; }
            set { _listLink = value; }
        }

        /// <summary>
        /// 0.0, 0.1, 0.2 = meet commun/rare/extraordinary merchant
        /// 1.1, 1.2, [...], 1.9 = combat with level of difficulty
        /// 2.1, 2.2, [...], 2.9 = boss combat with level of difficulty
        /// 3.0 = meet elder with ressurect stuff
        /// </summary>
        /// <param name="MoveIsland">If he's between islands or in an instance, change balance between fight and meet</param>
        /// <returns>The started event</returns>
        public Event Event(bool MoveIsland) 
        {
            //MoveIsland false : x+ % combat, x- % rencontre
            //MoveIsland true : x= % combat, x= % rencontre
            //depending on context for choose monster


            return E;
        }
    }
}
