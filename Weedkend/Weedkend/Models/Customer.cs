using System;
using System.Collections.Generic;

namespace Weedkend.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public Guid CustomerId { get; set; }
        public string FullName { get; set; }
        public string ShipAddress { get; set; }
        public string PhoneNo { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
