using System;
using System.Collections.Generic;

namespace Weedkend.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Product = new HashSet<Product>();
        }

        public string BrandId { get; set; }
        public string BrandName { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
