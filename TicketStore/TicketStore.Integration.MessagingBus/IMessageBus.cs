using TicketStore.Integration.Messages;
using System.Threading.Tasks;

namespace TicketStore.Integration.MessagingBus
{
    public interface IMessageBus
    {
        Task PublishMessage (IntegrationBaseMessage message, string topicName);
    }
}
