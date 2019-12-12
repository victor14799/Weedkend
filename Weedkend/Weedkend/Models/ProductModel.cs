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
            using (var context = new MyContext())
            {
                Products = context.Set<Product>().ToList();
            }

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
