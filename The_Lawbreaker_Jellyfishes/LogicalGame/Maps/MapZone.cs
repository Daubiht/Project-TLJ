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

        /// <summary>
        /// 3.0 = meet elder with ressurect stuff
        /// </summary>
        /// <param name="MoveIsland">If he's between islands or in an instance, change balance between fight and meet</param>
        /// <returns>The started event</returns>
        //public Event Event(bool MoveIsland) 
        //{
        //    //MoveIsland false : x+ % combat, x- % rencontre
        //    //MoveIsland true : x= % combat, x= % rencontre
        //    //depending on context for choose monster


        //    return E;
        //}
    }
}
