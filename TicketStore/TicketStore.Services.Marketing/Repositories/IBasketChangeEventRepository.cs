using System.Threading.Tasks;
using TicketStore.Services.Marketing.Entities;

namespace TicketStore.Services.Marketing.Repositories
{
    public interface IBasketChangeEventRepository
    {
        Task AddBasketChangeEvent(BasketChangeEvent basketChangeEvent);
    }
}