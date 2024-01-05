using NerdStore.Core.Messages;

namespace NerdStore.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublishEvent<T>(T message) where T : Event;
    }
}
