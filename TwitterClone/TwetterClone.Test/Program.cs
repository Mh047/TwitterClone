
using TwitterClone.Domain.Entities;


var notification = new List<Notification>
{
    new LikeNotification(Guid.NewGuid()),
    new FriendRequestNotification(Guid.NewGuid()),
    new MentiionNotification(Guid.NewGuid()),
    new CommentNotification(Guid.NewGuid()),
    new SystemNotification(Guid.NewGuid()),

};

foreach (var n in notification)
{
    Console.WriteLine(n.GetMessage());
}