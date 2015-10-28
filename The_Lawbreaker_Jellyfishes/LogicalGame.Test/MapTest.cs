using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using LogicalGame;

namespace LogicalGame.Test
{
    [TestFixture]
    public class MapTest
    {
        [Test]
        public void Test_Upload_An_Island()
        {
            //call UploadIsland
            CreateFakeWorld createFackWorld = new CreateFakeWorld();
            MapWorld world = createFackWorld.GetFakeWorld();

            //initialise island
            Dictionary<string, MapIsland> Islands = world.Islands;

            foreach(MapIsland island in Islands.Values)
            {
                if(island.IslandName == "Ponyoland")
                {
                    world.ChangeActualIsland(island, false);
                }
            }

            //change island
            foreach (MapIsland island in Islands.Values)
            {
                if (island.IslandName == "Terres désolées")
                {
                    world.ChangeActualIsland(island, false);
                }
            }

            //change city
            world.Islands[world.ActualIsland].ActualPlace = world.Islands[world.ActualIsland].IslandCity;

            //change instance
            List<MapInstance> listinstance = world.Islands[world.ActualIsland].IslandInstances;
            foreach(MapInstance instance in listinstance)
            {
                if (instance.InstanceName == "Le grand rien")
                {
                    world.Islands[world.ActualIsland].ActualPlace = instance;
                }
            }
        }
    }
}
