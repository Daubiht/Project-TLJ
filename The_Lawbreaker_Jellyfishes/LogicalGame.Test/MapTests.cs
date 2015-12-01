using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace LogicalGame.Test
{
    [TestFixture]
    public class MapTests
    {
        [Test]
        public void Test_Upload_An_Island()
        {
            //get world.bin
            IFormatter formatter = new BinaryFormatter();
            MapWorld world;
            using (Stream stream = new FileStream("../../../Ressources/world.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                world = (MapWorld)formatter.Deserialize(stream);
            }

            //initialise island
            Dictionary<string, MapIsland> Islands = world.Islands;

            foreach(MapIsland island in Islands.Values)
            {
                if(island.IslandName == "Ponyoland")
                {
                    world.ChangeActualIsland(island, false);
                }
            }

            Assert.AreEqual("Ponyoland", world.ActualIsland);

            //change island
            foreach (MapIsland island in Islands.Values)
            {
                if (island.IslandName == "Terres désolées")
                {
                    world.ChangeActualIsland(island, false);
                }
            }

            Assert.AreEqual("Ponyoland", world.ActualIsland);


            //change city
            world.Islands[world.ActualIsland].ActualPlace = world.Islands[world.ActualIsland].IslandCity;

            Assert.AreEqual("Ponyo", world.Islands[world.ActualIsland].IslandCity.CityName);

            //change instance
            List<MapInstance> listinstance = world.Islands[world.ActualIsland].IslandInstances;
            foreach(MapInstance instance in listinstance)
            {
                if (instance.InstanceName == "Vallée de Ponyo")
                {
                    world.Islands[world.ActualIsland].ActualPlace = instance;
                }
            }

        }

        [Test]
        public void Launch_EventFight_MapZone()
        {
            MapZone zoneTest = new MapZone(null, false, 2);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Difficulty : {0}", i);
                foreach (Monster monster in zoneTest.EventFightRandom(i, null))
                {
                    Console.WriteLine("Name {0}, Level {1}, Race {2}, Front Position ? {3}", monster.Name, monster.Level, monster.Race, monster.FrontPosition);
                }
            }

            List<Monster> m = zoneTest.EventFightRandom(2, "slime");
            Console.WriteLine("Difficulty : 3");
            foreach (Monster monster in m)
            {
                Console.WriteLine("Name {0}, Level {1}, Race {2}, Front Position ? {3}", monster.Name, monster.Level, monster.Race, monster.FrontPosition);
            }
        }

        [Test]
        public void Launch_EventMerchant_MapZone()
        {
            MapZone zoneTest = new MapZone(null, false, 2);

            for (int i = 0; i < 3; i++)
            {
                Merchant merchant = zoneTest.EventMerchant();
                Console.WriteLine("Merchant 1");

                foreach (Item item in merchant.GetItemsAvailable)
                {
                    Console.WriteLine("Name {0}, Description {1}", item.GetName, item.GetDescription);
                }
            }
        }

        [Test]
        public void Launch_EventElder()
        {
            MapZone zoneTest = new MapZone(null, false, 2);

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enigme {0}", i);
                Console.WriteLine(zoneTest.EventElder()[0]);
                Console.WriteLine(zoneTest.EventElder()[1]);
            }
        }
    }
}
