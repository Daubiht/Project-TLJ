using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using NUnit.Framework;

namespace LogicalGame.Test
{
    [TestFixture]
    public class CreateWorld2
    {
        [Test]
        public void CreateWorld_2()
        {
            //The World
            MapWorld world = new MapWorld();
            Dictionary<string, MapIsland> Islands = new Dictionary<string, MapIsland>();

            //island 1 ------------------------------------------------------------
            MapIsland island = new MapIsland(world, "Poniénne");
            island.PointX = 0;
            island.PointY = 0;

            //Instance for the Island
            MapInstance instance1 = new MapInstance(island, "Bois polaire", false);
            instance1.PointX = 0;
            instance1.PointY = 0;

            //list zone for instance on the island
            List<MapZone> listZone_instance1 = new List<MapZone>();
            MapZone zone1 = new MapZone(instance1, true, 1);
            zone1.PointX = 0;
            zone1.PointY = 0;

            MapZone zone2 = new MapZone(instance1, true, 2);
            zone2.PointX = 50;
            zone2.PointY = 0;

            MapZone zone3 = new MapZone(instance1, true, 3);
            zone3.PointX = 100;
            zone3.PointY = 0;

            MapZone zone4 = new MapZone(instance1, true, 3);
            zone3.PointX = 150;
            zone3.PointY = 0;

            List<MapZone> listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone1);
            listlink.Add(zone3);
            zone2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            listlink.Add(zone4);
            zone3.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3);
            zone4.ListLink = listlink;

            //Zone must be add like : first is the entry and last the exit
            listZone_instance1.Add(zone1);
            listZone_instance1.Add(zone2);
            listZone_instance1.Add(zone3);
            listZone_instance1.Add(zone4);

            instance1.listZones = listZone_instance1;

            MapInstance instance2 = new MapInstance(island, "Carverne écailleuse", false);
            instance1.PointX = 50;
            instance1.PointY = 0;

            //list zone for instance on the island
            List<MapZone> listZone_instance2 = new List<MapZone>();
            zone1 = new MapZone(instance2, true, 1);
            zone1.PointX = 0;
            zone1.PointY = 0;

            zone2 = new MapZone(instance2, true, 2);
            zone2.PointX = 50;
            zone2.PointY = 0;

            zone3 = new MapZone(instance2, true, 3);
            zone3.PointX = 100;
            zone3.PointY = 0;

            MapZone zone3_1 = new MapZone(instance2, true, 3);
            zone3.PointX = 100;
            zone3.PointY = 50;

            zone4 = new MapZone(instance2, true, 3);
            zone3.PointX = 150;
            zone3.PointY = 0;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone1);
            listlink.Add(zone3);
            zone2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            listlink.Add(zone3_1);
            listlink.Add(zone4);
            zone3.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3);
            zone3_1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3);
            zone4.ListLink = listlink;

            //Zone must be add like : first is the entry and last the exit
            listZone_instance2.Add(zone1);
            listZone_instance2.Add(zone2);
            listZone_instance2.Add(zone3);
            listZone_instance2.Add(zone3_1);
            listZone_instance2.Add(zone4);

            instance2.listZones = listZone_instance2;

            //Instance for the Island
            MapInstance instance3 = new MapInstance(island, "Ancien mégalithe", false);
            instance3.PointX = 150;
            instance3.PointY = 0;

            //list zone for instance on the island
            List<MapZone> listZone_instance3 = new List<MapZone>();
            zone1 = new MapZone(instance3, true, 1);
            zone1.PointX = 0;
            zone1.PointY = 0;

            zone2 = new MapZone(instance3, true, 2);
            zone2.PointX = 50;
            zone2.PointY = 0;

            MapZone zone2_1 = new MapZone(instance3, true, 2);
            zone2.PointX = 50;
            zone2.PointY = 50;

            zone3 = new MapZone(instance3, true, 3);
            zone3.PointX = 100;
            zone3.PointY = 0;

            zone3_1 = new MapZone(instance3, true, 3);
            zone3_1.PointX = 100;
            zone3_1.PointY = 50;

            zone4 = new MapZone(instance3, true, 3);
            zone3.PointX = 150;
            zone3.PointY = 0;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone1);
            listlink.Add(zone2_1);
            listlink.Add(zone3);
            zone2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            listlink.Add(zone3_1);
            listlink.Add(zone4);
            zone3.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3);
            zone4.ListLink = listlink;

            //Zone must be add like : first is the entry and last the exit
            listZone_instance3.Add(zone1);
            listZone_instance3.Add(zone2);
            listZone_instance3.Add(zone2_1);
            listZone_instance3.Add(zone3);
            listZone_instance3.Add(zone3_1);
            listZone_instance3.Add(zone4);

            instance3.listZones = listZone_instance3;

            List<MapInstance> listinstances = new List<MapInstance>();
            listinstances.Add(instance1);
            listinstances.Add(instance2);
            listinstances.Add(instance3);
            island.IslandInstances = listinstances;

            //city for the island
            MapCity city = new MapCity(island, "Ponyo");
            city.PointX = 200;
            city.PointY = 0;
            island.AddCity(city);

            //list sellable items for merchant and merch
            ListItems listI = new ListItems();

            List<Item> itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Dague en bois" || I.GetName == "Bandage";
                });

            Merchant merch1 = new Merchant("Vendeur général", itemsSell);
            merch1.PointX = 50;
            merch1.PointY = 50;
            merch1.Invent = world.Team.Invent;

            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Bandage" || I.GetName == "Poils animals";
                });

            Merchant merch2 = new Merchant("herboriste", itemsSell);
            merch2.PointX = 100;
            merch2.PointY = 50;
            merch2.Invent = world.Team.Invent;

            //Add services
            Mortuary s1 = new Mortuary(city);
            s1.PointX = 50;
            s1.PointY = 100;

            Taverne s2 = new Taverne();
            s2.PointX = 100;
            s2.PointY = 100;

            Militia s3 = new Militia(city);
            s3.PointX = 150;
            s3.PointY = 100;

            //list merchant for city
            List<object> listservices = new List<object>();
            listservices.Add(merch1);
            listservices.Add(merch2);
            listservices.Add(s1);
            listservices.Add(s2);
            listservices.Add(s3);
            city.Services = listservices;

            //add island to world
            Islands.Add("island1", island);

            //island 2 ------------------------------------------------------------
            island = new MapIsland(world, "island2");
            island.PointX = 118;
            island.PointY = 231;

            //Instance for the Island
            instance1 = new MapInstance(island, "island2_instance_1", false);
            instance1.PointX = 130;
            instance1.PointY = 250;

            //list zone for instance on the island
            listZone_instance1 = new List<MapZone>();
            zone1 = new MapZone(instance1, true, 1);
            zone1.PointX = 50;
            zone1.PointY = 50;

            zone2 = new MapZone(instance1, true, 2);
            zone2.PointX = 150;
            zone2.PointY = 150;

            zone3 = new MapZone(instance1, true, 3);
            zone3.PointX = 250;
            zone3.PointY = 250;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone1);
            listlink.Add(zone3);
            zone2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone3.ListLink = listlink;

            listZone_instance1.Add(zone1);
            listZone_instance1.Add(zone2);
            listZone_instance1.Add(zone3);

            instance1.listZones = listZone_instance1;

            listinstances = new List<MapInstance>();
            listinstances.Add(instance1);
            island.IslandInstances = listinstances;

            //city for the island
            city = new MapCity(island, "City2");
            city.PointX = 200;
            city.PointY = 200;
            island.AddCity(city);

            //list sellable items for merchant and merch
            listI = new ListItems();
            itemsSell = new List<Item>();
            itemsSell.Add(listI.Items[1]);

            merch1 = new Merchant("Vendeur général", itemsSell);
            merch1.PointX = 50;
            merch1.PointY = 325;
            merch1.Invent = world.Team.Invent;

            //Add services
            s1 = new Mortuary(city);
            s1.PointX = 300;
            s1.PointY = 110;

            s2 = new Taverne();
            s2.PointX = 190;
            s2.PointY = 100;

            //list merchant for city
            listservices = new List<object>();
            listservices.Add(merch1);
            listservices.Add(s1);
            listservices.Add(s2);
            city.Services = listservices;

            //add island to world
            Islands.Add("island2", island);

            //End-----------------------------------------------

            //list link between island
            List<MapIsland> listlinkis = new List<MapIsland>();
            listlinkis.Add(Islands["island2"]);
            Islands["island1"].ListLink = listlinkis;

            listlinkis = new List<MapIsland>();
            listlinkis.Add(Islands["island1"]);
            Islands["island2"].ListLink = listlinkis;

            //add island to world
            world.Islands = Islands;
            world.ActualPosition = world.Islands["island1"];

            //Serialize
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/NewWorld.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, world);
            }
        }
    }
}
