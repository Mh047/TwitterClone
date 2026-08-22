
namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {

        private Guid _userId;
        private string _content;
        
        public Tweet(string Content) : base(Guid.NewGuid())
        {
            _content = Content;
        }
        public Guid AuthorId
        {
            get { return _userId; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
    }

}
