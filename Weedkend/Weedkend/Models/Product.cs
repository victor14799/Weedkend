using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Weedkend.Models
{
    public partial class Product
    {
        public Product()
        {
            OrdersDetail = new HashSet<OrdersDetail>();
        }

        public Guid ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProName { get; set; }

        [Required]
        [Display(Name = "Product Brand")]
        public string ProBrand { get; set; }

        [Required]
        [Display(Name = "Product Category")]
        public string Category { get; set; }

        [Required]
        [Range(10000, 999999999)]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Image Url")]
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public Category CategoryNavigation { get; set; }
        public Brand ProBrandNavigation { get; set; }
        public ICollection<OrdersDetail> OrdersDetail { get; set; }
    }
}
