using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TicketStore.Services.Marketing.Models;

namespace TicketStore.Services.Marketing.Services
{
    public interface IBasketChangeEventService
    {
        Task<List<BasketChangeEvent>> GetBasketChangeEvents(DateTime startDate, int max);
    }
}