using Microsoft.AspNetCore.Http.HttpResults;
using Moq;
using WiredBrainCoffee.MinApi;
using WiredBrainCoffee.MinApi.Services.Interfaces;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Tests
{
    public class OrderTests
    {
        Mock<IOrderService> orderService = new Mock<IOrderService>();

        public OrderTests()
        {
            orderService.Setup(x => x.GetOrders())
                .Returns(new List<Order>() { new Order() { Id = 5 } });
        }

        [Fact]
        public void GetOrdersReturn200Ok()
        {
            var result = OrderEndPoints.GetOrders(orderService.Object);
            Assert.IsType<Ok<List<Order>>>(result);
        }
    }
}