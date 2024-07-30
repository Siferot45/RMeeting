using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RMeeting.Storage.Context;


namespace RMeeting.Storage.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRMeetingStorage(this IServiceCollection service, string dbConnectionString) =>
        service
        .AddDbContextPool<RMeetingDb>(options =>
        {
            options.UseNpgsql(dbConnectionString);
            options.UseSnakeCaseNamingConvention();
        });
}
