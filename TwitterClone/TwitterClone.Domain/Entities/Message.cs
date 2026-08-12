namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private DateTime _sentAt;

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