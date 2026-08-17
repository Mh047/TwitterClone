using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public FriendRequestNotification(Guid FriendRequestByUser) : base("Friend Request")
        {

        }
        public Guid FriendRequestByUser { get; set; }
    }
}
