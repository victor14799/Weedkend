using System;
using System.Collections.Generic;

namespace Weedkend.Models
{
    public partial class OrdersDetail
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public Orders Order { get; set; }
        public Product Product { get; set; }
    }
}
