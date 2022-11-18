using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.UI.Services;
using WiredBrainCoffee.UI.Components;
using Blazored.Modal;

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
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public decimal OrderTotal { get; set; } = 0;
        public decimal SalesTax { get; set; } = 0.06m;
        public string PromoCode { get; set; } = string.Empty;
        public decimal Discount { get; set; } = 0;

        [Parameter]
        [SupplyParameterFromQuery]
        public string ActiveTab { get; set; }

        public string SearchTerm { get; set; } = string.Empty;

        public List<MenuItem> FilteredMenu = new List<MenuItem>();

        public void FilterMenu()
        {
            if (!string.IsNullOrWhiteSpace(SearchTerm))
            {
                FilteredMenu = MenuItems
                .Where(x => x.Name.ToLower().Contains(SearchTerm.ToLower())).ToList();
            } 
            else
            {
                FilteredMenu = new();
            }
        }

        private Task OnSelectedTabChanged(string name)
        {
            ActiveTab = name;
            return Task.CompletedTask;
        }

        void ViewDetails(MenuItem item)
        {
            var parameters = new ModalParameters()
                .Add(nameof(item.Name), item.Name)
                .Add(nameof(item.Description), item.Description)
                .Add(nameof(item.ImageFile), item.ImageFile)
                .Add(nameof(item.Price), item.Price.ToString("c"));

            Modal.Show<DetailsModal>("Details", parameters);
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

        private void PlaceOrder()
        {
            NavManager.NavigateTo("order-confirmation");
        }

        protected async override Task OnInitializedAsync()
        {
            MenuItems = await MenuService.GetMenuItems();
        }
    }
}
