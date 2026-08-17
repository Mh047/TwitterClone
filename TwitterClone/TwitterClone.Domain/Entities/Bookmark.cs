namespace TwitterClone.Domain.Entities
{
    public class Bookmark : BaseEntity
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;

        public Bookmark() : base(Guid.NewGuid())
        {

        }


        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }
    }
}
