using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame
{
    [Serializable]
    public class ListNotifications
    {
        readonly List<Notification> _listNotif = new List<Notification>();

        public Notification AddNotif(string name, string description)
        {
            Notification newNotif = new Notification(name, description);
            _listNotif.Add(newNotif);

            if (_listNotif.Count == 11) RemoveNotif();

            return newNotif;
        }

        private bool RemoveNotif()
        {
            _listNotif.RemoveAt(0);
            return true;
        }

        public List<Notification> ListNotif
        {
            get { return _listNotif; }
        }
    }
}
