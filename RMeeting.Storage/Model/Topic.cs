using System.ComponentModel.DataAnnotations;

namespace RMeeting.Storage.Model;

public class Topic
{
    public Guid TopicId { get; set; }

    [MaxLength(200)]
    public string Title { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdateAt { get; set; }

    public Guid SectionId { get; set; }
    public Section Section { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public IEnumerable<Comment>? Comments { get; set; }
}
