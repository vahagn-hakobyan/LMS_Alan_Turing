using System;
using System.Collections.Generic;

#nullable disable

namespace LMS_Alan_Turing.Models
{
    public partial class NotificationUser
    {
        public int? UsersId { get; set; }
        public int? NotificationsId { get; set; }

        public virtual Notification Notifications { get; set; }
        public virtual User Users { get; set; }
    }
}
