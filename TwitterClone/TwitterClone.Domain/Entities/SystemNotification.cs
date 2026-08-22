using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public SystemNotification(Guid systemNotificationByUser) : base("System Notification")
        {
            SystemNotificationByUser = systemNotificationByUser;
        }
        public Guid SystemNotificationByUser { get; set; }

        //public override string DescribeRecord()
        //{
        //    var baseRecord = base.DescribeRecord();
        //    return $"{baseRecord} SystemNotificationByUser: {SystemNotificationByUser}";
        //}

        public override string GetMessage()
        {
            return $"A system notification from {SystemNotificationByUser}";
        }

    }
}
