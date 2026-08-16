using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public SystemNotification(Guid SystemNotificationByUser) : base("System Notification")
        {

        }
        public Guid SystemNotificationByUser { get; set; }
    }
}
