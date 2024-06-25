using TicketStore.Web.Models.Api;
using System.Collections.Generic;

namespace TicketStore.Web.Models.View
{
    public class OrderViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
    }
}
