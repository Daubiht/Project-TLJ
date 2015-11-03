using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicalGame;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame.Test
{
    public class CreateWorld
    {
        public CreateWorld()
        {
            //Parameter islandsNames
            List<string> islandsNames = new List<string>();
            islandsNames.Add("Ponyoland");
            islandsNames.Add("L'île dévastée");
            islandsNames.Add("L'île perdue");
            islandsNames.Add("Genefort");

            //Parameter citiesNames
            List<string> citiesNames = new List<string>();
            citiesNames.Add("Ponyo");
            citiesNames.Add("Gaz Town");
            citiesNames.Add("Ville perdue");
            citiesNames.Add("Laurento");

            //Parameter listInstancesNames
            List<List<string>> listInstancesNames = new List<List<string>>();
            List<string> list_listInstancesNames_1 = new List<string>();
            List<string> list_listInstancesNames_2 = new List<string>();
            List<string> list_listInstancesNames_3 = new List<string>();
            List<string> list_listInstancesNames_4 = new List<string>();

            list_listInstancesNames_1.Add("Vallée de Ponyo");
            list_listInstancesNames_1.Add("Fôret de Ponyo");

            list_listInstancesNames_2.Add("Terre désolée");
            list_listInstancesNames_2.Add("Fôret désolée");

            list_listInstancesNames_3.Add("Desert perdu");
            list_listInstancesNames_3.Add("Fôret perdu");

            list_listInstancesNames_4.Add("Fôret bibliothécaire");
            list_listInstancesNames_4.Add("Vallée de l'encre");

            listInstancesNames.Add(list_listInstancesNames_1);
            listInstancesNames.Add(list_listInstancesNames_2);
            listInstancesNames.Add(list_listInstancesNames_3);
            listInstancesNames.Add(list_listInstancesNames_4);

            //Parameter listsZones & ListsZonesLink
            List<List<List<MapZone>>> listsZones = new List<List<List<MapZone>>>();
            List<List<List<List<MapZone>>>> ListsZonesLink = new List<List<List<List<MapZone>>>>();

            for (int i = 0; i < 4; i++)
            {
                List<List<MapZone>> list_listsZones = new List<List<MapZone>>();
                List<List<List<MapZone>>> list_listsZonesLink = new List<List<List<MapZone>>>();

                for (int i2 = 0; i2 < 2; i2++)
                {
                    List<MapZone> list_list_listsZones = new List<MapZone>();
                    List<List<MapZone>> list_list_listsZonesLink = new List<List<MapZone>>();

                    for (int i3 = 0; i3 < 3; i3++)
                    {
                        MapZone zone = new MapZone(null, false);
                        list_list_listsZones.Add(zone);
                    }

                    for(int i3 = 0; i3 < 3; i3++)
                    {
                        List<MapZone> list_list_list_listsZonesLink = new List<MapZone>();

                        for (int i4 = 0; i4 < list_list_listsZones.Count; i4++)
                        {
                            if (i4 != i3)
                            {
                                list_list_list_listsZonesLink.Add(list_list_listsZones[i4]);
                            }
                        }

                        list_list_listsZonesLink.Add(list_list_list_listsZonesLink);
                    }

                    list_listsZonesLink.Add(list_list_listsZonesLink);
                    list_listsZones.Add(list_list_listsZones);
                }

                ListsZonesLink.Add(list_listsZonesLink);
                listsZones.Add(list_listsZones);
            }

            //Parameter listsIslandsLink
            List<List<int>> listsIslandsLink = new List<List<int>>();

            List<int> list_listsIslandsLink_1 = new List<int>();
            list_listsIslandsLink_1.Add(1);
            list_listsIslandsLink_1.Add(2);

            List<int> list_listsIslandsLink_2 = new List<int>();
            list_listsIslandsLink_2.Add(0);
            list_listsIslandsLink_2.Add(3);

            List<int> list_listsIslandsLink_3 = new List<int>();
            list_listsIslandsLink_3.Add(0);
            list_listsIslandsLink_3.Add(3);

            List<int> list_listsIslandsLink_4 = new List<int>();
            list_listsIslandsLink_4.Add(1);
            list_listsIslandsLink_4.Add(2);

            listsIslandsLink.Add(list_listsIslandsLink_1);
            listsIslandsLink.Add(list_listsIslandsLink_2);
            listsIslandsLink.Add(list_listsIslandsLink_3);
            listsIslandsLink.Add(list_listsIslandsLink_4);

            //call UploadIsland
            MapWorld world = new MapWorld();
            world.UploadIsland(islandsNames, citiesNames, listInstancesNames, listsZones, ListsZonesLink, listsIslandsLink);

            //Serialise
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("../../../world.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, world);
            stream.Close();

        }
    }
}
