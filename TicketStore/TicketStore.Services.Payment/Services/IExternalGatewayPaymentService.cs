using TicketStore.Services.Payment.Model;
using System.Threading.Tasks;

namespace TicketStore.Services.Payment.Services
{
    public interface IExternalGatewayPaymentService
    {
        Task<bool> PerformPayment(PaymentInfo paymentInfo);
    }
}
