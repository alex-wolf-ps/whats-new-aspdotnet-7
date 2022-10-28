using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.MinApi.Services.Interfaces
{
    public interface IOrderService
    {
        Order AddOrder(Order order);
        void DeleteOrder(int id);
        Order GetOrderById(int id);
        List<Order> GetOrders();
        void UpdateOrder(int id, Order newOrder);
    }
}
