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

        IQueryable<Order> items = new List<Order>().AsQueryable();

        PaginationState pagination = new PaginationState { ItemsPerPage = 4 };

        string nameFilter = string.Empty;

        IQueryable<Order> FilteredItems => items
            .Where(x => x.LastName.Contains(nameFilter, StringComparison.CurrentCultureIgnoreCase));

        protected override async Task OnInitializedAsync()
        {
            items = (await OrderService.GetOrders()).AsQueryable();
        }
    }
}
