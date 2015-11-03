using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using LogicalGame;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame.Test
{
    [TestFixture]
    public class MapTest
    {
        [Test]
        public void Test_Upload_An_Island()
        {
            CreateWorld newWorld = new CreateWorld();
            //get world.bin
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("../../../world.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            MapWorld world = (MapWorld)formatter.Deserialize(stream);
            stream.Close();

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
    }
}
