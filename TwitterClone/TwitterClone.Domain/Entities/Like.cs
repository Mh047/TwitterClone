
namespace TwitterClone.Domain.Entities
{
    public class Like : BaseEntity
    {

        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _likedAt;

        public Like() : base(Guid.NewGuid())
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
