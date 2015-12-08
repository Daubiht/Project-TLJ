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
            using (Stream stream = new FileStream("../../../Ressources/NewWorld.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                world = (MapWorld)formatter.Deserialize(stream);
            }

            //initialise island
            Dictionary<string, MapIsland> Islands = world.Islands;

            MapIsland i = null;
            foreach(MapIsland island in Islands.Values)
            {
                if(island.IslandName == "island1")
                {
                    world.ChangeActualIsland(island, false);
                    i = island;
                }
            }

            Assert.AreEqual(i, world.ActualPosition);

            //change island
            foreach (MapIsland island in Islands.Values)
            {
                if (island.IslandName == "island2")
                {
                    world.ChangeActualIsland(island, false);
                    i = island;
                }
            }

            Assert.AreEqual(i, world.ActualPosition);


            //change city
            world.ActualPosition = world.Islands[((MapIsland)world.ActualPosition).IslandName].IslandCity;

            Assert.AreEqual("City2",((MapCity)world.ActualPosition).CityName);

            //change instance
            world.ActualPosition = world.Islands["island1"];
            List<MapInstance> listinstance = world.Islands[((MapIsland)world.ActualPosition).IslandName].IslandInstances;
            foreach(MapInstance instance in listinstance)
            {
                if (instance.InstanceName == "island1_instance_1")
                {
                    world.ActualPosition = instance;
                    Assert.AreEqual(instance, world.ActualPosition);
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

        [Test]
        public void Launch_randomEvent()
        {
            MapIsland islandtest = new MapIsland(null, "islandTest");
            MapZone zoneTest = new MapZone(null, false, 2);
            List<MapZone> list = new List<MapZone>();
            list.Add(zoneTest);

            MapInstance instanceTest = new MapInstance(null, "test");
            instanceTest.listZones = list;

            Console.WriteLine("visited");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(instanceTest.EventRandom(true));
            }

            Console.WriteLine(Environment.NewLine + "No island, not visited");
            list.Remove(zoneTest);
            instanceTest.listZones = list;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(instanceTest.EventRandom(false));
            }

            Console.WriteLine(Environment.NewLine + "Island, not visited");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(instanceTest.EventRandom(false));
            }
        }
    }
}
