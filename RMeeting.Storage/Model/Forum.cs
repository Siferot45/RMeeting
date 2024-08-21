using System.ComponentModel.DataAnnotations;

namespace RMeeting.Storage.Model;

public class Forum
{
    public Guid ForumId { get; set; }

    [MaxLength(50)]
    public string Title { get; set; }

    public IEnumerable<Section>? Sections { get; set; }
}
