using System;
using System.Collections.Generic;

namespace Weedkend.Models
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
