using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame.Test
{
    [TestFixture]
    class A_Save
    {
        [Test]
        public void test_save_methode()
        {
            IFormatter formatter = new BinaryFormatter();
            MapWorld world;
            using (Stream stream = new FileStream("../../../Ressources/world.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                world = (MapWorld)formatter.Deserialize(stream);
            }

            Character MainC1 = new Character("Plopi", "dwarf", true);
            MainC1.IsMain = true;
            world.Team.AddMembers(MainC1);
            world.Save(1);

            Character MainC2 = new Character("David", "giant", true);
            MainC2.IsMain = true;
            world.Team.RemoveMembers(MainC1);
            world.Team.AddMembers(MainC2);
            world.Save(2);

            Character MainC3 = new Character("Jack", "elf", true);
            MainC3.IsMain = true;
            world.Team.RemoveMembers(MainC2);
            world.Team.AddMembers(MainC3);
            world.Save(3);
        }
    }
}
