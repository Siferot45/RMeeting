
namespace RMeeting.Storage.Abstraction;

internal class MomentProvider : IMomentProvider
{
    public DateTimeOffset Now => DateTimeOffset.UtcNow;
}
