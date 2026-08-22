using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public FriendRequestNotification(Guid friendRequestByUser) : base("Friend Request")
        {
            FriendRequestByUser = friendRequestByUser;
        }
        public Guid FriendRequestByUser { get; set; }

        //public override string DescribeRecord()
        //{
        //    var baseRecord = base.DescribeRecord();
        //    return $"{baseRecord} FriendRequestByUser: {FriendRequestByUser}";
        //}

        public override string GetMessage()
        {
            return $"User With ID {FriendRequestByUser} Sent You A Friend Request";
        }

    }

   
}
