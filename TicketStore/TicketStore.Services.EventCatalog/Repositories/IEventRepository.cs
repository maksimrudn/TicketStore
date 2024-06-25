using System;
using TicketStore.Services.EventCatalog.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TicketStore.Services.EventCatalog.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetEvents(Guid categoryId);
        Task<Event> GetEventById(Guid eventId);
    }
}
