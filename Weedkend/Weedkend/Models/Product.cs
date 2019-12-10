using System;
using System.Collections.Generic;

namespace Weedkend.Models
{
    public partial class Product
    {
        public Product()
        {
            OrdersDetail = new HashSet<OrdersDetail>();
        }

        public Guid ProductId { get; set; }
        public string ProName { get; set; }
        public string ProBrand { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public Category CategoryNavigation { get; set; }
        public Brand ProBrandNavigation { get; set; }
        public ICollection<OrdersDetail> OrdersDetail { get; set; }
    }
}
