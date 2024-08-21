using RMeeting.Domain.DtoDomain;

namespace RMeeting.Domain.UseCase.UseCaseForum;

internal class CreatedForumUseCase(ICreatedForumStorage forumStorage) : ICreatedForumUseCase
{
    private readonly ICreatedForumStorage _forumStorage = forumStorage;

    /// <summary>
    /// Делегирует создание форума в storage
    /// </summary>
    /// <param name="title">Название форума</param>
    /// <param name="cancellationToken">Токен отмены</param>
    public async Task<Forum> ExecuteAsync(string title, CancellationToken cancellationToken) =>
        await _forumStorage.CreateForum(title, cancellationToken);

}
