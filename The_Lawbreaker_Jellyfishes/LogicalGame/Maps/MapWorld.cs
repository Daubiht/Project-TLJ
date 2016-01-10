using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame
{
    /// <summary>
    /// Repertory each islands and reachable islands
    /// Need to fill it with a file that contains every islands
    /// </summary>
    [Serializable]
    public class MapWorld
    {
        Dictionary<string, MapIsland> _islands = new Dictionary<string, MapIsland>();
        object _actualPosition;
        Team _team = new Team("team1");
        ListNotifications _notifs = new ListNotifications();
        Random _rand = new Random();
        List<Character> _tavernCharacters = new List<Character>();

        public object ActualPosition
        {
            get { return _actualPosition; }
            set { _actualPosition = value; }
        }

        public List<Character> TavernCharacters
        {
            get { return _tavernCharacters; }
            set { _tavernCharacters = value; }
        }

        public List<Character> TavernCharactersChange()
        {
            int newCharacterNumber = _rand.Next(2, 5);
            Taverne rc = new Taverne();

            _tavernCharacters = new List<Character>();
            for (int i = 0; i < newCharacterNumber; i++)
            {
                _tavernCharacters.Add(rc.New(1, 10, this));
            }

            return _tavernCharacters;
        }

        public bool ChangeActualIsland(MapIsland I, bool militia)
        {
            if (((MapIsland)_actualPosition).IslandName != I.IslandName)
            {
                for (int i = 0; i < I.ListLink.Count; i++)
                {
                    if (((MapIsland)_actualPosition).IslandName == I.ListLink[i].IslandName)
                    {
                        if (militia)
                        {
                            _actualPosition = I;
                        }
                        return true;
                    }
                }
            }
            return false;
        }

        public MapInstance CreateRandomInstance(MapIsland Island)
        {
            //Instance for the Island
            MapInstance instanceB = new MapInstance(Island, "instanceBetweenIsland", true);

            //list zone for instance on the island
            List<MapZone> listZone_instanceB = new List<MapZone>();

            int nbrZone;
            int zoneLevel;
            if(Island.IslandName == "island1")
            {
                nbrZone = _rand.Next(3, 5);
                zoneLevel = 3;
            }
            else
            {
                nbrZone = _rand.Next(2, 4);
                zoneLevel = 1;
            }

            MapZone zone;
            for (int i = 1; i < nbrZone +1; i++)
            {
                zone = new MapZone(instanceB, true, zoneLevel);
                zone.PointX = 175;
                zone.PointY = i * 50;
                listZone_instanceB.Add(zone);
            }

            List<MapZone> listlink = new List<MapZone>();
            for (int i = 0; i < listZone_instanceB.Count; i++)
            {
                listlink = new List<MapZone>();
                if(i == 0)
                {
                    listlink.Add(listZone_instanceB[i + 1]);
                }
                else if(i == listZone_instanceB.Count - 1)
                {
                    listlink.Add(listZone_instanceB[i - 1]);
                }
                else
                {
                    listlink.Add(listZone_instanceB[i - 1]);
                    listlink.Add(listZone_instanceB[i + 1]);
                }
                listZone_instanceB[i].ListLink = listlink;
            }

            instanceB.listZones = listZone_instanceB;
            return instanceB;
        }

        public ListNotifications Notifs
        {
            get { return _notifs; }
        }

        public Dictionary<string, MapIsland> Islands
        {
            get { return _islands; }
            set
            {
                _islands = value;
                _actualPosition = _islands["island1"];
            }
        }

        public Random Random
        {
            get { return _rand; }
        }

        public bool Save(int nbrSlot)
        {
            string path = @"../../../Saves/"+nbrSlot+" - "+_team.MainCharacter.Name+".save";

            string[] fileName = Directory.GetFiles(@"../../../Saves");
            for (int i = 0; i < fileName.Length; i++)
            {
                fileName[i] = fileName[i].Substring(15);
                if ((int)Char.GetNumericValue(fileName[i][0]) == nbrSlot && _team.MainCharacter.Name != fileName[i].Substring(4, fileName[i].Length - 9))
                {
                    File.Delete(@"../../../Saves/"+fileName[i]);
                }
            }

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, this);
            }
            return true;
        }

        public Team Team
        {
            get { return _team; }
        }
    }
}
