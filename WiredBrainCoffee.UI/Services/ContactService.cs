using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.IO;
using System.Net.Http.Json;
using WiredBrainCoffee.Models;

namespace WiredBrainCoffee.UI.Services
{
    public class ContactService : IContactService
    {
        private readonly HttpClient http;

        public ContactService(HttpClient http)
        {
            this.http = http;
        }

        public async Task PostContact(Contact contact)
        {
            await http.PostAsJsonAsync("contact", contact);
        }
    }
}