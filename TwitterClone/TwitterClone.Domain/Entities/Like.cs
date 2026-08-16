
namespace TwitterClone.Domain.Entities
{
    public class Like : BaseEntity
    {
<<<<<<< HEAD
        public Like() : base(Guid.NewGuid())
        {

        }

        private Guid _userId;
        private Guid _tweetId;


=======
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _likedAt;

        public Guid Id
        {
            get { return _id; }
        }
        
>>>>>>> main
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
