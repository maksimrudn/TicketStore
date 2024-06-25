using AutoMapper;
using TicketStore.Services.Discount.Entities;
using TicketStore.Services.Discount.Models;

namespace TicketStore.Services.Discount.Profiles
{
    public class CouponProfile : Profile
    {
        public CouponProfile()
        {
            CreateMap<Coupon, CouponDto>().ReverseMap();
        }
    }
}
