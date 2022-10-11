using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.UI.Services
{
    public interface IMenuService
    {
        Task<List<MenuItem>> GetMenuItems();

        List<MenuItem> GetPopularItems();
    }
}
