namespace RMeeting.Storage.Abstraction;

internal interface IMomentProvider
{
    DateTimeOffset Now { get; }
}
