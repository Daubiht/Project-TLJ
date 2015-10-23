using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Map.Tests
{
    [TestFixture]
    public class MapWorldTest
    {
        [Test]
        public void Test_TextWriter()
        {
            MapWorld mw = new MapWorld();
            List<string[]> tab = new List<string[]>();
            string[] tabA = { "héhé", "huhu" };
            string[] tabB = { "hoho" };
            tab.Add(tabA);
            tab.Add(tabB);
            Assert.AreEqual(tab, mw.UploadIsland());
        }

    }
}
