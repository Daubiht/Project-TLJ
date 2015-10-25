using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Map.Tests
{
    [TestFixture]
    public class MapTest
    {
        [Test]
        public void Test_Upload_An_Island()
        {
            //Parameter islandsNames
            List<string> islandsNames = new List<string>();
            islandsNames.Add("Ponyoland");
            islandsNames.Add("Terres désolées");
            islandsNames.Add("Iceland");

            //parameter listCitiesServices
            List<Services> listServicePonyo = new List<Services>();
            Services merchant = new Services();
            Services pub = new Services();
            listServicePonyo.Add(merchant);
            listServicePonyo.Add(pub);

            List<Services> listServiceGazTown = new List<Services>();
            Services gaz = new Services();
            listServiceGazTown.Add(gaz);

            List<Services> listServiceReik = new List<Services>();
            Services termalSource = new Services();
            listServiceReik.Add(termalSource);

            List<List<Services>> listCitiesServices = new List<List<Services>>();
            listCitiesServices.Add(listServicePonyo);
            listCitiesServices.Add(listServiceGazTown);
            listCitiesServices.Add(listServiceReik);

            //parameter citiesNames
            List<string> citiesNames = new List<string>();
            citiesNames.Add("Ponyo");
            citiesNames.Add("GazTown");
            citiesNames.Add("Reik");

            //parameter listInstancesNames
            List<string> listInstancePonyo = new List<string>();
            listInstancePonyo.Add("Fôret de Ponyo");
            listInstancePonyo.Add("Lac de Ponyo");

            List<string> listInstanceGazTown = new List<string>();
            listInstanceGazTown.Add("Le grand rien");
            listInstanceGazTown.Add("Desert de rien");

            List<string> listInstanceReik = new List<string>();
            listInstanceReik.Add("Vallé de Reik");

            List<List<string>> listInstancesNames = new List<List<string>>();
            listInstancesNames.Add(listInstancePonyo);
            listInstancesNames.Add(listInstanceGazTown);
            listInstancesNames.Add(listInstanceReik);

            //parameter listsPacksZones
            List<List<Dictionary<MapZone, List<MapZone>>>> listsPackZone = new List<List<Dictionary<MapZone, List<MapZone>>>>();

                //Ponyo
            List<Dictionary<MapZone, List<MapZone>>> list_Dictio_Of_Zone_And_Links_Of_Ponyo_Instances = new List<Dictionary<MapZone, List<MapZone>>>();
                    //instance 1
            Dictionary<MapZone, List<MapZone>> dictio_of_zone_and_link_for_ponyo_1_instance = new Dictionary<MapZone, List<MapZone>>();
                        //zone 1 inst 1
                        MapZone zone1_1 = new MapZone();
                        //zone 2 inst 1
                        MapZone zone2_1 = new MapZone();
                        //zone 3 inst 1
                        MapZone zone3_1 = new MapZone();

                        List<MapZone> linkzone1_1 = new List<MapZone>();
                        linkzone1_1.Add(zone2_1);
                        linkzone1_1.Add(zone3_1);
                        List<MapZone> linkzone2_1 = new List<MapZone>();
                        linkzone2_1.Add(zone1_1);
                        linkzone2_1.Add(zone3_1);
                        List<MapZone> linkzone3_1 = new List<MapZone>();
                        linkzone3_1.Add(zone1_1);
                        linkzone3_1.Add(zone2_1);

                        dictio_of_zone_and_link_for_ponyo_1_instance.Add(zone1_1, linkzone1_1);
                        dictio_of_zone_and_link_for_ponyo_1_instance.Add(zone2_1, linkzone2_1);
                        dictio_of_zone_and_link_for_ponyo_1_instance.Add(zone3_1, linkzone3_1);

            list_Dictio_Of_Zone_And_Links_Of_Ponyo_Instances.Add(dictio_of_zone_and_link_for_ponyo_1_instance);
                   //instance 2
            Dictionary<MapZone, List<MapZone>> dictio_of_zone_and_link_for_ponyo_2_instance = new Dictionary<MapZone, List<MapZone>>();
                        //zone 1 inst 2
                        MapZone zone1_2 = new MapZone();
                        List<MapZone> linkzone1_2 = new List<MapZone>();
                        dictio_of_zone_and_link_for_ponyo_2_instance.Add(zone1_2, linkzone1_2);

            list_Dictio_Of_Zone_And_Links_Of_Ponyo_Instances.Add(dictio_of_zone_and_link_for_ponyo_2_instance);
                    //in the final pack
            listsPackZone.Add(list_Dictio_Of_Zone_And_Links_Of_Ponyo_Instances);

                //gazTown
            List<Dictionary<MapZone, List<MapZone>>> list_Dictio_Of_Zone_And_Links_Of_GazTown_Instances = new List<Dictionary<MapZone, List<MapZone>>>();
                  //instance 1
            Dictionary<MapZone, List<MapZone>> dictio_of_zone_and_link_for_GazTown_1_instance = new Dictionary<MapZone, List<MapZone>>();
                        //zone 1 inst 1

            list_Dictio_Of_Zone_And_Links_Of_GazTown_Instances.Add(dictio_of_zone_and_link_for_GazTown_1_instance);
                    //in the final pack
            listsPackZone.Add(list_Dictio_Of_Zone_And_Links_Of_GazTown_Instances);

                //Reik
            List<Dictionary<MapZone, List<MapZone>>> list_Dictio_Of_Zone_And_Links_Of_Reik_Instances = new List<Dictionary<MapZone, List<MapZone>>>();
                    //instance 1
            Dictionary<MapZone, List<MapZone>> dictio_of_zone_and_link_for_Reik_1_instance = new Dictionary<MapZone, List<MapZone>>();
                       //zone 1 inst 1

            list_Dictio_Of_Zone_And_Links_Of_Reik_Instances.Add(dictio_of_zone_and_link_for_Reik_1_instance);
                    //in the final pack
            listsPackZone.Add(list_Dictio_Of_Zone_And_Links_Of_Reik_Instances);


            //parameter ListsLinks
            List<List<int>> listsLinks = new List<List<int>>();

            List<int> linkPonyo = new List<int>();
            linkPonyo.Add(1);
            linkPonyo.Add(2);
            List<int> linkGazTown = new List<int>();
            linkGazTown.Add(0);
            linkGazTown.Add(2);
            List<int> linkReik = new List<int>();
            linkReik.Add(0);
            linkReik.Add(1);

            listsLinks.Add(linkPonyo);
            listsLinks.Add(linkGazTown);
            listsLinks.Add(linkReik);

            //call UploadIsland
            MapWorld world = new MapWorld();
            world.UploadIsland(islandsNames, listCitiesServices, citiesNames, listInstancesNames, listsPackZone, listsLinks);
        }

    }
}
