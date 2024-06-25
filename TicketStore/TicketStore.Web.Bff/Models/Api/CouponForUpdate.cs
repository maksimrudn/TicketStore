using System;
using System.ComponentModel.DataAnnotations;

namespace TicketStore.Web.Models.Api
{
    public class CouponForUpdate
    {
        [Required]
        public Guid CouponId { get; set; }
    }
}
