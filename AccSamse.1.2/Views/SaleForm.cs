using AccSamse._1._2.Controllers;
using AccSamse._1._2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccSamse._1._2.Views
{
    public partial class SaleForm : Form
    {
        private readonly UsersController _users = new UsersController();
        private readonly ClientsController _clients = new ClientsController();
        private readonly ProductsController _products = new ProductsController();
        private readonly SalesController _sales = new SalesController();
        private int? _idSale;

        public SaleForm(int? idVenta = null)
        {
            InitializeComponent();
            _idSale = idVenta;
        }

        private void groupBoxProduct_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxSaleForm_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(BuscarClientSale.Text, out id))
                {
                    MessageBox.Show("Document de búsqueda inválido en Client Search.");
                    return;
                }


                Client u = _clients.GetById(id);
                if (u == null)
                {
                    MessageBox.Show("⚠ No se encontró el usuario");
                    return;
                }

                // Llenar los campos
                NameClientSale.Text = u.Name.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message);
            }
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            if (_idSale.HasValue)
            {
                CargarVenta(_idSale.Value);
            }
        }

        private void CargarVenta(int idSale)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();

                // 🔹 Encabezado de la venta
                string queryVenta = @"
                    SELECT v.id_Sale, v.date, v.total, v.state,
                           c.name AS Client,
                           u.name AS usuarios
                    FROM Sales v
                    INNER JOIN Client c ON v.id_Client = c.id_Client
                    INNER JOIN usuarios u ON v.id_person = u.id_person
                    WHERE v.id_Sale = @id";

                SqlCommand cmdVenta = new SqlCommand(queryVenta, conn);
                cmdVenta.Parameters.AddWithValue("@id", idSale);

                SqlDataReader reader = cmdVenta.ExecuteReader();
                if (reader.Read())
                {
                    NameClientSale.Text = reader["Client"].ToString();
                    NameSallerSale.Text = reader["usuarios"].ToString();
                    textBoxSaleNo.Text = "S-" + reader["id_Sale"].ToString().PadLeft(6, '0');
                    dateTimePickerDateSale.Value = Convert.ToDateTime(reader["date"]);
                    textBoxTotalSale.Text = "Total: $" + Convert.ToDecimal(reader["total"]).ToString("N2");
                }
                reader.Close();

                // 🔹 Detalle de productos de la venta
                string queryDetalle = @"
                  SELECT p.name AS Producto,
                         d.Amount AS Cantidad,
                         d.unit_Price AS Precio,
                         (d.Amount * d.unit_Price) AS Subtotal
                  FROM SaleDetails d
                  INNER JOIN Products p ON d.id_Product = p.id_product
                  WHERE d.id_Sale = @id";

                SqlDataAdapter da = new SqlDataAdapter(queryDetalle, conn);
                da.SelectCommand.Parameters.AddWithValue("@id", idSale);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewProducts.DataSource = dt;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(BuscarSallerSale.Text, out id))
                {
                    MessageBox.Show("Document de búsqueda inválido en Client Search.");
                    return;
                }


                User u = _users.GetById(id);
                if (u == null)
                {
                    MessageBox.Show("⚠ No se encontró el usuario");
                    return;
                }

                // Llenar los campos
                NameSallerSale.Text = u.Name.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message);
            }
        }

        private void dateTimePickerDateSale_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDateSale.Value = DateTime.Now;
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(TextBuscarProduct.Text, out id))
                {
                    MessageBox.Show("id de búsqueda inválido en Search Products (id).");
                    return;
                }


                Product p = _products.GetById(id);
                if (p == null)
                {
                    MessageBox.Show("⚠ No se encontró el producto");
                    return;
                }

                // Insertar una nueva fila en el DataGridView
                int rowIndex = dataGridViewProducts.Rows.Add();
                DataGridViewRow row = dataGridViewProducts.Rows[rowIndex];

                row.Cells["Code"].Value = p.Id_product;
                row.Cells["Product"].Value = p.Name;
                row.Cells["Stock"].Value = 1; // cantidad inicial por defecto
                row.Cells["Price"].Value = p.Price;
                row.Cells["Subtotal"].Value = p.Price; // cantidad(1) × precio

                // Calcular el total después de agregar
                CalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message);
            }
        }


        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dataGridViewProducts.Rows)
            {
                if (!fila.IsNewRow) // evitar la fila vacía al final
                {
                    if (fila.Cells["Subtotal"].Value != null && fila.Cells["Subtotal"].Value != DBNull.Value)
                    {
                        total += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                    }
                }
            }

            textBoxTotalSale.Text = "Total: $" + total.ToString("N2");
        }

        private void groupBoxClient_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewProducts.Columns[e.ColumnIndex].Name == "Delete")
            {
                dataGridViewProducts.Rows.RemoveAt(e.RowIndex);
                CalcularTotal();
            }
        }

        private void dataGridViewProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewProducts.Columns[e.ColumnIndex].Name == "Stock")
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];

                int cantidad = Convert.ToInt32(row.Cells["Stock"].Value);
                decimal precio = Convert.ToDecimal(row.Cells["Price"].Value);

                row.Cells["Subtotal"].Value = cantidad * precio;

                CalcularTotal();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear la venta
                Sale s = new Sale
                {
                    Date = dateTimePickerDateSale.Value, // DateTime, no string
                    Total = Convert.ToDouble(textBoxTotalSale.Text.Replace("Total: $", "")), // Convierte a decimal
                    State = "Activo"
                };

                // Guardar la venta con tu controlador de ventas
                bool ok = _sales.Create(s);

                if (ok)
                {
                    MessageBox.Show("✅ Venta registrada correctamente");

                    // Mostrar el código de la venta en la etiqueta
                    textBoxSaleNo.Text = "S-" + s.Id_Sale.ToString().PadLeft(6, '0');

                    // Si quieres limpiar la grilla después de registrar
                    dataGridViewProducts.Rows.Clear();
                    textBoxTotalSale.Text = "0";
                }
                else
                {
                    MessageBox.Show("❌ No se pudo registrar la venta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠ Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm();
            form.Show();
            this.Hide();
        }
    }
}
