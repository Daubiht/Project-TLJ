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

            Item i1 = new Item("Dague en bois", 5, 10, "Petite dague en bois, peu efficace en combat mais tres belle ouvrage", "arme");
            i1.AddStats("attaque physique", 5);
            i1.AddStats("esquive", 2);
            listItem.Add(i1);

            Item i2 = new Item("Bandage", 1, 5, "Bandage rudimentaire permettant d'arreter un saignement", "consommable");
            i2.AddStats("vie", 10);
            listItem.Add(i2);

            Item i3 = new Item("Collier en argent", 2, 120, "Collier en argent emettant une étrange lueur", "bijou");
            i3.AddRequired("attaque magique", 10);
            listItem.Add(i3);

            Item i4 = new Item("Orbe de Résurrection", 2, 1, "Etrange boule semblable à du cristal qui permettrait de rendre la vie à une personne", "resurrection");
            listItem.Add(i4);

            Item i5 = new Item("Poils animals", 1, 2, "Paquet de poils animals bizarrement, non identifiable", "drop");
            listItem.Add(i5);

            Item i5bis = new Item("Salive de dragon", 1, 2, "Petite fiole remplie de salive de dragon", "drop");
            listItem.Add(i5bis);

            Item i5bis2 = new Item("Ecorce elfique", 1, 2, "Quelques bouts d'écorce d'un arbre ancestrale", "drop");
            listItem.Add(i5bis2);

            Item i6 = new Item("Dague rutherfordium", 25, 5600, "Dague forgée dans un mystérieux élément accompagnée de son foureaux en plomb", "arme");
            //i6.AddStats("attaque physique %", 25);
            i6.AddRequired("attaque physique", 100);
            i6.AddRequired("esquive", 100);
            listItem.Add(i6);

            Item i7 = new Item("Dague en fer", 10, 70, "Dague de fabrication standard, très répendue", "arme");
            i7.AddStats("attaque physique", 8);
            i7.AddStats("esquive", 5);
            listItem.Add(i7);


            Item i8 = new Item("Dague épineuse", 8, 430, "Possibilité de faire saigner l'enemis sur plusieurs tours", "arme");
            i8.AddStats("attaque physique", 30);
            //saignement sur 5 tours
            i8.AddRequired("attaque physique", 40);
            listItem.Add(i8);

            Item i9 = new Item("Dague incinéreuse", 20, 835, "Dague équipée d'un grand chalumeau au lieu d'une lame", "arme");
            i9.AddStats("attaque physique", 42);
            //brûlure sur 3 tours
            i9.AddRequired("attaque physique", 45);
            i9.AddRequired("robustesse", 20);
            listItem.Add(i9);

            Item i10 = new Item("Lame pernicieuse", 12, 1525, "Dague maudite par les démons primordiaux", "arme");
            i10.AddStats("attaque physique", 60);
            i10.AddRequired("attaque physique", 60);
            i10.AddRequired("fatigue", 30);
            listItem.Add(i10);

            Item i11 = new Item("Boublier", 20, 10, "Quelques planches collées les unes aux autres servant de bouclier", "arme");
            i11.AddStats("attaque physique", 1);
            i11.AddStats("esquive", -1);
            i11.AddStats("robustesse", 6);
            listItem.Add(i11);

            Item i12 = new Item("Bouclier de gladiateur", 28, 45, "Bouclier standard dans les arènes de gladiateur", "arme");
            i12.AddStats("attaque physique", 2);
            i12.AddStats("esquive", -3);
            i12.AddStats("robustesse", 18);
            i12.AddRequired("attaque physique", 10);
            i12.AddRequired("fatigue", 10);
            listItem.Add(i12);

            Item i13 = new Item("Bouclier du feu follé", 10, 210, "Bouclier léger ayant d'étranges propriétés magiques", "arme");
            i13.AddStats("attaque magique", 10);
            i13.AddStats("robustesse", 8);
            listItem.Add(i13);

            Item i14 = new Item("Bouclier du Chalala", 30, 380, "Bouclier bénis d'un dieu chat feignant se cachant derrière", "arme");
            i14.AddStats("vie", 20);
            i14.AddStats("robustesse", 10);
            i14.AddRequired("attaque magique", 10);
            listItem.Add(i14);

            Item i15 = new Item("Le mur", 50, 610, "Immense bouclier permettant d'encaisser d'énormes dégâts", "arme");
            i15.AddStats("esquive", -20);
            i15.AddStats("robustesse", 40);
            i15.AddRequired("attaque physique", 30);
            listItem.Add(i15);

            Item i16 = new Item("Poigne démoniaque", 2, 4800, "", "arme");
            i16.AddStats("vie %", -15);
            i16.AddStats("robustesse", 55);
            i16.AddRequired("attaque magique", 25);
            i16.AddRequired("robustesse", 20);
            listItem.Add(i16);

            Item i17 = new Item("Epée en bois", 8, 20, "Epée d'entrainement des plus basiques", "arme");
            i17.AddStats("attaque physique", 7);
            listItem.Add(i17);

            Item i18 = new Item("Cimeterre", 16, 100, "L’intérêt du cimeterre est sa lame courbée qui glisse sur les surfaces dures", "arme");
            i18.AddStats("attaque physique", 25);
            listItem.Add(i18);

            Item i19 = new Item("Stormbringer", 30, 6500, "Epée démoniaque forgée par les dieux du chaos. Possède une jumelle, Mournblade", "arme");
            //i19.AddStats("vie %", 10);
            i19.AddStats("attaque physique", 50);
            i19.AddRequired("attaque physique", 50);
            i19.AddRequired("robustesse", 20);
            listItem.Add(i19);

            Item i20 = new Item("Mournblade", 30, 6500, "Epée démoniaque forgée par les dieux du chaos. Possède une jumelle, Stormbringer", "arme");
            //i20.AddStats("vie %", 10);
            i20.AddStats("attaque magique", 50);
            i19.AddRequired("attaque magique", 50);
            i19.AddRequired("robustesse", 20);
            listItem.Add(i20);

            Item i21 = new Item("Glaive", 20, 350, "Arme standarde de facture militaire", "arme");
            i21.AddStats("attaque physique", 30);
            i21.AddRequired("attaque physique", 25);
            listItem.Add(i21);

            Item i22 = new Item("Rapière fantomatique", 15, 650, "Fine lame fantomatique possédant d'étranges origines", "arme");
            i22.AddStats("attaque physique", 45);
            i22.AddRequired("attaque magique", 30);

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/items.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, listItem);
            }
        }
    }
}
