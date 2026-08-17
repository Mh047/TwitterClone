namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;

        public Retweet() : base(Guid.NewGuid())
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
