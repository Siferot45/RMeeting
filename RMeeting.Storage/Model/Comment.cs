using System.ComponentModel.DataAnnotations;

namespace RMeeting.Storage.Model;

public class Comment
{
    public Guid CommentId { get; set; }

    [MaxLength(1000)]
    public string Text { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public Guid TopicId { get; set; }
    public Topic Topic { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public IEnumerable<LikeComment>? LikeComments { get; set; }

    public IEnumerable<CommentsOfComment>? CommentsOfComments { get; set; }
}
