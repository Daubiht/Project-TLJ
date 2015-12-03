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
            island.pointX = 118;
            island.pointY = 31;

            //Instance for the Island
            MapInstance instance1 = new MapInstance(island, "island1_instance_1");
            instance1.PointX = 130;
            instance1.PointY = 50;

            //list zone for instance on the island
            List<MapZone> listZone_instance1 = new List<MapZone>();
            MapZone zone1 = new MapZone(instance1, true, 1);
            zone1.PointX = 50;
            zone1.PointY = 50;
            listZone_instance1.Add(zone1);

            MapZone zone2 = new MapZone(instance1, true, 2);
            zone2.PointX = 150;
            zone2.PointY = 150;
            listZone_instance1.Add(zone2);

            instance1.listZones = listZone_instance1;
            List<MapInstance> listinstances = new List<MapInstance>();
            listinstances.Add(instance1);
            island.IslandInstances = listinstances;

            //list sellable items for merchant and merch
            ListItems listI = new ListItems();
            List<Item> itemsSell = new List<Item>();
            itemsSell.Add(listI.Items[0]);

            Merchant merch1 = new Merchant("Vendeur général", itemsSell);
            merch1.PointX = 100;
            merch1.PointY = 100;

            //list merchant for city
            List<Merchant> listmerch = new List<Merchant>();
            listmerch.Add(merch1);

            //city for the island
            MapCity city = new MapCity(island, "City1", listmerch);
            city.PointX = 200;
            city.PointY = 200;

            //add island to world
            Islands.Add("island1", island);

            //island 2 ------------------------------------------------------------
            island = new MapIsland(world, "island2");
            island.pointX = 118;
            island.pointY = 31;

            //Instance for the Island
            instance1 = new MapInstance(island, "island2_instance_1");
            instance1.PointX = 130;
            instance1.PointY = 50;

            //list zone for instance on the island
            listZone_instance1 = new List<MapZone>();
            zone1 = new MapZone(instance1, true, 1);
            zone1.PointX = 50;
            zone1.PointY = 50;
            listZone_instance1.Add(zone1);

            zone2 = new MapZone(instance1, true, 2);
            zone2.PointX = 150;
            zone2.PointY = 150;
            listZone_instance1.Add(zone2);

            instance1.listZones = listZone_instance1;
            listinstances = new List<MapInstance>();
            listinstances.Add(instance1);
            island.IslandInstances = listinstances;

            //list sellable items for merchant and merch
            listI = new ListItems();
            itemsSell = new List<Item>();
            itemsSell.Add(listI.Items[0]);

            merch1 = new Merchant("Vendeur général", itemsSell);
            merch1.PointX = 100;
            merch1.PointY = 100;

            //list merchant for city
            listmerch = new List<Merchant>();
            listmerch.Add(merch1);

            //city for the island
            city = new MapCity(island, "City2", listmerch);
            city.PointX = 200;
            city.PointY = 200;

            //add island to world
            Islands.Add("island2", island);

            //End-----------------------------------------------

            //list link between island
            List<MapIsland> listlink = new List<MapIsland>();
            listlink.Add(world.Islands["island2"]);
            world.Islands["island1"].ListLink = listlink;

            listlink = new List<MapIsland>();
            listlink.Add(world.Islands["island1"]);
            world.Islands["island1"].ListLink = listlink;

            //add island to world
            world.Islands = Islands;

            //Serialize
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/NewWorld.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, world);
            }
        }
    }
}
