using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
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

            orderService.Setup(x => x.GetOrderById(It.IsAny<int>()))
                .Returns(new Order() { Id = 5 });
        }

        [Fact]
        public void GetOrdersReturnsOk()
        {
            // Simple test
            var result = OrderEndPoints.GetOrders(orderService.Object);
            Assert.IsType<Ok<List<Order>>>(result);
        }

        [Fact]
        public void GetOrderByIdReturnsOk()
        {
            // Another testing variation
            var result = (Ok<Order>)OrderEndPoints.GetOrderById(orderService.Object, 3);
            Assert.Equal(200, result.StatusCode);
            Assert.IsAssignableFrom<Order>(result.Value);
        }
    }
}