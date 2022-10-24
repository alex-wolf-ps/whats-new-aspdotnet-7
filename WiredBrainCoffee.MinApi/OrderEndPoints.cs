using Microsoft.OpenApi.Models;

namespace WiredBrainCoffee.MinApi
{
    public static class OrderEndPoints
    {
        public static RouteGroupBuilder MapOrderAPI(this RouteGroupBuilder group)
        {
            group.MapGet("/", GetOrders);
            group.MapGet("/", GetOrderById);
            group.MapGet("/", GetOrdersByIds);

            return group;
        }

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
