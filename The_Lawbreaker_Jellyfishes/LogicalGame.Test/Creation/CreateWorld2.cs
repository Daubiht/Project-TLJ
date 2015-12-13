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
            MapIsland island = new MapIsland(world, "island1");
            island.PointX = 118;
            island.PointY = 31;

            //Instance for the Island
            MapInstance instance1 = new MapInstance(island, "island1_instance_1", false);
            instance1.PointX = 130;
            instance1.PointY = 50;

            //list zone for instance on the island
            List<MapZone> listZone_instance1 = new List<MapZone>();
            MapZone zone1 = new MapZone(instance1, true, 1);
            zone1.PointX = 50;
            zone1.PointY = 50;

            MapZone zone2 = new MapZone(instance1, true, 2);
            zone2.PointX = 150;
            zone2.PointY = 150;

            MapZone zone3 = new MapZone(instance1, true, 3);
            zone3.PointX = 250;
            zone3.PointY = 250;

            List<MapZone> listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone1);
            listlink.Add(zone3);
            zone2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone3.ListLink = listlink;

            //Zone must be add like : first is the entry and last the exit
            listZone_instance1.Add(zone1);
            listZone_instance1.Add(zone2);
            listZone_instance1.Add(zone3);

            instance1.listZones = listZone_instance1;

            List<MapInstance> listinstances = new List<MapInstance>();
            listinstances.Add(instance1);
            island.IslandInstances = listinstances;

            //city for the island
            MapCity city = new MapCity(island, "City1");
            city.PointX = 100;
            city.PointY = 200;
            island.AddCity(city);

            //list sellable items for merchant and merch
            ListItems listI = new ListItems();
            List<Item> itemsSell = new List<Item>();
            itemsSell.Add(listI.Items[0]);

            Merchant merch1 = new Merchant("Vendeur général", itemsSell);
            merch1.PointX = 50;
            merch1.PointY = 325;
            merch1.Invent = world.Team.Invent;

            itemsSell.Add(listI.Items[1]);
            Merchant merch2 = new Merchant("herboriste", itemsSell);
            merch2.PointX = 250;
            merch2.PointY = 325;
            merch2.Invent = world.Team.Invent;

            //Add services
            Mortuary s1 = new Mortuary(city);
            s1.PointX = 300;
            s1.PointY = 110;

            Taverne s2 = new Taverne();
            s2.PointX = 190;
            s2.PointY = 100;

            Militia s3 = new Militia(city);
            s3.PointX = 39;
            s3.PointY = 39;

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
