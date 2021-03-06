﻿using System;
using System.Collections.Generic;

namespace LogicalGame
{
    [Serializable]
    public class MapIsland
    {
        readonly MapWorld _context;
        readonly string _name;
        List<MapInstance> _listInstance;
        MapCity _city;
        List<MapIsland> _listLink;
        int _x;
        int _y;

        public MapIsland(MapWorld context, string name)
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

        public List<MapIsland> ListLink
        {
            get { return _listLink; }
            set { _listLink = value; }
        }

        public MapWorld ActualWorld
        {
            get { return _context; }
        }

        public string IslandName
        {
            get { return _name; }
        }

        public MapCity IslandCity
        {
            get { return _city; }
        }

        public List<MapInstance> IslandInstances
        {
            get { return _listInstance; }
            set { _listInstance = value; }
        }

        public MapCity AddCity(MapCity city)
        {
            _city = city;
            return _city;
        }
    }
}
