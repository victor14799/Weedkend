using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Weedkend.Models
{
    public partial class OrdersDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public Orders Order { get; set; }
        public Product Product { get; set; }
    }
}
