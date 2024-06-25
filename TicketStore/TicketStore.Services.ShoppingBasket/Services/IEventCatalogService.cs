using TicketStore.Services.ShoppingBasket.Entities;
using System;
using System.Threading.Tasks;

namespace TicketStore.Services.ShoppingBasket.Services
{
    public interface IEventCatalogService
    {
        Task<Event> GetEvent(Guid id);
    }
}