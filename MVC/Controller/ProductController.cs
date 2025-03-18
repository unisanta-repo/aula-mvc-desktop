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

        public string SaveProduct(String name, string price, string quantidade, string descricao)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(descricao))
            {
                return "Nome e Preço são obrigatórios!";
            }
            if (!decimal.TryParse(price, out decimal priceConvert))
            {
                return "Preço Inválido!";
            }
            if (!int.TryParse(quantidade, out int quantidadeConvert))
            {
                return "Quantidade inválida";
            }

            Product product = new Product(name, priceConvert, quantidadeConvert, descricao);
            model.addProduct(product);
            return "Produto salvo com sucesso!";
        }
        public List<Product> GetAllProducts()
        {
            return model.GetProducts();
        }

    }
}
