using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame
{
    public class CreateItems
    {
        public CreateItems()
        {
            List<Item> listItem = new List<Item>();

            Item item1 = new Item("Dague en bois", 5, 1, "Petite dague en bois, peu efficace en combat mais tres belle ouvrage", "arme");
            item1.AddStats("attaque physique", 5);
            item1.AddStats("esquive", 2);
            listItem.Add(item1);

            Item item2 = new Item("Bandage", 1, 5, "Bandage rudimentaire permettant d'arreter un saignement", "consommable");
            item2.AddStats("vie", 10);
            listItem.Add(item2);

            Item item3 = new Item("Collier en argent", 2, 120, "Collier en argent emettant une étrange lueur", "bijoux");
            item3.AddRequired("attaque magique", 10);
            listItem.Add(item3);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("../../../items.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, listItem);
            stream.Close();
        }
    }
}
