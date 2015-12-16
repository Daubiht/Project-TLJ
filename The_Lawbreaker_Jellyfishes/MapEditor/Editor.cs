using LogicalGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapEditor
{
    public class Editor
    {
        string _button;
        MapWorld world;

        public Editor ()
        {
            world = new MapWorld();
        }

        public MapWorld World
        {
            get { return world; }
        }

        public string Button
        {
            get { return _button; }
            set { _button = value; }
        }
    }
}
