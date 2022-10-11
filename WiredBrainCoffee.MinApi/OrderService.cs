using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.MinApi
{
    public class OrderService : IOrderService
    {
        private OrderDbContext _context;

        public OrderService(OrderDbContext context)
        {
            _context = context;
        }

        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(x => x.Id == id);
        }

        public Order AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();

            return order;
        }

        public void UpdateOrder(int id, Order newOrder)
        {
            var order = _context.Orders.FirstOrDefault(x => x.Id == id);

            order.Notes = newOrder.Notes;
            order.PromoCode = newOrder.PromoCode;
            order.OrderNumber = newOrder.OrderNumber;
            _context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(x => x.Id == id);
            _context.Orders.Remove(order);

            _context.SaveChanges();
        }
    }

    public interface IOrderService
    {
        Order AddOrder(Order order);
        void DeleteOrder(int id);
        Order GetOrderById(int id);
        List<Order> GetOrders();
        void UpdateOrder(int id, Order newOrder);
    }
}
