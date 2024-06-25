using System;
using TicketStore.Services.Discount.Entities;
using System.Threading.Tasks;

namespace TicketStore.Services.Discount.Repositories
{
    public interface ICouponRepository
    {
        Task<Coupon> GetCouponByCode(string couponCode);
        Task UseCoupon(Guid couponId);
        Task<Coupon> GetCouponById(Guid couponId);
    }
}
