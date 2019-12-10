using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Weedkend.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Product = new HashSet<Product>();
        }

        public string BrandId { get; set; }

        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
