﻿using AutoMapper;

namespace TicketStore.Services.EventCatalog.Profiles
{
    public class EventProfile: Profile
    {
        public EventProfile()
        {
            CreateMap<Entities.Event, Models.EventDto>()
                .ForMember(dest => dest.CategoryName, opts => opts.MapFrom(src => src.Category.Name));
        }
    }
}
