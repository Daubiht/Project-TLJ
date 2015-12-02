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
            MapWorld world = new MapWorld();

            MapIsland island = new MapIsland(world, "island");
            island.pointX = 118;
            island.pointY = 31;

            MapInstance instance1 = new MapInstance(island, "island-instance-1");
            instance1.PointX = 130;
            instance1.PointY = 50;

            List<MapZone> listZone_instance1 = new List<MapZone>();
            MapZone zone1 = new MapZone(instance1, true, 1);
            listZone_instance1.Add(zone1);
            MapZone zone2 = new MapZone(instance1, true, 2);
            listZone_instance1.Add(zone2);
            instance1.listZones = listZone_instance1;


            world.Islands.Add("island", island);
        }
    }
}
