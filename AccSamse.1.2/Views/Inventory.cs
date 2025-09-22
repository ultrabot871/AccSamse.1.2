using AccSamse._1._2.controllers;
using AccSamse._1._2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;   // <-- agregado
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccSamse._1._2.Views
{
    public partial class Inventory : Form
    {
        ProductsController controller = new ProductsController();
        public Inventory()
        {
            InitializeComponent();
            
        }

        private void buttonInventoryExit_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
            this.Hide();
        }

        private void AdminInventoryProducts_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Id_Category = Convert.ToInt32(CategoryProduct.Text),
                Name = nombreproduct.Text,
                Description = textBox1.Text,
                Price = Convert.ToDecimal(PrecioProducto.Text),
                Stock = Convert.ToInt32(Stok.Text)
            };

            if (controller.Create(p))
                MessageBox.Show("Producto agregado correctamente");
            else
                MessageBox.Show("Error al agregar producto");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                Id_Product = int.Parse(BuscarProduct.Text),
                Id_Category = Convert.ToInt32(CategoryProduct.Text),
                Name = nombreproduct.Text,
                Description = textBox1.Text,
                Price = Convert.ToDecimal(PrecioProducto.Text),
                Stock = Convert.ToInt32(Stok.Text)
            };

            if (controller.Update(p))
                MessageBox.Show("Producto actualizado correctamente");
            else
                MessageBox.Show("Error al actualizar producto");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(BuscarProduct.Text);

            if (controller.Delete(id))
                MessageBox.Show("Producto eliminado correctamente");
            else
                MessageBox.Show("Error al eliminar producto");
        }

        private void search_Click(object sender, EventArgs e)
        {
            int id = int.Parse(BuscarProduct.Text);
            var p = controller.GetById(id);
            if (p != null)
            {
                nombreproduct.Text = p.Name;
                textBox1.Text = p.Description;
                PrecioProducto.Text = p.Price.ToString();
                Stok.Text = p.Stock.ToString();
                CategoryProduct.Text = p.CategoryName;
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
        }

        private void LoadProducts_Click(object sender, EventArgs e)
        {
            var products = controller.GetAll();
            gridAdmin.DataSource = products;
            // Ocultar la columna extra
            if (gridAdmin.Columns["CategoryName"] != null)
            {
                gridAdmin.Columns["CategoryName"].Visible = false;
            }
        }
    }
}
