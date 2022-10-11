using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Http;

namespace WiredBrainCoffee.Models
{
    public class Contact
    {
        public string PartnerId { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public DateTime SubmittedTime { get; set; }

        public List<IFormFile> AttachedFiles { get; set; } = new List<IFormFile>();
    }
}
