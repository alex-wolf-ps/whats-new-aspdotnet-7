using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Moq;
using WiredBrainCoffee.MinApi;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.Tests
{
    public class UnitTest1
    {
        Mock<IOrderService> orderService = new Mock<IOrderService>();

        public UnitTest1()
        {
            orderService.Setup(x => x.GetOrders()).Returns(new List<Order>() { new Order() { Id = 5 } });
        }

        [Fact]
        public void GetOrdersReturn200Ok()
        {
            var okResult = (Ok<List<Order>>)OrderEndPoints.GetOrders(orderService.Object);
            Assert.Equal(200, okResult.StatusCode);
        }
    }
}