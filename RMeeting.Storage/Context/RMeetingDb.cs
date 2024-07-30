using Microsoft.EntityFrameworkCore;
using RMeeting.Storage.Model;

namespace RMeeting.Storage.Context;

public class RMeetingDb(DbContextOptions<RMeetingDb> options) : DbContext(options)
{
    public DbSet<Forum> Forums  { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<LikeComment> LikeComments { get; set; }
    public DbSet<CommentsOfComment> CommentsOfComments { get; set; }
    public DbSet<User> Users { get; set; }
}
