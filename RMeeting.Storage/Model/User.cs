namespace RMeeting.Storage.Model;

public class User
{
    public Guid UserId { get; set; }

    public string Login { get; set; }

    public IEnumerable<Comment> Comments { get; set; }

    public IEnumerable<LikeComment> LikeComments { get; set; }

    public IEnumerable<CommentsOfComment> CommentsOfComments { get; set; }
}
