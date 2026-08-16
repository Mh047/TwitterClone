namespace TwitterClone.Domain.Entities
{
    public class Bookmark : BaseEntity
    {
<<<<<<< HEAD
        public Bookmark() : base(Guid.NewGuid())
        {

        }

=======
        private Guid _id;
>>>>>>> main
        private Guid _userId;
        private Guid _tweetId;


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
