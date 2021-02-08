using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class Event
    {
        public Event()
        {
            Notifications = new HashSet<Notification>();
        }

        public int Id { get; set; }
        public DateTime Datetime { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
