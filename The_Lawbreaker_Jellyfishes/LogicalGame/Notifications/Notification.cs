using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    public class Notification
    {
        readonly string _name;
        readonly string _description;
        readonly DateTime _date;

        internal Notification(string name, string description)
        {
            _name = name;
            _description = description;
            _date = DateTime.Now;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Description
        {
            get { return _description; }
        }

        public DateTime Date
        {
            get { return _date; }
        }
    }
}
