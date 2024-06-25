using System.ComponentModel.DataAnnotations;

namespace TicketStore.Services.ShoppingBasket.Models
{
    public class BasketLineForUpdate
    {
        [Required]
        public int TicketAmount { get; set; }
    }
}
