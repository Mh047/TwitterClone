namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEntity
    {
        private Guid _id;
        private Guid _followerId;
        private Guid _followingId;
        private DateTime _followedAt;

<<<<<<< HEAD
        public Follow() : base(Guid.NewGuid())
        {

=======
        public Guid Id
        {
            get { return _id; }
>>>>>>> main
        }

        public Guid FollowerId
        {
            get { return _followerId; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
        }

        public DateTime FollowedAt
        {
            get { return _followedAt; }
        }
    }
}
