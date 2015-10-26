using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicalGame;

namespace Inventory.Test
{
    public class CreateFakeWorld
    {
        public MapWorld CreateFakeWorld()
        {
            //Parameter islandsNames
            List<string> islandsNames = new List<string>();
            islandsNames.Add("Ponyoland");
            islandsNames.Add("Terres désolées");


            //parameter listCitiesServices
            List<Services> listServicePonyo = new List<Services>();
            Services merchant = new Services();
            Services pub = new Services();
            listServicePonyo.Add(merchant);
            listServicePonyo.Add(pub);

            List<Services> listServiceGazTown = new List<Services>();
            Services gaz = new Services();
            listServiceGazTown.Add(gaz);

            List<List<Services>> listCitiesServices = new List<List<Services>>();
            listCitiesServices.Add(listServicePonyo);
            listCitiesServices.Add(listServiceGazTown);

            //parameter citiesNames
            List<string> citiesNames = new List<string>();
            citiesNames.Add("Ponyo");
            citiesNames.Add("GazTown");

            //parameter listInstancesNames
            List<string> listInstancePonyo = new List<string>();
            listInstancePonyo.Add("Fôret de Ponyo");
            listInstancePonyo.Add("Lac de Ponyo");

            List<string> listInstanceGazTown = new List<string>();
            listInstanceGazTown.Add("Le grand rien");

            List<List<string>> listInstancesNames = new List<List<string>>();
            listInstancesNames.Add(listInstancePonyo);
            listInstancesNames.Add(listInstanceGazTown);

            //parameter listsPacksZones
            List<List<Dictionary<MapZone, List<MapZone>>>> listsPackZone = new List<List<Dictionary<MapZone, List<MapZone>>>>();

            //Ponyo
            List<Dictionary<MapZone, List<MapZone>>> list_Dictio_Of_Zone_And_Links_Of_Ponyo_Instances = new List<Dictionary<MapZone, List<MapZone>>>();
            //instance 1
            Dictionary<MapZone, List<MapZone>> dictio_of_zone_and_link_for_ponyo_1_instance = new Dictionary<MapZone, List<MapZone>>();
            //zone 1 inst 1
            MapZone zonePonyo1_1 = new MapZone();
            //zone 2 inst 1
            MapZone zonePonyo2_1 = new MapZone();
            //zone 3 inst 1
            MapZone zonePonyo3_1 = new MapZone();

            List<MapZone> linkzonePonyo1_1 = new List<MapZone>();
            linkzonePonyo1_1.Add(zonePonyo2_1);
            linkzonePonyo1_1.Add(zonePonyo3_1);
            List<MapZone> linkzonePonyo2_1 = new List<MapZone>();
            linkzonePonyo2_1.Add(zonePonyo1_1);
            linkzonePonyo2_1.Add(zonePonyo3_1);
            List<MapZone> linkzonePonyo3_1 = new List<MapZone>();
            linkzonePonyo3_1.Add(zonePonyo1_1);
            linkzonePonyo3_1.Add(zonePonyo2_1);

            dictio_of_zone_and_link_for_ponyo_1_instance.Add(zonePonyo1_1, linkzonePonyo1_1);
            dictio_of_zone_and_link_for_ponyo_1_instance.Add(zonePonyo2_1, linkzonePonyo2_1);
            dictio_of_zone_and_link_for_ponyo_1_instance.Add(zonePonyo3_1, linkzonePonyo3_1);

            //instance 2
            Dictionary<MapZone, List<MapZone>> dictio_of_zone_and_link_for_ponyo_2_instance = new Dictionary<MapZone, List<MapZone>>();
            //zone 1 inst 2
            MapZone zonePonyo1_2 = new MapZone();
            //zone 2 inst 2
            MapZone zonePonyo2_2 = new MapZone();
            //zone 3 inst 2
            MapZone zonePonyo3_2 = new MapZone();

            List<MapZone> linkzonePonyo1_2 = new List<MapZone>();
            linkzonePonyo1_2.Add(zonePonyo2_2);
            linkzonePonyo1_2.Add(zonePonyo3_2);
            List<MapZone> linkzonePonyo2_2 = new List<MapZone>();
            linkzonePonyo2_2.Add(zonePonyo1_2);
            linkzonePonyo2_2.Add(zonePonyo3_2);
            List<MapZone> linkzonePonyo3_2 = new List<MapZone>();
            linkzonePonyo3_2.Add(zonePonyo1_2);
            linkzonePonyo3_2.Add(zonePonyo2_2);

            dictio_of_zone_and_link_for_ponyo_2_instance.Add(zonePonyo1_2, linkzonePonyo1_2);
            dictio_of_zone_and_link_for_ponyo_2_instance.Add(zonePonyo2_2, linkzonePonyo2_2);
            dictio_of_zone_and_link_for_ponyo_2_instance.Add(zonePonyo3_2, linkzonePonyo3_2);

            list_Dictio_Of_Zone_And_Links_Of_Ponyo_Instances.Add(dictio_of_zone_and_link_for_ponyo_1_instance);
            list_Dictio_Of_Zone_And_Links_Of_Ponyo_Instances.Add(dictio_of_zone_and_link_for_ponyo_2_instance);
            //in the final pack
            listsPackZone.Add(list_Dictio_Of_Zone_And_Links_Of_Ponyo_Instances);

            //gazTown
            List<Dictionary<MapZone, List<MapZone>>> list_Dictio_Of_Zone_And_Links_Of_GazTown_Instances = new List<Dictionary<MapZone, List<MapZone>>>();
            //instance 1
            Dictionary<MapZone, List<MapZone>> dictio_of_zone_and_link_for_GazTown_1_instance = new Dictionary<MapZone, List<MapZone>>();
            //zone 1 inst 1
            MapZone zoneGazTown1_1 = new MapZone();
            MapZone zoneGazTown2_1 = new MapZone();
            List<MapZone> linkzoneGazTown1_1 = new List<MapZone>();
            linkzoneGazTown1_1.Add(zoneGazTown2_1);
            List<MapZone> linkzoneGazTown2_1 = new List<MapZone>();
            linkzoneGazTown2_1.Add(zoneGazTown1_1);

            list_Dictio_Of_Zone_And_Links_Of_GazTown_Instances.Add(dictio_of_zone_and_link_for_GazTown_1_instance);
            //in the final pack
            listsPackZone.Add(list_Dictio_Of_Zone_And_Links_Of_GazTown_Instances);



            //parameter ListsLinks
            List<List<int>> listsLinks = new List<List<int>>();

            List<int> linkPonyo = new List<int>();
            linkPonyo.Add(1);
            List<int> linkGazTown = new List<int>();
            linkGazTown.Add(0);


            listsLinks.Add(linkPonyo);
            listsLinks.Add(linkGazTown);

            //call UploadIsland
            MapWorld world = new MapWorld();
            world.UploadIsland(islandsNames, listCitiesServices, citiesNames, listInstancesNames, listsPackZone, listsLinks);

            return world;
        }
    }
}
