using System.Net.Http.Json;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.UI.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient http;

        public MenuService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<MenuItem>> GetMenuItems()
        {
            var menuItems = await http.GetFromJsonAsync<MenuItem[]>("menu");
            return menuItems.ToList();
        }

        public List<MenuItem> GetPopularItems()
        {
            return new List<MenuItem>()
            {
                new MenuItem()
                {
                    Name = "Mocha Latte",
                    ShortDescription = "Half coffee, half treat - the perfect combo."
                },
                new MenuItem()
                {
                    Name = "Raspberry Coffee",
                    ShortDescription = "A fresh blend with a refreshing taste"
                },
                new MenuItem()
                {
                    Name = "Peppermint Hot Chocolate",
                    ShortDescription = "So good, you'll be glad it's cold outside."
                },
                new MenuItem()
                {
                    Name = "Green Tea",
                    ShortDescription = "It's classic for a reason"
                }
            };
        }
    }
}
