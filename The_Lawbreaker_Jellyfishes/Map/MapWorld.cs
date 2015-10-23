using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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

        public MapIsland ActualIsland
        {
            get { return _actualIsland; }
            set
            {
                for(int i = 0; i < _islands[_actualIsland].Length; i++)
                {
                    if (_islands[_actualIsland][i] == value)
                    {
                        _actualIsland = value;
                    }
                }
            }
        }

        public List<string[]> UploadIsland()
        {
            using (TextReader tr = new StreamReader(@".\plop.txt"))
            {
                List<string[]> tab = new List<string[]>();
                string line;
                while((line = tr.ReadLine()) != null)
                {
                    string[] wordByWord = line.Split(' ');
                    tab.Add(wordByWord);
                }
                return tab;
            }
        }

    }
}
