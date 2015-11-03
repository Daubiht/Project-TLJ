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
            //get world.bin
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("../../../world.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            MapWorld world = (MapWorld)formatter.Deserialize(stream);
            stream.Close();

            Dictionary<string, MapIsland> Islands = world.Islands;

            foreach (MapIsland island in Islands.Values)
            {
                if (island.IslandName == "Ponyoland")
                {
                    world.ChangeActualIsland(island, false);
                    throw new ArgumentException();
                }
            }

            Assert.AreEqual("Dague en acier", world.Islands[world.ActualIsland].IslandCity.Merchant.GetItemsAvailable[0].GetName);
        }
    }
}
