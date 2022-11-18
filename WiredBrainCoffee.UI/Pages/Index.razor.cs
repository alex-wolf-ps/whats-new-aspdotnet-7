using Microsoft.AspNetCore.Components;

namespace WiredBrainCoffee.UI.Pages
{
    public partial class Index
    {
        [Inject]
        NavigationManager NavManager { get; set; }
        public void ApplyPromo()
        {
            NavManager.NavigateTo("/order", new NavigationOptions()
            {
                HistoryEntryState = "WiredDiscount"
            });
        }
    }
}
