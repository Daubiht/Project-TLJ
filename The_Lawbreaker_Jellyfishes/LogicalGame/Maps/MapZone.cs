using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    public class MapZone
    {
        List<MapZone> _listLink = new List<MapZone>();

        public List<MapZone> ListLink
        {
            get { return _listLink; }
            set { _listLink = value; }
        }
    }
}
