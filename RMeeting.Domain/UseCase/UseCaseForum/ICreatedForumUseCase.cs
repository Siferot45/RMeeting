using RMeeting.Domain.DtoDomain;

namespace RMeeting.Domain.UseCase.UseCaseForum;

public interface ICreatedForumUseCase
{
    Task<Forum> ExecuteAsync(string title, CancellationToken cancellationToken);
}
