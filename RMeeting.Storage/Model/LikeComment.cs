namespace RMeeting.Storage.Model;

public class LikeComment
{
    public Guid LikeId { get; set; }

    public int NumberLike { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public Guid CommentId { get; set; }
    public Comment Comment { get; set; }
}
