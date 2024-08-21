using Microsoft.Extensions.DependencyInjection;
using RMeeting.Domain.UseCase.UseCaseForum;

namespace RMeeting.Domain.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddForumDomain(this IServiceCollection service)
    {
        service
            .AddScoped<ICreatedForumUseCase, CreatedForumUseCase>()
            ;
        return service;
    }
}
