using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Weedkend.Models
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public string CategoryId { get; set; }

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
