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
    public class CreateItems
    {
        [Test]
        public void Create_items_and_serializ()
        {
            List<Item> listItem = new List<Item>();

            Item item1 = new Item("Dague en bois", 5, 10, "Petite dague en bois, peu efficace en combat mais tres belle ouvrage", "arme");
            item1.AddStats("attaque physique", 5);
            item1.AddStats("esquive", 2);
            listItem.Add(item1);

            Item item2 = new Item("Bandage", 1, 5, "Bandage rudimentaire permettant d'arreter un saignement", "consommable");
            item2.AddStats("vie", 10);
            listItem.Add(item2);

            Item item3 = new Item("Collier en argent", 2, 120, "Collier en argent emettant une étrange lueur", "bijou");
            item3.AddRequired("attaque magique", 10);
            listItem.Add(item3);

            Item item4 = new Item("Orbe de Résuréction", 2, 1, "Etrange boule semblable à du cristal qui permetrait de rendre la vie à une personne", "resurection");
            listItem.Add(item4);

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/items.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, listItem);
            }
        }
    }
}
