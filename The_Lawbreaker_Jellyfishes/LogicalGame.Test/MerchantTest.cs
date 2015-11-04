using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame.Test
{
    [TestFixture]
    class MerchantTest
    {

        [Test]
        public void Test_create_merchant()
        {
            CreateWorld newWorld = new CreateWorld();
            MapWorld world;
            //get world.bin
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../world.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                world = (MapWorld) formatter.Deserialize(stream);
            }

            Dictionary<string, MapIsland> Islands = world.Islands;

            foreach (MapIsland island in Islands.Values)
            {
                if (island.IslandName == "Ponyoland")
                {
                    world.ChangeActualIsland(island, false);
                }

            }

            Assert.AreEqual("Dague en bois", world.Islands[world.ActualIsland].IslandCity.Merchant.GetItemsAvailable[0].GetName);
        }
    }
}
