using Microsoft.AspNetCore.Components.Forms;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.UI.Services
{
    public interface IContactService
    {
        Task PostContact(Contact contact);
        Task PostContact(Contact contact, IReadOnlyList<IBrowserFile> files);
    }
}