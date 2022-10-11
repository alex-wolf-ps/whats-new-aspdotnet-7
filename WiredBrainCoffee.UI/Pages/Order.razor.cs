using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.UI.Services;
using WiredBrainCoffee.UI.Components;

namespace WiredBrainCoffee.UI.Pages
{
    public partial class Order
    {
        [Inject]
        public IMenuService MenuService { get; set; }

        [Inject]
        public NavigationManager NavManager { get; set; }
        
        [CascadingParameter] 
        public IModalService Modal { get; set; }

        public List<MenuItem> CurrentOrder { get; set; } = new List<MenuItem>();
        public List<MenuItem> FoodMenuItems { get; set; } = new List<MenuItem>();
        public List<MenuItem> CoffeeMenuItems { get; set; } = new List<MenuItem>();
        public decimal OrderTotal { get; set; } = 0;
        public decimal SalesTax { get; set; } = 0.06m;
        public string PromoCode { get; set; } = "";
        public bool IsValidPromoCode { get; set; } = true;

        [Parameter]
        [SupplyParameterFromQuery]
        public string ActiveTab { get; set; }

        private Task OnSelectedTabChanged(string name)
        {
            ActiveTab = name;
            return Task.CompletedTask;
        }

        async Task AddExtras(MenuItem item)
        { 
            item.Extras = new CoffeeExtras();
            var formModal = Modal.Show<CoffeeExtrasModal>("Enhance Your Coffee");
            var result = await formModal.Result;

            if (!result.Cancelled)
            {
                item.Extras = (CoffeeExtras)result.Data;
                AddToOrder(item);
            }
        }

        private void AddToOrder(MenuItem item)
        {
            CurrentOrder.Add(new MenuItem()
            {
                Name = item.Name,
                Id = item.Id,
                Price = item.Price,
                Extras = item.Extras
            });

            OrderTotal += item.Price;
        }

        private void RemoveFromOrder(MenuItem item)
        {
            CurrentOrder.Remove(item);
            OrderTotal -= item.Price;
        }

        private async Task PlaceOrder()
        {
            NavManager.NavigateTo("order-confirmation");
        }

        protected async override Task OnInitializedAsync()
        {
            var menuItems = await MenuService.GetMenuItems();
            
            FoodMenuItems = menuItems.Where(x => x.Category == "Food").ToList();
            CoffeeMenuItems = menuItems.Where(x => x.Category == "Coffee").ToList();
        }
    }
}
