using TicketStore.Web.Models.Api;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TicketStore.Web.Services
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrdersForUser(Guid userId);
        Task<Order> GetOrderDetails(Guid orderId);
    }
}
