
namespace RMeeting.Storage.Abstraction;

internal class GuidFactory : IGuidFactory
{
    public Guid Create() => Guid.NewGuid();

}
