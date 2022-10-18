using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.UI.Services;

namespace WiredBrainCoffee.UI.Admin
{
    public partial class OrderHistory
    {
        [Inject]
        public IOrderService OrderService { get; set; }

        List<Order> items = new List<Order>();

        protected override async Task OnInitializedAsync()
        {
            items = await OrderService.GetOrders();
        }
    }
}
