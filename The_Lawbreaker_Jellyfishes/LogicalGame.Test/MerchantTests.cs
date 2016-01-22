using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame.Test
{
    [TestFixture]
    class MerchantTests
    {

        [Test]
        public void Test_to_know_if_the_merchant_sells_the_correct_items()
        {
            MapWorld world;
            //get world.bin
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/NewWorld.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
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

            Assert.AreEqual("Bandage", ((Merchant)world.Islands["Poniénne"].IslandCity.Services[1]).GetItemsAvailable[0].GetName);
        }

        [Test]
        public void Test_if_the_current_team_can_buy_items()
        {

            // Create a temporary team for the test without parameters
            

            // Create a city "Ponyoland" for the test
            MapWorld world;
            //get world.bin
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/NewWorld.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                world = (MapWorld)formatter.Deserialize(stream);
            }

            Dictionary<string, MapIsland> Islands = world.Islands;

            foreach (MapIsland island in Islands.Values)
            {
                if (island.IslandName == "Ponyoland")
                {
                    world.ChangeActualIsland(island, false);
                }

            }

            Team team = new Team(null);
            team.Invent.AddGold(100);

            // Here we get the merchant in the island Ponyoland
            Merchant merchant = ((Merchant)world.Islands["Poniénne"].IslandCity.Services[0]);
            merchant.Invent = team.Invent;

            // Test if the team really got 100 gold
            Assert.AreEqual(200, team.Invent.GetGold);

            // Test if the invenoty is empty
            Assert.IsEmpty(team.Invent.Inventory);

            // We buy an item to the merchant
            merchant.BuyItems(merchant.GetItemsAvailable[0], 1);

            // Verify if the gold was removed
            Assert.AreEqual(188, team.Invent.GetGold);

            // Verify if the invent of the team is not empty
            Assert.IsNotEmpty(team.Invent.Inventory);


            // Test if the team can sell an item to the merchant
            foreach(Item i in team.Invent.Inventory.Keys)
            {
                if(i.GetName == "Dague en bois")
                {
                    merchant.SellItems(i);
                    break;
                }
            }

            Assert.IsEmpty(team.Invent.Inventory);

            // Test if the team got gold after selling an item
            Assert.AreEqual(196, team.Invent.GetGold);

        }
    }
}
