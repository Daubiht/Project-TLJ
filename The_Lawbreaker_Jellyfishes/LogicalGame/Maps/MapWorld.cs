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
                        if (militia == false)
                        {
                            //Provok event when a change is done
                        }
                        _actualPosition = I;
                        TavernCharactersChange();
                        return true;
                    }
                }
            }
            return false;
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
