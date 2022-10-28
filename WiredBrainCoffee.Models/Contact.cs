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
        [Required]
        public string Name { get; set; }

        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime SubmittedTime { get; set; }
    }
}
