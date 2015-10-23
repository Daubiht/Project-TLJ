using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    /// <summary>
    /// Repertory each islands and reachable islands
    /// Need to fill it with a file that contains every islands
    /// </summary>
    public class MapWorld
    {

        readonly Dictionary<MapIsland, MapIsland[]> _islands = new Dictionary<MapIsland, MapIsland[]>();
        MapIsland _actualIsland;

        public MapWorld(MapIsland island, MapIsland[] listReachable)
        {

        }

        public MapIsland ActualIsland
        {
            get { return _actualIsland; }
            set
            {
                for(int i =0; i < _islands[_actualIsland].Length; i++)
                {
                    if (_islands[_actualIsland][i] == value)
                    {
                        _actualIsland = value;
                    }
                }
            }
        }

    }
}
