using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.MinApi.Services.Interfaces
{
    public interface IMenuService
    {
        List<MenuItem> GetMenuItems();
    }
}