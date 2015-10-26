using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Notification.Test
{
    [TestFixture]
    public class NotificationTest
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
    }
}
