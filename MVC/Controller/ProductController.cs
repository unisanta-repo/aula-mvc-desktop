using MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controller
{
    internal class ProductController
    {
        private ProductModel model = new ProductModel();

        public string SaveProduct(String name, string price)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(price))
            {
                return "Nome e Preço são obrigatórios!";
            }
            if (!decimal.TryParse(price, out decimal priceConvert))
            {
                return "Preço Inválido!";
            }

            Product product = new Product(name, priceConvert);
            model.addProduct(product);
            return "Produto salvo com sucesso!";
        }
        public List<Product> GetAllProducts()
        {
            return model.GetProducts();
        }

    }
}
