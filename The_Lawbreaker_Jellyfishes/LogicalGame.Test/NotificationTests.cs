using System.Collections.Generic;
using NUnit.Framework;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame.Test
{
    [TestFixture]
    public class NotificationTests
    {
        [Test]
        public void Test_on_Notification()
        {
            ListNotifications listNotif = new ListNotifications();

            for(int i = 0; i < 13; i++)
            {
                listNotif.AddNotif("notif "+i, i+" notification !");
            }

            List<Notification> newListNotif = listNotif.ListNotif;

            Assert.AreEqual(10, newListNotif.Count);
            Assert.AreEqual("notif 4", newListNotif[1].Name);
            Assert.AreEqual("12 notification !", newListNotif[9].Description);
        }

        [Test]
        public void Add_Test_in_Plopi_Game()
        {
            MapWorld w;

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Saves/1 - Plopi.save", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                w = (MapWorld)formatter.Deserialize(stream);
            }

            w.Notifs.AddNotif("Invasion", "Des démons attaquent la ville de Ponyo !");

            Assert.IsNotEmpty(w.Notifs.ListNotif);

            using (Stream stream = new FileStream("../../../Saves/1 - Plopi.save", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, w);
            }
        }
    }
}
