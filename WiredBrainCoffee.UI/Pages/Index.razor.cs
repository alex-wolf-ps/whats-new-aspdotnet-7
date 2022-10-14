using Microsoft.AspNetCore.Components;

namespace WiredBrainCoffee.UI.Pages
{
    public partial class Index
    {
        [Inject]
        public NavigationManager NavManager { get; set; }

        public void ApplyPromo()
        {
            NavManager.NavigateTo("order", 
                new NavigationOptions { HistoryEntryState = "WiredFall" });
        }
    }
}
