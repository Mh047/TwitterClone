namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private DateTime _sentAt;

        public Message() : base(Guid.NewGuid())
        {

        }
        public Guid SenderId
        {
            get { return _senderId; }
        }

        public Guid ReceiverId
        {
            get { return _receiverId; }
        }

        public string Content
        {
            get { return _content; }
        }

        public DateTime SentAt
        {
            get { return _sentAt; }
        }
    }
}