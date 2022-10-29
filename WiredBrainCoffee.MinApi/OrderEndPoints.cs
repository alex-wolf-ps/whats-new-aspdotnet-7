using WiredBrainCoffee.MinApi.Services.Interfaces;

namespace WiredBrainCoffee.MinApi
{
    public class OrderEndPoints
    {
        public static IResult GetOrders(IOrderService orderService)
        {
            return TypedResults.Ok(orderService.GetOrders());
        }

        public static IResult GetOrdersByIds(IOrderService orderService, int[] orderIds)
        {
            return TypedResults.Ok(orderService.GetOrders().Where(x => orderIds.Contains(x.Id)));
        }

        public static IResult GetOrderById(IOrderService orderService, int id)
        {
            return TypedResults.Ok(orderService.GetOrderById(id));
        }
    }
}
