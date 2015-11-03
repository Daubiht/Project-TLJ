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
    [Serializable]
    public class MapWorld
    {
        readonly Dictionary<string, MapIsland> _islands = new Dictionary<string, MapIsland>();
        string _actualIsland = null;

        public string ActualIsland
        {
            get { return _actualIsland; }
        }

        public string ChangeActualIsland(MapIsland I, bool militia)
        {
            if (_actualIsland == null)
            {
                _actualIsland = I.IslandName;
                return I.IslandName;
            }
            else
            {

                for (int i = 0; i < I.ListLink.Count; i++)
                {
                    if (_islands[_actualIsland].ListLink[i].IslandName == I.IslandName)
                    {
                        if (militia == false)
                        {
                            //Provok event when a change is done
                        }
                        _actualIsland = I.IslandName;
                        return I.IslandName;
                    }
                }
                throw new ArgumentException();
            }
        }

        public Dictionary<string, MapIsland> Islands
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
        public Dictionary<string, MapIsland> UploadIsland(List<string> islandsNames, List<List<Services>> listCitiesServices, List<string> citiesNames, List<List<string>> listInstancesNames, List<List<List<MapZone>>> listsZones, List<List<List<List<MapZone>>>> ListsZonesLink, List<List<int>> ListsIslandsLink)
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
                    MapInstance newInstance = new MapInstance(newIsland, listInstancesNames[i][i2], listsZones[i][i2]);
                    for(int i3 = 0; i3 < newInstance.listZones.Count; i3++)
                    {
                        newInstance.listZones[i3].ListLink = ListsZonesLink[i][i2][i3];
                        newInstance.listZones[i3].Context = newInstance;
                    }

                    listInstanceForThisIsland.Add(newInstance);
                }
                newIsland.AddInstances(listInstanceForThisIsland);

                listIsland[i] = newIsland;
            }

            //Take every island, create a list of links between the island and the others
            //add the island and his list of link in _islands
            for(int i = 0; i < listIsland.Length; i++)
            {
                List<MapIsland> listlink = new List<MapIsland>();
                for (int i2 = 0; i2 < ListsIslandsLink[i].Count; i2++)
                {
                    listlink.Add(listIsland[ListsIslandsLink[i][i2]]);
                }
                _islands.Add(listIsland[i].IslandName, listIsland[i]);
                listIsland[i].ListLink = listlink;
            }

            return _islands;
        }

    }
}
