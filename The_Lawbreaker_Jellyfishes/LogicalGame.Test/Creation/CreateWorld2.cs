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

            //island
            MapIsland island = new MapIsland(world, "island");
            island.pointX = 118;
            island.pointY = 31;

            //Instance for the Island
            MapInstance instance1 = new MapInstance(island, "island-instance-1");
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
            MapCity city = new MapCity(island, "City", listmerch);
            city.PointX = 200;
            city.PointY = 200;

            //add island to world
            world.Islands.Add("island", island);

            //Serialize
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/NewWorld.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, world);
            }
        }
    }
}
