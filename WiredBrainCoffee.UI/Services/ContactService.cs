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

        public async Task PostContact(Contact contact,
            IReadOnlyList<IBrowserFile> attachedFiles)
        {
            foreach (var file in attachedFiles)
            {
                //var buffer = new byte[file.Size];
                //await file.OpenReadStream().ReadAsync(buffer);

                FormFile fileUpload;

                using (var stream = file.OpenReadStream())
                {
                    fileUpload = new FormFile(stream, 0, stream.Length, "test", file.Name)
                    {
                        Headers = new HeaderDictionary(),
                        ContentType = "image/jpg"
                    };
                }

                contact.AttachedFiles.Add(fileUpload);

                //await using FileStream fs = new(path, FileMode.Create);
                //await browserFile.OpenReadStream().CopyToAsync(fs);

                
            }

            await http.PostAsJsonAsync("contact", contact);
        }
    }
}