using AutoMapper;
using TicketStore.Services.ShoppingBasket.Messages;
using TicketStore.Services.ShoppingBasket.Models;

namespace TicketStore.Services.ShoppingBasket.Profiles
{
    public class BasketCheckoutProfile: Profile
    {
        public BasketCheckoutProfile()
        {
            CreateMap<BasketCheckout, BasketCheckoutMessage>().ReverseMap();
        }
    }
}
