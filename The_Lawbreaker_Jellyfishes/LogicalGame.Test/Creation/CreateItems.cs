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

            Item i2 = new Item("Bandage", 1, 10, "Bandage rudimentaire permettant d'arreter un saignement", "consommable");
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

            Item i5bis2 = new Item("Ecorce elfique", 1, 300, "Ecorce elfique dissoute dans de l'eau chaud, rendant plus fort qu'un bœuf le consommateur", "consommable");
            i5bis2.AddStats("vie", -10);
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
            listItem.Add(i22);

            Item i23 = new Item("Capuche en cuir", 2, 5, "Cuir de vache tanné, consu en forme de capuche", "tete");
            i23.AddStats("robustesse", 3);
            i23.AddStats("esquive", 2);
            listItem.Add(i23);

            Item i24 = new Item("Capuche en tissu", 1, 5, "Tissu en laine de mouton, consu en forme de capuche", "tete");
            i24.AddStats("robustesse", 2);
            i24.AddStats("attaque magique", 3);
            listItem.Add(i24);

            Item i25 = new Item("Casque en fer", 4, 8, "Casque rudimentaire en fer mais efficace", "tete");
            i25.AddStats("robustesse", 6);
            listItem.Add(i25);

            Item i26 = new Item("Casque de chevalier", 8, 75, "Casque de très bonne qualité, équipement standard pour la garde royal", "tete");
            i26.AddStats("robustesse", 15);
            i26.AddRequired("attaque physique", 20);
            listItem.Add(i26);

            Item i27 = new Item("Capuche en cuir+", 4, 40, "Capuche de cuir de qualité supérieur, utilisé pour la fabrication d'armure", "tete");
            i27.AddStats("robustesse", 6);
            i27.AddStats("esquive", 4);
            i27.AddRequired("attaque physique", 10);
            listItem.Add(i27);

            Item i28 = new Item("Capuche en tissu+", 2, 30, "Capuche en tissu de qualité supérieur, utilisé pour la fabrication d'armure", "tete");
            i28.AddStats("robustesse", 4);
            i28.AddStats("attaque magique", 6);
            i28.AddRequired("attaque magique", 10);
            listItem.Add(i28);

            Item i29 = new Item("Pentalon en cuir", 3, 8, "Cuir de vache tanné, consu en forme de pentalon", "jambes");
            i29.AddStats("robustesse", 6);
            i29.AddStats("esquive", 3);
            listItem.Add(i29);

            Item i30 = new Item("Pentalon en tissu", 1, 8, "Tissu en laine de mouton, consu en forme de pentalon", "jambes");
            i30.AddStats("robustesse", 4);
            i30.AddStats("attaque magique", 4);
            listItem.Add(i30);

            Item i31 = new Item("Jambière en fer", 7, 12, "Jambière rudimentaire en fer mais efficace", "jambes");
            i31.AddStats("robustesse", 10);
            listItem.Add(i31);

            Item i32 = new Item("jambière de chevalier", 14, 85, "Jambière de très bonne qualité, équipement standard pour la garde royal", "jambes");
            i32.AddStats("robustesse", 22);
            i32.AddRequired("attaque physique", 20);
            listItem.Add(i32);

            Item i33 = new Item("Pentalon en cuir+", 6, 45, "Pentalon en cuir de qualité supérieur, utilisé pour la fabrication d'armure", "jambes");
            i33.AddStats("robustesse", 12);
            i33.AddStats("esquive", 6);
            i33.AddRequired("attaque physique", 10);
            listItem.Add(i33);

            Item i34 = new Item("Pentalon en tissu+", 2, 33, "Pentalon en tissu de qualité supérieur, utilisé pour la fabrication d'armure", "jambes");
            i34.AddStats("robustesse", 8);
            i34.AddStats("attaque magique", 8);
            i34.AddRequired("attaque magique", 10);
            listItem.Add(i34);

            Item i35 = new Item("Tunique en cuir", 4, 12, "Cuir de vache tanné, consu en forme de tunique", "corps");
            i35.AddStats("robustesse", 8);
            i35.AddStats("esquive", 5);
            listItem.Add(i35);

            Item i36 = new Item("Robe en tissu", 2, 12, "Tissu en laine de mouton, consu en forme de robe", "corps");
            i36.AddStats("robustesse", 4);
            i36.AddStats("attaque magique", 6);
            listItem.Add(i36);

            Item i37 = new Item("Armure en fer", 10, 20, "Quelques plaques de fer attachées les unes aux autres servant d'armure", "corps");
            i37.AddStats("robustesse", 13);
            listItem.Add(i37);

            Item i38 = new Item("Armure de chevalier", 20, 120, "Armure de très bonne qualité, équipement standard pour la garde royal", "corps");
            i38.AddStats("robustesse", 30);
            i38.AddRequired("attaque physique", 20);
            listItem.Add(i38);

            Item i39 = new Item("Tunique en cuir+", 7, 55, "Tunique en cuir de qualité supérieur, utilisé pour la fabrication d'armure", "corps");
            i39.AddStats("robustesse", 16);
            i39.AddStats("esquive", 10);
            i39.AddRequired("attaque physique", 10);
            listItem.Add(i39);

            Item i40 = new Item("Robe en tissu+", 3, 47, "Robe en tissu de qualité supérieur, utilisé pour la fabrication d'armure", "corps");
            i40.AddStats("robustesse", 8);
            i40.AddStats("attaque magique", 12);
            i40.AddRequired("attaque magique", 10);
            listItem.Add(i40);

            Item i41 = new Item("Anneau de force", 1, 120, "Anneau augmantant la force du proteur", "bijou");
            i41.AddStats("attaque physique", 10);
            listItem.Add(i41);

            Item i42 = new Item("Anneau de discrétion", 1, 120, "Anneau augmentant la discretion et par conséquence, la facilité d'esquive du porteur", "bijou");
            i42.AddStats("esquive", 10);
            listItem.Add(i42);

            Item i43 = new Item("Collier protecteur", 3, 80, "Collier créant une léger révetement protégeant le porteur", "bijou");
            i43.AddStats("robustesse", 8);
            listItem.Add(i43);

            Item i44 = new Item("Anneau cumulatif", 1, 100, "Permet au porteur de récupérer plus rapidement son souffle", "bijou");
            i44.AddStats("fatigue", 10);
            listItem.Add(i44);

            Item i45 = new Item("Brassard curatif", 2, 320, "Accumule de la magie au fil du temps et libère une aura bienfaitrice sur le porteur", "bijou");
            i45.AddStats("vie", 5);
            listItem.Add(i45);

            Item i46 = new Item("Pendentif d'Elric", 3, 750, "Pendentif faisant parti de la collection d'un roi mystique, Elric", "bijou");
            i46.AddStats("attaque physique", 35);
            i46.AddStats("robustesse", 35);
            i46.AddRequired("vie", 100);
            listItem.Add(i46);

            Item i47 = new Item("Potion de soin", 1, 100, "Potion de soin arrêtant les saignements et les infections", "consommable");
            i47.AddStats("vie", 20);
            listItem.Add(i47);

            Item i48 = new Item("Potion revigorante", 1, 80, "Potion rendant la vigueur perdu d'un homme épuisé", "consommable");
            i48.AddStats("fatigue", 25);
            listItem.Add(i48);

            Item i49 = new Item("Elixir de soin", 1, 200, "Version améliorée de la potion de soin", "consommable");
            i49.AddStats("vie", 40);
            listItem.Add(i49);

            Item i50 = new Item("Elixir revigorant", 1, 180, "Version améliorée de la potion revigorante", "consommable");
            i50.AddStats("fatigue", 55);
            listItem.Add(i50);

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/items.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, listItem);
            }
        }
    }
}
