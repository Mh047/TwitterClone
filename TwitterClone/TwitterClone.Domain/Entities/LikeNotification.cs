using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public LikeNotification(Guid likeByUser) : base("Like")
        {
            LikeByUser = likeByUser;
        }

        public Guid LikeByUser { get; set; }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}Notification Type: {Type}, Message: {Message}, IsRead: {IsRead}, LikeByUserId: {LikeByUser}";
        }
    }
}
