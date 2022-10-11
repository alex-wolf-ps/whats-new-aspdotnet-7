using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.UI.Services
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrders();
    }
}