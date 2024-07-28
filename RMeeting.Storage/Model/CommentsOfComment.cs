namespace RMeeting.Storage.Model;

public class CommentsOfComment
{
    public Guid CommentsOfCommentId { get; set; }

    public string Text { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public Guid CommentId { get; set; }
    public Comment Comment { get; set; }
}
