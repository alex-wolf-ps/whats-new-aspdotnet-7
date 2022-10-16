using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WiredBrainCoffee.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Notes { get; set; }
        public int OrderNumber { get; set; }
        public string PromoCode { get; set; }
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();
        public DateTime Created { get; set; }
        public decimal Total
        {
            get
            {
                return Items.Sum(x => x.Price);
            }
        }
    }
}
