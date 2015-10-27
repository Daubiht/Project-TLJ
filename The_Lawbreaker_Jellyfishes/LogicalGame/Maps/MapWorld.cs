using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LogicalGame
{
    /// <summary>
    /// Repertory each islands and reachable islands
    /// Need to fill it with a file that contains every islands
    /// </summary>
    public class MapWorld
    {
        readonly Dictionary<MapIsland, List<MapIsland>> _islands = new Dictionary<MapIsland, List<MapIsland>>();
        MapIsland _actualIsland = null;

        public MapIsland ActualIsland
        {
            get { return _actualIsland; }
        }

        public MapIsland ChangeActualIsland(MapIsland I, bool militia)
        {
            if (_actualIsland == null)
            {
                _actualIsland = I;
            }

            for (int i = 0; i < _islands[_actualIsland].Count; i++)
            {
                if (_islands[_actualIsland][i] == I)
                {
                    if(militia == false)
                    {
                        //Provok event when a change is done
                    }
                    _actualIsland = I;
                    return I;
                }
            }
            throw new ArgumentException();
        }

        public Dictionary<MapIsland, List<MapIsland>> Islands
        {
            get { return _islands; }
        }

        /// <summary>
        /// For every island :
        /// - create island
        /// - create zone for create instance and put it in island
        /// - create service for create city and put it in island
        /// </summary>
        /// <returns>dictionnary of each island and theirs links</returns>
        public Dictionary<MapIsland, List<MapIsland>> UploadIsland(List<string> islandsNames, List<List<Services>> listCitiesServices, List<string> citiesNames, List<List<string>> listInstancesNames, List<List<Dictionary<MapZone, List<MapZone>>>> listsPacksZones, List<List<int>> ListsLinks)
        {
            MapIsland[] listIsland = new MapIsland[islandsNames.Count];

            //Create every single island and put them in listIsland
            for(int i = 0; i < islandsNames.Count; i++)
            {
                MapIsland newIsland = new MapIsland(this, islandsNames[i]);

                MapCity newCity = new MapCity(newIsland, citiesNames[i], listCitiesServices[i]);
                newIsland.AddCity(newCity);

                List<MapInstance> listInstanceForThisIsland = new List<MapInstance>();
                for(int i2 = 0; i2 < listInstancesNames[i].Count; i2++)
                {
                    MapInstance newInstance = new MapInstance(newIsland, listInstancesNames[i][i2], listsPacksZones[i][i2]);
                    listInstanceForThisIsland.Add(newInstance);
                }
                newIsland.AddInstances(listInstanceForThisIsland);

                listIsland[i] = newIsland;
            }

            //Take every island, create a list of links between the island and the others
            //add the island and his list of link in _islands
            for(int i = 0; i < listIsland.Length; i ++)
            {
                List<MapIsland> listlink = new List<MapIsland>();
                for (int i2 = 0; i2 < ListsLinks[i].Count; i2++)
                {
                    listlink.Add(listIsland[ListsLinks[i][i2]]);
                }
                _islands.Add(listIsland[i], listlink);
            }

            return _islands;
        }

    }
}
