using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Controller;
using MVC.Model;

namespace MVC
{
    public partial class Form1 : Form
    {

        // '-' .-. '-' .-. '-' .-. '-' .-.
        private ProductController controller = new ProductController();


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String name = txt_name.Text;
            String price = txt_price.Text;

            String mensagemResposta = controller.SaveProduct(name, price);
            MessageBox.Show(mensagemResposta);

            this.RefreshDGV();

        }

        public void RefreshDGV()
        {
            List<Product> products = controller.GetAllProducts();
            dgv_products.DataSource = null; 
            dgv_products.DataSource = products;
        }
    }
}
