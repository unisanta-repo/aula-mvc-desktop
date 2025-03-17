using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    internal class ProductModel
    {
        private static List<Product> products = new List<Product>();
        public void addProduct(Product product)
        {
            products.Add(product);
        }
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
