using Microsoft.EntityFrameworkCore;
using RMeeting.Domain.UseCase.UseCaseForum;
using RMeeting.Storage.Abstraction;
using RMeeting.Storage.Context;
using RMeeting.Storage.Model;

namespace RMeeting.Storage.Storages.ForumStorages;
/// <summary>
/// Класс отвечающий за создание форума в БД
/// </summary>
/// <param name="guidFactory">Создание нового Guid</param>
/// <param name="db">Сущности базы данных</param>
internal class CreateForumStorage(IGuidFactory guidFactory, RMeetingDb db) : ICreatedForumStorage
{
    private readonly IGuidFactory _guidFactory = guidFactory;
    private readonly RMeetingDb _db = db;
    /// <summary>
    /// Метод создание форум в БД
    /// </summary>
    /// <param name="title">Название форума</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Domain.DtoDomain.Forum</returns>
    public async Task<Domain.DtoDomain.Forum> CreateForum(string title, CancellationToken cancellationToken)
    {
        var forumId = _guidFactory.Create();

        var forum = new Forum
        {
            ForumId = forumId,
            Title = title,
        };

        await _db.Forums.AddAsync(forum, cancellationToken);
        await _db.SaveChangesAsync(cancellationToken);

        return await _db.Forums
            .Where(f => f.ForumId == forumId)
            .Select(f => new Domain.DtoDomain.Forum
            {
                Id = f.ForumId,
                Title = f.Title
            })
            //Возвращает первый найденный удовлетворяющий элемент
            .FirstAsync(cancellationToken);
    }
}
