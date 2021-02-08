using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class NotificationGroup
    {
        public int? GroupsId { get; set; }
        public int? NotificationsId { get; set; }

        public virtual Group Groups { get; set; }
        public virtual Notification Notifications { get; set; }
    }
}
