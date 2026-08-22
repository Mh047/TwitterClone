using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class MentiionNotification : Notification
    {
        public MentiionNotification(Guid mentionByUserId) : base("Mention")
        {
            MentionByUserId = mentionByUserId;
        }

        public Guid MentionByUserId { get; set; }
        public void AddMassege(string message)
        {
            Message = message;
        }

        //public override string DescribeRecord()
        //{
        //    var baseRecord = base.DescribeRecord();
        //    return $"{baseRecord} MentionByUserId: {MentionByUserId}";
        //}
        public override string GetMessage()
        {
            return $"User With ID {MentionByUserId} Mentioned You In A post ";
        }
    }
}
