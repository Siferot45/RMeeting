
namespace RMeeting.Domain.DtoDomain;

public class Topic
{
    public Guid Id { get; set; }

    public string Title { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public Guid ForumId { get; set; }

    public Guid UserId { get; set; }
}
