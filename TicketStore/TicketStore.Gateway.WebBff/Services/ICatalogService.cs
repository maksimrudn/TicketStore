﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TicketStore.Gateway.Shared.Event;

namespace TicketStore.Gateway.WebBff.Services
{
    public interface ICatalogService
    {
        Task<List<EventDto>> GetEventsPerCategory(Guid categoryId);
        Task<EventDto> GetEventById(Guid eventId);

        Task<List<CategoryDto>> GetAllCategories();
        Task<List<EventDto>> GetAllEvents();
    }
}