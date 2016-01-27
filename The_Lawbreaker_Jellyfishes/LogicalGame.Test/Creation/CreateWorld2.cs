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
            //The World
            MapWorld world = new MapWorld();
            world.Team.World = world;
            Dictionary<string, MapIsland> Islands = new Dictionary<string, MapIsland>();

            //island 1 ------------------------------------------------------------
            MapIsland island = new MapIsland(world, "Poniénne");
            island.PointX = 150;
            island.PointY = -100;

            //Instance for the Island
            MapInstance instance1 = new MapInstance(island, "Bois polaire", false);
            instance1.PointX = 0;
            instance1.PointY = 0;

            //list zone for instance on the island
            List<MapZone> listZone_instance1 = new List<MapZone>();
            MapZone zone1 = new MapZone(instance1, true, 1);
            zone1.PointX = 0;
            zone1.PointY = 0;

            MapZone zone2 = new MapZone(instance1, true, 2);
            zone2.PointX = 100;
            zone2.PointY = 0;

            MapZone zone3 = new MapZone(instance1, true, 2);
            zone3.PointX = 200;
            zone3.PointY = 0;

            MapZone zone4 = new MapZone(instance1, true, 2);
            zone4.PointX = 300;
            zone4.PointY = 0;

            List<MapZone> listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone1);
            listlink.Add(zone3);
            zone2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            listlink.Add(zone4);
            zone3.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3);
            zone4.ListLink = listlink;

            //Zone must be add like : first is the entry and last the exit
            listZone_instance1.Add(zone1);
            listZone_instance1.Add(zone2);
            listZone_instance1.Add(zone3);
            listZone_instance1.Add(zone4);

            instance1.listZones = listZone_instance1;

            MapInstance instance2 = new MapInstance(island, "Carverne écailleuse", false);
            instance2.PointX = 100;
            instance2.PointY = 0;

            //list zone for instance on the island
            List<MapZone> listZone_instance2 = new List<MapZone>();
            zone1 = new MapZone(instance2, true, 1);
            zone1.PointX = 0;
            zone1.PointY = 0;

            zone2 = new MapZone(instance2, true, 1);
            zone2.PointX = 100;
            zone2.PointY = 0;

            zone3 = new MapZone(instance2, true, 2);
            zone3.PointX = 200;
            zone3.PointY = 0;

            MapZone zone3_1 = new MapZone(instance2, true, 2);
            zone3_1.PointX = 200;
            zone3_1.PointY = 100;

            zone4 = new MapZone(instance2, true, 1);
            zone4.PointX = 300;
            zone4.PointY = 0;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone1);
            listlink.Add(zone3);
            zone2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            listlink.Add(zone3_1);
            listlink.Add(zone4);
            zone3.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3);
            zone3_1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3);
            zone4.ListLink = listlink;

            //Zone must be add like : first is the entry and last the exit
            listZone_instance2.Add(zone1);
            listZone_instance2.Add(zone2);
            listZone_instance2.Add(zone3);
            listZone_instance2.Add(zone3_1);
            listZone_instance2.Add(zone4);

            instance2.listZones = listZone_instance2;

            //Instance for the Island
            MapInstance instance3 = new MapInstance(island, "Ancien mégalithe", false);
            instance3.PointX = 200;
            instance3.PointY = 0;

            //list zone for instance on the island
            List<MapZone> listZone_instance3 = new List<MapZone>();
            zone1 = new MapZone(instance3, true, 1);
            zone1.PointX = 0;
            zone1.PointY = 0;

            zone2 = new MapZone(instance3, true, 2);
            zone2.PointX = 100;
            zone2.PointY = 0;

            MapZone zone2_1 = new MapZone(instance3, true, 3);
            zone2_1.PointX = 100;
            zone2_1.PointY = 100;

            zone3 = new MapZone(instance3, true, 3);
            zone3.PointX = 200;
            zone3.PointY = 0;

            zone3_1 = new MapZone(instance3, true, 1);
            zone3_1.PointX = 200;
            zone3_1.PointY = 100;

            zone4 = new MapZone(instance3, true, 1);
            zone4.PointX = 300;
            zone4.PointY = 0;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone1);
            listlink.Add(zone2_1);
            listlink.Add(zone3);
            zone2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone2_1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            listlink.Add(zone3_1);
            listlink.Add(zone4);
            zone3.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3);
            zone3_1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3);
            zone4.ListLink = listlink;

            //Zone must be add like : first is the entry and last the exit
            listZone_instance3.Add(zone1);
            listZone_instance3.Add(zone2);
            listZone_instance3.Add(zone2_1);
            listZone_instance3.Add(zone3);
            listZone_instance3.Add(zone3_1);
            listZone_instance3.Add(zone4);

            instance3.listZones = listZone_instance3;

            List<MapInstance> listinstances = new List<MapInstance>();
            listinstances.Add(instance1);
            listinstances.Add(instance2);
            listinstances.Add(instance3);
            island.IslandInstances = listinstances;

            //city for the island
            MapCity city = new MapCity(island, "Ponyo");
            city.PointX = 300;
            city.PointY = 0;
            island.AddCity(city);

            //list sellable items for merchant and merch
            ListItems listI = new ListItems();

            List<Item> itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Dague en bois" || I.GetName == "Bandage" || I.GetName == "Potion de soin" || I.GetName == "Potion revigorante";
                });

            Merchant merch1 = new Merchant("Vendeur général", itemsSell);
            merch1.PointX = 0;
            merch1.PointY = 0;
            merch1.Invent = world.Team.Invent;

            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Bandage" || I.GetName == "Poils animals" || I.GetName == "Potion de soin" || I.GetName == "Potion revigorante" || I.GetName == "Elixir de soin" || I.GetName == "Elixir revigorant" || I.GetName == "Ecorce elfique";
                });

            Merchant merch2 = new Merchant("herboriste", itemsSell);
            merch2.PointX = 0;
            merch2.PointY = 100;
            merch2.Invent = world.Team.Invent;

            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Dague en bois" || I.GetName == "Dague en fer" || I.GetName == "Boublier" || I.GetName == "Bouclier de gladiateur" || I.GetName == "Epée en bois" || I.GetName == "Cimeterre" || I.GetName == "Casque en fer" || I.GetName == "Jambière en fer" || I.GetName == "Armure en fer";
                });

            Merchant merch3 = new Merchant("Forgeron", itemsSell);
            merch3.PointX = 0;
            merch3.PointY = 200;
            merch3.Invent = world.Team.Invent;

            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Capuche en cuir" || I.GetName == "Capuche en tissu" || I.GetName == "Pentalon en cuir" || I.GetName == "Pentalon en tissu" || I.GetName == "Tunique en cuir" || I.GetName == "Robe en tissu";
                });

            Merchant merch4 = new Merchant("Tailleur/cordonnier", itemsSell);
            merch4.PointX = 0;
            merch4.PointY = 300;
            merch4.Invent = world.Team.Invent;

            //Add services
            Mortuary s1 = new Mortuary(city);
            s1.PointX = 100;
            s1.PointY = 100;

            Taverne s2 = new Taverne();
            s2.PointX = 100;
            s2.PointY = 200;

            Militia s3 = new Militia(city);
            s3.PointX = 100;
            s3.PointY = 300;

            //list merchant for city
            List<object> listservices = new List<object>();
            listservices.Add(merch1);
            listservices.Add(merch2);
            listservices.Add(merch3);
            listservices.Add(merch4);
            listservices.Add(s1);
            listservices.Add(s2);
            listservices.Add(s3);
            city.Services = listservices;

            //add island to world
            Islands.Add("Poniénne", island);

            //island 2 ------------------------------------------------------------
            island = new MapIsland(world, "Belegaer");
            island.PointX = 50;
            island.PointY = 290;

            //Instance for the Island
            instance1 = new MapInstance(island, "Oasis des rois", false);
            instance1.PointX = 0;
            instance1.PointY = 0;

            //list zone for instance on the island
            listZone_instance1 = new List<MapZone>();
            zone1 = new MapZone(instance1, true, 1);
            zone1.PointX = 0;
            zone1.PointY = 50;

            zone2 = new MapZone(instance1, true, 1);
            zone2.PointX = 0;
            zone2.PointY = 100;

            zone3 = new MapZone(instance1, true, 1);
            zone3.PointX = 0;
            zone3.PointY = 150;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone1);
            listlink.Add(zone3);
            zone2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone3.ListLink = listlink;

            listZone_instance1.Add(zone1);
            listZone_instance1.Add(zone2);
            listZone_instance1.Add(zone3);

            instance1.listZones = listZone_instance1;

            //Instance for the Island
            instance2 = new MapInstance(island, "Grotte abrasive", false);
            instance2.PointX = 0;
            instance2.PointY = 50;

            //list zone for instance on the island
            listZone_instance2 = new List<MapZone>();
            zone1 = new MapZone(instance2, true, 1);
            zone1.PointX = 0;
            zone1.PointY = 0;

            zone2 = new MapZone(instance2, true, 1);
            zone2.PointX = 0;
            zone2.PointY = 100;

            zone2_1 = new MapZone(instance2, true, 1);
            zone2_1.PointX = 50;
            zone2_1.PointY = 100;

            zone3 = new MapZone(instance2, true, 1);
            zone3.PointX = 0;
            zone3.PointY = 150;

            zone3_1 = new MapZone(instance2, true, 1);
            zone3_1.PointX = 50;
            zone3_1.PointY = 150;

            MapZone zone3_2 = new MapZone(instance2, true, 1);
            zone3_2.PointX = 100;
            zone3_2.PointY = 150;

            zone4 = new MapZone(instance2, true, 1);
            zone4.PointX = 0;
            zone4.PointY = 200;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone1);
            listlink.Add(zone2_1);
            listlink.Add(zone3);
            zone2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            listlink.Add(zone3_2);
            zone2_1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            listlink.Add(zone3_1);
            zone3.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3);
            listlink.Add(zone3_2);
            zone3_1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3_1);
            listlink.Add(zone2_1);
            listlink.Add(zone4);
            zone3_2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3_1);
            zone4.ListLink = listlink;

            listZone_instance2.Add(zone1);
            listZone_instance2.Add(zone2);
            listZone_instance2.Add(zone2_1);
            listZone_instance2.Add(zone3);
            listZone_instance2.Add(zone3_1);
            listZone_instance2.Add(zone3_2);
            listZone_instance2.Add(zone4);

            instance2.listZones = listZone_instance2;

            listinstances = new List<MapInstance>();
            listinstances.Add(instance1);
            listinstances.Add(instance2);
            island.IslandInstances = listinstances;

            //city for the island
            city = new MapCity(island, "Genefort");
            city.PointX = 0;
            city.PointY = 0;
            island.AddCity(city);

            //list sellable items for merchant and merch
            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Dague en bois" || I.GetName == "Bandage" || I.GetName == "Potion de soin" || I.GetName == "Potion revigorante";
                });

            merch1 = new Merchant("Vendeur général", itemsSell);
            merch1.PointX = 50;
            merch1.PointY = 50;
            merch1.Invent = world.Team.Invent;

            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Bandage" || I.GetName == "Poils animals" || I.GetName == "Potion de soin" || I.GetName == "Potion revigorante" || I.GetName == "Elixir de soin" || I.GetName == "Elixir revigorant" || I.GetName == "Ecorce elfique";
                });

            merch2 = new Merchant("herboriste", itemsSell);
            merch2.PointX = 100;
            merch2.PointY = 50;
            merch2.Invent = world.Team.Invent;

            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Armure de chevalier" || I.GetName == "jambière de chevalier" || I.GetName == "Casque de chevalier" || I.GetName == "Glaive" || I.GetName == "Bouclier du feu follé" || I.GetName == "Dague incinéreuse" || I.GetName == "Dague en bois" || I.GetName == "Dague en fer" || I.GetName == "Boublier" || I.GetName == "Bouclier de gladiateur" || I.GetName == "Epée en bois" || I.GetName == "Cimeterre" || I.GetName == "Casque en fer" || I.GetName == "Jambière en fer" || I.GetName == "Armure en fer";
                });

            merch3 = new Merchant("Forgeron", itemsSell);
            merch3.PointX = 150;
            merch3.PointY = 50;
            merch3.Invent = world.Team.Invent;

            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Capuche en cuir" || I.GetName == "Capuche en tissu" || I.GetName == "Pentalon en cuir" || I.GetName == "Pentalon en tissu" || I.GetName == "Tunique en cuir" || I.GetName == "Robe en tissu";
                });

            merch4 = new Merchant("Tailleur/cordonnier", itemsSell);
            merch4.PointX = 200;
            merch4.PointY = 50;
            merch4.Invent = world.Team.Invent;

            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Anneau de force" || I.GetName == "Anneau de discrétion";
                });

            Merchant merch5 = new Merchant("Bijoutier", itemsSell);
            merch5.PointX = 250;
            merch5.PointY = 50;
            merch5.Invent = world.Team.Invent;

            //Add services
            s1 = new Mortuary(city);
            s1.PointX = 50;
            s1.PointY = 100;

            s2 = new Taverne();
            s2.PointX = 100;
            s2.PointY = 100;

            //list merchant for city
            listservices = new List<object>();
            listservices.Add(merch1);
            listservices.Add(merch2);
            listservices.Add(merch3);
            listservices.Add(merch4);
            listservices.Add(merch5);
            listservices.Add(s1);
            listservices.Add(s2);
            city.Services = listservices;

            //add island to world
            Islands.Add("Belegaer", island);

            //island 3 ------------------------------------------------------------
            island = new MapIsland(world, "Finebaie");
            island.PointX = 500;
            island.PointY = 400;

            //Instance for the Island
            instance1 = new MapInstance(island, "Forêt désolée", false);
            instance1.PointX = 0;
            instance1.PointY = 0;

            //list zone for instance on the island
            listZone_instance1 = new List<MapZone>();
            zone1 = new MapZone(instance1, true, 1);
            zone1.PointX = 0;
            zone1.PointY = 50;

            zone2 = new MapZone(instance1, true, 1);
            zone2.PointX = 0;
            zone2.PointY = 100;

            zone2_1 = new MapZone(instance1, true, 1);
            zone2_1.PointX = 50;
            zone2_1.PointY = 100;

            zone3 = new MapZone(instance1, true, 1);
            zone3.PointX = 0;
            zone3.PointY = 150;

            zone4 = new MapZone(instance1, true, 1);
            zone4.PointX = 0;
            zone4.PointY = 200;

            MapZone zone4_1 = new MapZone(instance1, true, 1);
            zone4_1.PointX = 50;
            zone4_1.PointY = 200;

            MapZone zone5 = new MapZone(instance1, true, 1);
            zone5.PointX = 0;
            zone5.PointY = 250;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone1);
            listlink.Add(zone2_1);
            listlink.Add(zone3);
            zone2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone2_1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            listlink.Add(zone4);
            zone3.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3);
            listlink.Add(zone4_1);
            listlink.Add(zone5);
            zone4.ListLink = listlink;

            listZone_instance1.Add(zone1);
            listZone_instance1.Add(zone2);
            listZone_instance1.Add(zone2_1);
            listZone_instance1.Add(zone3);
            listZone_instance1.Add(zone4);
            listZone_instance1.Add(zone4_1);
            listZone_instance1.Add(zone5);

            instance1.listZones = listZone_instance1;

            //Instance for the Island
            instance2 = new MapInstance(island, "Mine infestée", false);
            instance2.PointX = 0;
            instance2.PointY = 50;

            //list zone for instance on the island
            listZone_instance2 = new List<MapZone>();
            zone1 = new MapZone(instance2, true, 1);
            zone1.PointX = 0;
            zone1.PointY = 0;

            zone2 = new MapZone(instance2, true, 1);
            zone2.PointX = 0;
            zone2.PointY = 100;

            zone2_1 = new MapZone(instance2, true, 1);
            zone2_1.PointX = 50;
            zone2_1.PointY = 100;

            MapZone zone2_2 = new MapZone(instance2, true, 1);
            zone2_2.PointX = 100;
            zone2_2.PointY = 100;

            zone3 = new MapZone(instance2, true, 1);
            zone3.PointX = 0;
            zone3.PointY = 150;

            zone3_2 = new MapZone(instance2, true, 1);
            zone3_2.PointX = 100;
            zone3_2.PointY = 150;

            MapZone zone3_3 = new MapZone(instance2, true, 1);
            zone3_3.PointX = 150;
            zone3_3.PointY = 150;

            MapZone zone3_4 = new MapZone(instance2, true, 1);
            zone3_4.PointX = 200;
            zone3_4.PointY = 150;

            zone4 = new MapZone(instance2, true, 1);
            zone4.PointX = 0;
            zone4.PointY = 200;

            zone4_1 = new MapZone(instance2, true, 1);
            zone4_1.PointX = 50;
            zone4_1.PointY = 200;

            MapZone zone4_2 = new MapZone(instance2, true, 1);
            zone4_2.PointX = 100;
            zone4_2.PointY = 200;

            MapZone zone4_3 = new MapZone(instance2, true, 1);
            zone4_3.PointX = 150;
            zone4_3.PointY = 200;

            zone5 = new MapZone(instance2, true, 1);
            zone5.PointX = 0;
            zone5.PointY = 250;

            MapZone zone5_1 = new MapZone(instance2, true, 1);
            zone5_1.PointX = 50;
            zone5_1.PointY = 250;

            MapZone zone5_2 = new MapZone(instance2, true, 1);
            zone5_2.PointX = 100;
            zone5_2.PointY = 250;

            MapZone zone5_3 = new MapZone(instance2, true, 1);
            zone5_3.PointX = 150;
            zone5_3.PointY = 250;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            zone1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone1);
            listlink.Add(zone2_1);
            listlink.Add(zone3);
            zone2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            listlink.Add(zone2_2);
            zone2_1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2_1);
            listlink.Add(zone3_2);
            zone2_2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2);
            listlink.Add(zone4);
            zone3.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone2_2);
            listlink.Add(zone3_3);
            zone3_2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3_2);
            listlink.Add(zone3_4);
            listlink.Add(zone4_3);
            zone3_3.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone3_3);
            zone3_4.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone4_1);
            zone4.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone4);
            listlink.Add(zone5_1);
            zone4_1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone4_3);
            listlink.Add(zone5_3);
            zone4_2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone4_3);
            zone4_3.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone5_1);
            listlink.Add(zone5_1);
            zone5.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone5);
            listlink.Add(zone4_1);
            zone5_1.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone4_2);
            listlink.Add(zone5_3);
            zone5_2.ListLink = listlink;

            listlink = new List<MapZone>();
            listlink.Add(zone5_2);
            zone5_3.ListLink = listlink;

            listZone_instance2.Add(zone1);
            listZone_instance2.Add(zone2);
            listZone_instance2.Add(zone2_1);
            listZone_instance2.Add(zone2_2);
            listZone_instance2.Add(zone3);
            listZone_instance2.Add(zone3_2);
            listZone_instance2.Add(zone3_3);
            listZone_instance2.Add(zone3_4);
            listZone_instance2.Add(zone4);
            listZone_instance2.Add(zone4_1);
            listZone_instance2.Add(zone4_2);
            listZone_instance2.Add(zone4_3);
            listZone_instance2.Add(zone5);
            listZone_instance2.Add(zone5_1);
            listZone_instance2.Add(zone5_2);
            listZone_instance2.Add(zone5_3);

            instance2.listZones = listZone_instance2;

            listinstances = new List<MapInstance>();
            listinstances.Add(instance1);
            listinstances.Add(instance2);
            island.IslandInstances = listinstances;

            //city for the island
            city = new MapCity(island, "Elkia");
            city.PointX = 0;
            city.PointY = 0;
            island.AddCity(city);

            //list sellable items for merchant and merch
            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Dague en bois" || I.GetName == "Bandage" || I.GetName == "Potion de soin" || I.GetName == "Potion revigorante";
                });

            merch1 = new Merchant("Vendeur général", itemsSell);
            merch1.PointX = 50;
            merch1.PointY = 50;
            merch1.Invent = world.Team.Invent;

            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Bandage" || I.GetName == "Poils animals" || I.GetName == "Potion de soin" || I.GetName == "Potion revigorante" || I.GetName == "Elixir de soin" || I.GetName == "Elixir revigorant" || I.GetName == "Ecorce elfique";
                });

            merch2 = new Merchant("herboriste", itemsSell);
            merch2.PointX = 100;
            merch2.PointY = 50;
            merch2.Invent = world.Team.Invent;

            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Armure de chevalier" || I.GetName == "jambière de chevalier" || I.GetName == "Casque de chevalier" || I.GetName == "Glaive" || I.GetName == "Bouclier du feu follé" || I.GetName == "Dague incinéreuse" || I.GetName == "Dague en bois" || I.GetName == "Dague en fer" || I.GetName == "Boublier" || I.GetName == "Bouclier de gladiateur" || I.GetName == "Epée en bois" || I.GetName == "Cimeterre" || I.GetName == "Casque en fer" || I.GetName == "Jambière en fer" || I.GetName == "Armure en fer";
                });

            merch3 = new Merchant("Forgeron", itemsSell);
            merch3.PointX = 150;
            merch3.PointY = 50;
            merch3.Invent = world.Team.Invent;

            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Capuche en cuir" || I.GetName == "Capuche en tissu" || I.GetName == "Pentalon en cuir" || I.GetName == "Pentalon en tissu" || I.GetName == "Tunique en cuir" || I.GetName == "Robe en tissu";
                });

            merch4 = new Merchant("Tailleur/cordonnier", itemsSell);
            merch4.PointX = 200;
            merch4.PointY = 50;
            merch4.Invent = world.Team.Invent;

            itemsSell = listI.Items.FindAll
                (delegate (Item I)
                {
                    return I.GetName == "Anneau de force" || I.GetName == "Anneau de discrétion";
                });

            merch5 = new Merchant("Bijoutier", itemsSell);
            merch5.PointX = 250;
            merch5.PointY = 50;
            merch5.Invent = world.Team.Invent;

            //Add services
            s1 = new Mortuary(city);
            s1.PointX = 50;
            s1.PointY = 100;

            s2 = new Taverne();
            s2.PointX = 100;
            s2.PointY = 100;

            //list merchant for city
            listservices = new List<object>();
            listservices.Add(merch1);
            listservices.Add(merch2);
            listservices.Add(merch3);
            listservices.Add(merch4);
            listservices.Add(merch5);
            listservices.Add(s1);
            listservices.Add(s2);
            city.Services = listservices;

            //add island to world
            Islands.Add("Finebaie", island);

            //End-----------------------------------------------

            //list link between island
            List<MapIsland> listlinkis = new List<MapIsland>();
            listlinkis.Add(Islands["Belegaer"]);
            Islands["Poniénne"].ListLink = listlinkis;

            listlinkis = new List<MapIsland>();
            listlinkis.Add(Islands["Poniénne"]);
            Islands["Belegaer"].ListLink = listlinkis;

            listlinkis = new List<MapIsland>();
            listlinkis.Add(Islands["Belegaer"]);
            Islands["Finebaie"].ListLink = listlinkis;

            //add island to world
            world.Islands = Islands;
            world.ActualPosition = world.Islands["Poniénne"];

            //Serialize
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/NewWorld.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, world);
            }
        }
    }
}
