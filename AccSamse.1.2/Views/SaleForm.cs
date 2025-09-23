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
        private readonly PaymentsController _payments = new PaymentsController();
        private readonly SaleDetailsController _saleDetails= new SaleDetailsController();
        private DataTable _detalleVenta;
        private int? _idSale;
        private int _idPayment;

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

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Acción";
            btnEliminar.Name = "Eliminar"; // ⚠ aquí se llama Eliminar
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dataGridViewProducts.Columns.Add(btnEliminar);
            dataGridViewProducts.AllowUserToAddRows = false;

            // 🔹 Siempre inicializamos la tabla
            InicializarTablaDetalle();

            if (_idSale.HasValue)
            {
                CargarVenta(_idSale.Value);
            }
            else
            {
                InicializarTablaDetalle();
            }
        }

        private void InicializarTablaDetalle()
        {
            _detalleVenta = new DataTable();
            _detalleVenta.Columns.Add("Code", typeof(int));      
            _detalleVenta.Columns.Add("Product", typeof(string)); 
            _detalleVenta.Columns.Add("Stock", typeof(int));      
            _detalleVenta.Columns.Add("Price", typeof(decimal));  
            _detalleVenta.Columns.Add("Subtotal", typeof(decimal));

            dataGridViewProducts.DataSource = _detalleVenta;

            BloquearColumnas();
        }

        private void CargarVenta(int idSale)
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {


                // 🔹 Encabezado de la venta
                string queryVenta = @"
                 SELECT 
                     s.id_Sale,
                     s.id_payment,
                     s.date, 
                     s.total, 
                     c.id_Client, 
                     c.name AS Client, 
                     u.id_person,
                     u.name AS usuarios,
                     p.Amount,
                     p.Payment_Method AS PaymentMethod
                 FROM Sales s
                 INNER JOIN Client c ON s.id_Client = c.id_Client
                 INNER JOIN usuarios u ON s.id_person = u.id_person
                 INNER JOIN Payments p ON s.id_payment = p.id_payment
                 WHERE s.id_Sale = @id";

               

                SqlCommand cmdVenta = new SqlCommand(queryVenta, conn);
                cmdVenta.Parameters.AddWithValue("@id", idSale);

                SqlDataReader reader = cmdVenta.ExecuteReader();    
                if (reader.Read())
                {
                    _idPayment = Convert.ToInt32(reader["id_payment"]); // variable de clase
                    BuscarClientSale.Text = reader["id_Client"].ToString();
                    BuscarSallerSale.Text = reader["id_person"].ToString();
                    NameClientSale.Text = reader["Client"].ToString();
                    NameSallerSale.Text = reader["usuarios"].ToString();
                    textBoxSaleNo.Text = "S-" + reader["id_Sale"].ToString().PadLeft(6, '0');
                    dateTimePickerDateSale.Value = Convert.ToDateTime(reader["date"]);
                    textBoxTotalSale.Text = "Total: $" + Convert.ToDecimal(reader["total"]).ToString("N2");
                    comboBoxPaymentMethod.Text = reader["PaymentMethod"].ToString();
                    textBoxAmountPayment.Text = reader["Amount"].ToString();
                }
                reader.Close();

                // Cargar detalle desde BD
                string queryDetalle = @"
                 SELECT 
                     p.id_product AS Code,
                     p.name AS Product,
                     d.Amount AS Stock,
                     d.unit_Price AS Price,
                     (d.Amount * d.unit_Price) AS Subtotal
                 FROM SaleDetails d
                 INNER JOIN Products p ON d.id_Product = p.id_product
                 WHERE d.id_Sale = @id";

                using (SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conn))
                {
                    cmdDetalle.Parameters.AddWithValue("@id", idSale);

                    SqlDataAdapter da = new SqlDataAdapter(cmdDetalle);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 🔹 Siempre usar _detalleVenta
                    _detalleVenta.Clear();
                    foreach (DataRow r in dt.Rows)
                    {
                        _detalleVenta.ImportRow(r);
                    }

                    dataGridViewProducts.DataSource = _detalleVenta;
                }


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
                int productId = int.Parse(TextBuscarProduct.Text);

                using (SqlConnection conn = ConexionDataBase.GetConnection())
                {
                    string sql = "SELECT id_product, name, stock, price FROM dbo.Products WHERE id_product=@id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", productId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int code = Convert.ToInt32(reader["id_product"]);
                                string name = reader["name"].ToString();
                                decimal price = Convert.ToDecimal(reader["price"]);

                                int amount = 1; // siempre se agrega 1 al inicio
                                decimal subtotal = amount * price;

                                DataRow row = _detalleVenta.NewRow();
                                row["Code"] = code;
                                row["Product"] = name;
                                row["Stock"] = 1;         // cantidad inicial
                                row["Price"] = price;
                                row["Subtotal"] = subtotal;
                                _detalleVenta.Rows.Add(row);

                                CalcularTotal();
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dataGridViewProducts.Rows)
            {
                if (!fila.IsNewRow)
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
            if (e.RowIndex >= 0 && dataGridViewProducts.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                // Confirmación opcional
                DialogResult dr = MessageBox.Show("¿Eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dataGridViewProducts.Rows.RemoveAt(e.RowIndex);
                    CalcularTotal();
                }
            }
        }

        private void dataGridViewProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewProducts.Columns[e.ColumnIndex].Name == "Stock")
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];
                int stock = Convert.ToInt32(row.Cells["Stock"].Value);
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                row.Cells["Subtotal"].Value = stock * price;
                CalcularTotal();
            }
        }

        private void dataGridViewProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewProducts.Columns[e.ColumnIndex].Name == "Stock")
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];

                int stock = 0;
                int.TryParse(row.Cells["Stock"].Value?.ToString(), out stock);

                decimal price = 0;
                decimal.TryParse(row.Cells["Price"].Value?.ToString(), out price);

                row.Cells["Subtotal"].Value = stock * price;

                CalcularTotal();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 🔹 1. Validar monto ingresado vs total
                decimal total = Convert.ToDecimal(textBoxTotalSale.Text.Replace("Total: $", "").Trim());
                decimal montoPago = decimal.Parse(textBoxAmountPayment.Text);

                if (montoPago < total)
                {
                    MessageBox.Show("⚠ El monto ingresado debe ser mayor o igual al total de la venta.");
                    return; // ❌ No sigue si no alcanza
                }

                if (_idSale.HasValue) // ✅ Estamos EDITANDO
                {
                    // 1. Actualizar pago
                    Payment p = new Payment
                    {
                        Id_Payment = _idPayment,
                        Amount1 = decimal.Parse(textBoxAmountPayment.Text),
                        Payment_Method = comboBoxPaymentMethod.Text,
                        Payment_Date = dateTimePickerDateSale.Value
                    };
                    _payments.Update(p);

                    // 2. Actualizar venta
                    Sale s = new Sale
                    {
                        Id_Sale = _idSale.Value,
                        Id_Person = int.Parse(BuscarSallerSale.Text),
                        Id_Client = int.Parse(BuscarClientSale.Text),
                        Id_Payment = p.Id_Payment,
                        Date = dateTimePickerDateSale.Value,
                        Total = Convert.ToDouble(textBoxTotalSale.Text.Replace("Total: $", "")),
                        State = "Activo"
                    };
                    _sales.Update(s);

                    // 3. Borrar detalles antiguos
                    _saleDetails.DeleteBySaleId(_idSale.Value);

                    // 4. Insertar los nuevos detalles
                    foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                    {
                        if (row.IsNewRow) continue;

                        SaleDetails sd = new SaleDetails
                        {
                            Id_Sale = _idSale.Value,
                            Id_Product = Convert.ToInt32(row.Cells["Code"].Value),
                            Amount = Convert.ToInt32(row.Cells["Stock"].Value),
                            Unit_Price = Convert.ToDecimal(row.Cells["Price"].Value),
                            Subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value)
                        };

                        _saleDetails.Create(sd);
                    }

                    MessageBox.Show("✅ Venta actualizada correctamente");
                }
                else // ✅ NUEVA VENTA
                {
                    // Crear pago
                    Payment p = new Payment
                    {
                        Amount1 = decimal.Parse(textBoxAmountPayment.Text),
                        Payment_Method = comboBoxPaymentMethod.Text,
                        Payment_Date = dateTimePickerDateSale.Value
                    };
                    int paymentId = _payments.Create(p);

                    // Crear venta
                    Sale s = new Sale
                    {
                        Id_Person = int.Parse(BuscarSallerSale.Text),
                        Id_Client = int.Parse(BuscarClientSale.Text),
                        Id_Payment = paymentId,
                        Date = dateTimePickerDateSale.Value,
                        Total = Convert.ToDouble(textBoxTotalSale.Text.Replace("Total: $", "")),
                        State = "Activo"
                    };
                    int saleId = _sales.Create(s);

                    // Insertar detalles
                    foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                    {
                        if (row.IsNewRow) continue;

                        SaleDetails sd = new SaleDetails
                        {
                            Id_Sale = saleId,
                            Id_Product = Convert.ToInt32(row.Cells["Code"].Value),
                            Amount = Convert.ToInt32(row.Cells["Stock"].Value),
                            Unit_Price = Convert.ToDecimal(row.Cells["Price"].Value),
                            Subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value)
                        };

                        _saleDetails.Create(sd);
                    }

                    MessageBox.Show("✅ Venta registrada correctamente");
                }

                // Al final volver al menú
                MenuForm form = new MenuForm();
                form.Show();
                this.Hide();
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

        private void TextBuscarProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void BloquearColumnas()
        {
            if (dataGridViewProducts.Columns.Contains("Code"))
                dataGridViewProducts.Columns["Code"].ReadOnly = true;

            if (dataGridViewProducts.Columns.Contains("Product"))
                dataGridViewProducts.Columns["Product"].ReadOnly = true;

            if (dataGridViewProducts.Columns.Contains("Price"))
                dataGridViewProducts.Columns["Price"].ReadOnly = true;

            if (dataGridViewProducts.Columns.Contains("Subtotal"))
                dataGridViewProducts.Columns["Subtotal"].ReadOnly = true;

            // ⚠ Dejamos solo Stock editable
            if (dataGridViewProducts.Columns.Contains("Stock"))
                dataGridViewProducts.Columns["Stock"].ReadOnly = false;
        }

        private void BuscarSallerSale_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
