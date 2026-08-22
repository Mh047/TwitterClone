namespace TwitterClone.Domain.Entities
{
    public class Bookmark : BaseEntity
    {
        public Bookmark() : base(Guid.NewGuid())
        {

        }

        private Guid _userId;
        private Guid _tweetId;


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