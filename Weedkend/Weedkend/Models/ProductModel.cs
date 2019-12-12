using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weedkend.Models
{
    public class ProductModel
    {
        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>()
            {
                new Product
                {
                    ProductId =new Guid(), ProName="Sửa rửa mặt",Price=10000, 
                },
                new Product
                {
                    ProductId =new Guid(), ProName="Sửa",Price=15000, 
                },new Product
                {
                    ProductId =new Guid(), ProName="Sửa rửa mặt",Price=150000, 
                },new Product
                {
                    ProductId =new Guid(), ProName="Sửa rửa mặt",Price=10000,
                }
            };

        }
        public List<Product> FindAll()
        {
            return Products;
        }

        public Product Find(string guid)
        {
            return Products.Where(p => p.ProductId.ToString() == guid.ToString()).FirstOrDefault();
        }
    }
}
