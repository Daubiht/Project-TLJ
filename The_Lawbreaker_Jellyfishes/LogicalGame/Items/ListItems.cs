using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LogicalGame
{
    public class ListItems
    {
        readonly List<Item> _listitems = new List<Item>();

        public ListItems()
        {
            using (TextReader tr = new StreamReader(@"../../../listItems.txt"))
            {
                string line;
                while ((line = tr.ReadLine()) != null)
                {
                    if (line[0] != '*')
                    {
                        string[] lineSplited = line.Split('|');
                        Item newItem = new Item(lineSplited[0], int.Parse(lineSplited[1]), int.Parse(lineSplited[2]), lineSplited[3], lineSplited[4]);

                        if (lineSplited[5] != "empty")
                        {
                            string[] statSplitted = lineSplited[5].Split('&');
                            for (int i = 0; i < statSplitted.Length; i++, i++)
                            {
                                newItem.AddStats(statSplitted[i + 1], int.Parse(statSplitted[i]));
                            }
                        }

                        if (lineSplited[6] != "empty")
                        {
                            string[] requiredSplitted = lineSplited[6].Split('&');
                            for (int i = 0; i < requiredSplitted.Length; i++, i++)
                            {
                                newItem.AddRequired(requiredSplitted[i + 1], int.Parse(requiredSplitted[i]));
                            }
                        }
                        _listitems.Add(newItem);
                    }
                }
            }
        }

        public List<Item> GetItems
        {
            get { return _listitems; }
        }
    }
}
