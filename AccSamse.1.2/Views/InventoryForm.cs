using AccSamse._1._2.Controllers;
using AccSamse._1._2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccSamse._1._2.Views
{

    public partial class InventoryForm : Form
    {
        private readonly ProductsController _products = new ProductsController();
        private User currentUser;

        public InventoryForm(User u)
        {
            InitializeComponent();
            this.Load += MenuForm_Load;
            currentUser = u;
        }

        private void buttonExitInventory_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm(currentUser);
            form.Show();
            this.Hide();
        }

        private void groupBoxInventory_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(textBoxSearchProductsInventoryForm.Text, out id))
                {
                    MessageBox.Show("Search products (id) inválido.");
                    return;
                }

                Product p = _products.GetById(id);
                if (p == null)
                {
                    MessageBox.Show("⚠ No se encontró el producto");
                    return;
                }

                // Llenar los campos
                textBoxIdProductInventory.Text = p.Id_product.ToString();
                textBoxNameProductInventory.Text = p.Name;
                textBoxDescriptionProductInventoryForm.Text = p.Description;
                textBoxPriceProductInventoryForm.Text = p.Price.ToString("F2"); // formato 2 decimales
                textBoxStockProductInventoryForm.Text = p.Stock.ToString();
                textBoxCategoryForm.Text = p.Category;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message);
            }
        }

        private void CargarProductos()
        {
            try
            {
                List<Product> data = _products.GetAll();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            CargarProductos(); 

            dataGridView1.AllowUserToAddRows = false;
        }

    }
}
