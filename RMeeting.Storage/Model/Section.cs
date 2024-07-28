using System.ComponentModel.DataAnnotations;

namespace RMeeting.Storage.Model;

public class Section
{
    public Guid SectionId { get; set; }

    [MaxLength(200)]
    public string Title { get; set; }
    
    [MaxLength(2000)]
    public string? Description { get; set; }

    public Guid ForumId { get; set; }
    public Forum Forum { get; set; }

    public IEnumerable<Topic>? Topics { get; set; }
}
