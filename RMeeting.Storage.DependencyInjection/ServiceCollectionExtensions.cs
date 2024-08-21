using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RMeeting.Domain.UseCase.UseCaseForum;
using RMeeting.Storage.Abstraction;
using RMeeting.Storage.Context;
using RMeeting.Storage.Storages.ForumStorages;

namespace RMeeting.Storage.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRMeetingStorage(this IServiceCollection service, string dbConnectionString) =>
        service
        .AddScoped<ICreatedForumStorage, CreateForumStorage>()
        .AddScoped<IGuidFactory, GuidFactory>()
        .AddScoped<IMomentProvider, MomentProvider>()
        .AddDbContext<RMeetingDb>(options =>
        {
            options.UseNpgsql(dbConnectionString);
            options.UseSnakeCaseNamingConvention();
        });
}
