using System;
using TicketStore.Integration.Messages;

namespace TicketStore.Services.Payment.Messages
{
    public class OrderPaymentUpdateMessage: IntegrationBaseMessage
    {
        public Guid OrderId { get; set; }
        public bool PaymentSuccess { get; set; }
    }
}
