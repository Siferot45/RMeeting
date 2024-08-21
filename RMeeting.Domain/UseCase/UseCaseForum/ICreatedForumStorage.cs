using RMeeting.Domain.DtoDomain;

namespace RMeeting.Domain.UseCase.UseCaseForum;

public interface ICreatedForumStorage
{
    Task<Forum> CreateForum(string title, CancellationToken cancellationToken);
}
