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
    public partial class Inventory : Form
    {
        ProductsController controller = new ProductsController();
        private User currentUser;

        public Inventory(User u)
        {
            InitializeComponent();
            currentUser = u;
        }

        private void buttonInventoryExit_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm(currentUser);
            form.Show();
            this.Hide();
        }

        private void AdminInventoryProducts_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar categoría
                if (!int.TryParse(textBoxCategoryInventory.Text, out int idCategoria))
                {
                    MessageBox.Show("El ID de categoría debe ser un número válido.");
                    return;
                }

                // Validar precio
                if (!decimal.TryParse(PrecioProducto.Text, out decimal precio))
                {
                    MessageBox.Show("El precio debe ser un número válido (ej: 123.45).");
                    return;
                }

                // Validar stock
                if (!int.TryParse(Stok.Text, out int stock))
                {
                    MessageBox.Show("El stock debe ser un número entero válido.");
                    return;
                }

                // Validar si existe la categoría
                if (!controller.CategoryExists(idCategoria))
                {
                    var categorias = controller.GetCategories();

                    if (categorias.Any())
                    {
                        StringBuilder sb = new StringBuilder("La categoría ingresada no existe.\n\nCategorías disponibles:\n");
                        foreach (var c in categorias)
                        {
                            sb.AppendLine($"ID: {c.Id} - Nombre: {c.Name}");
                        }

                        MessageBox.Show(sb.ToString(), "Categorías disponibles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("No hay categorías registradas en el sistema. Cree una primero.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return;
                }

                // Validar si el producto ya existe
                var productoExistente = controller.GetAll()
                    .FirstOrDefault(prod => prod.Name.Equals(nombreproduct.Text, StringComparison.OrdinalIgnoreCase));

                if (productoExistente != null)
                {
                    MessageBox.Show("Ya existe un producto con ese nombre. No se puede duplicar.");
                    return;
                }

                // Crear producto
                Product p = new Product
                {
                    Id_Category = idCategoria,
                    Name = nombreproduct.Text,
                    Description = textBox1.Text,
                    Price = precio,
                    Stock = stock
                };

                if (controller.Create(p))
                    MessageBox.Show("Producto agregado correctamente");
                else
                    MessageBox.Show("Error al agregar producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(BuscarProduct.Text, out int idProd))
            {
                MessageBox.Show("Ingrese un ID de producto válido.");
                return;
            }

            if (!int.TryParse(textBoxCategoryInventory.Text, out int idCategoria))
            {
                MessageBox.Show("El ID de categoría debe ser un número válido.");
                return;
            }

            if (!decimal.TryParse(PrecioProducto.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido (ej: 123.45).");
                return;
            }

            if (!int.TryParse(Stok.Text, out int stock))
            {
                MessageBox.Show("El stock debe ser un número entero válido.");
                return;
            }

            Product p = new Product
            {
                Id_product = idProd,
                Id_Category = idCategoria,
                Name = nombreproduct.Text,
                Description = textBox1.Text,
                Price = precio,
                Stock = stock
            };

            if (controller.Update(p))
                MessageBox.Show("Producto actualizado correctamente");
            else
                MessageBox.Show("Error al actualizar producto");
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            int id = int.Parse(BuscarProduct.Text);

            if (!controller.Delete(id))
            {
                MessageBox.Show("⚠ No se puede eliminar el producto porque está asociado a ventas existentes.");
            }
            else
            {
                MessageBox.Show("Producto eliminado correctamente.");
            }
        }

        private void search_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(BuscarProduct.Text);
            var p = controller.GetById(id);
            if (p != null)
            {
                nombreproduct.Text = p.Name;
                textBox1.Text = p.Description;
                PrecioProducto.Text = p.Price.ToString();
                Stok.Text = p.Stock.ToString();
                textBoxCategoryInventory.Text = p.Category;
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
        }

        private void buttonLoadProducts_Click(object sender, EventArgs e)
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
