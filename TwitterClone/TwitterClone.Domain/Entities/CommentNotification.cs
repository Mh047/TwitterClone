using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public CommentNotification(Guid commentByUser) : base("Comment")
        {
            CommentByUser = commentByUser;
        }
        public Guid CommentByUser {  get; set; }

        //public override string DescribeRecord()
        //{
        //    var baseRecord = base.DescribeRecord();
        //    return $"{baseRecord} CommentByUser: {CommentByUser}";
        //}

        public override string GetMessage()
        {
            return $"User With ID {CommentByUser} Commented on Your Post";
        }

    }
}
