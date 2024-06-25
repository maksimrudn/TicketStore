using AutoMapper;
using TicketStore.Services.ShoppingBasket.Entities;
using TicketStore.Services.ShoppingBasket.Models;

namespace TicketStore.Services.ShoppingBasket.Profiles
{
    public class BasketChangeEventProfile: Profile
    {
        public BasketChangeEventProfile()
        {
            CreateMap<BasketChangeEvent, BasketChangeEventForPublication>().ReverseMap();
        }
    }
}
