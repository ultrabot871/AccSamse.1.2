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
    public partial class MenuForm : Form
    {
        private readonly SalesController _sales = new SalesController();

        public MenuForm()
        {
            InitializeComponent();
            this.Load += MenuForm_Load;
            this.dataGridViewSaleMenuForm.CellContentClick += dataGridViewSaleMenuForm_CellContentClick;
        }

        private void buttonEntrySale_Click(object sender, EventArgs e)
        {
            SaleForm form = new SaleForm();
            form.Show();
            this.Hide();
        }

        private void buttonEntryInventory_Click(object sender, EventArgs e)
        {
            InventoryForm form = new InventoryForm();
            form.Show();
            this.Hide();
        }

        private void buttonEntryAdministration_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
            this.Hide();
        }

        private void groupBoxMenu_Enter(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            CargarVentas(); // primero cargamos los datos

            if (dataGridViewSaleMenuForm.Columns["Editar"] == null)
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.HeaderText = "Editar";
                btnEditar.Name = "Editar";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;
                dataGridViewSaleMenuForm.Columns.Add(btnEditar);
            }

            if (dataGridViewSaleMenuForm.Columns["Eliminar"] == null)
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Name = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dataGridViewSaleMenuForm.Columns.Add(btnEliminar);
            }

            dataGridViewSaleMenuForm.AllowUserToAddRows = false;
        }

        private void CargarVentas()
        {
            try
            {
                List<Sale> data = _sales.GetAll();

                dataGridViewSaleMenuForm.DataSource = null;
                dataGridViewSaleMenuForm.DataSource = data;

                // 🔒 Bloquear todas las columnas
                foreach (DataGridViewColumn col in dataGridViewSaleMenuForm.Columns)
                {
                    col.ReadOnly = true;
                }

                // ✅ Solo permitir editar "State"
                if (dataGridViewSaleMenuForm.Columns["State"] != null)
                {
                    dataGridViewSaleMenuForm.Columns["State"].ReadOnly = false;
                }

                // 🔄 Mover botones siempre al final
                if (dataGridViewSaleMenuForm.Columns["Editar"] != null)
                {
                    dataGridViewSaleMenuForm.Columns["Editar"].DisplayIndex = dataGridViewSaleMenuForm.Columns.Count - 1;
                }

                if (dataGridViewSaleMenuForm.Columns["Eliminar"] != null)
                {
                    dataGridViewSaleMenuForm.Columns["Eliminar"].DisplayIndex = dataGridViewSaleMenuForm.Columns.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
            }
        }

        private void dataGridViewSaleMenuForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSaleMenuForm.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int idVenta = Convert.ToInt32(dataGridViewSaleMenuForm.Rows[e.RowIndex].Cells["id_Sale"].Value);

                using (SqlConnection conn = ConexionDataBase.GetConnection())
                {
                    // Primero eliminamos los detalles
                    SqlCommand cmdDetalles = new SqlCommand("DELETE FROM SaleDetails WHERE id_Sale = @id", conn);
                    cmdDetalles.Parameters.AddWithValue("@id", idVenta);
                    cmdDetalles.ExecuteNonQuery();

                    // Luego eliminamos la venta
                    SqlCommand cmdVenta = new SqlCommand("DELETE FROM Sales WHERE id_Sale = @id", conn);
                    cmdVenta.Parameters.AddWithValue("@id", idVenta);
                    cmdVenta.ExecuteNonQuery();
                }

                MessageBox.Show("Venta eliminada correctamente.");
                CargarVentas(); // refresca la grilla
            }

            if (dataGridViewSaleMenuForm.Columns[e.ColumnIndex].Name == "Editar")
            {
                int idVenta = Convert.ToInt32(dataGridViewSaleMenuForm.Rows[e.RowIndex].Cells["Id_Sale"].Value);

                // abrir SaleForm pasando el IdVenta
                SaleForm form = new SaleForm(idVenta);
                form.Show();
                this.Hide();
            }

        }

        private void dateTimePickerDateMenu_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
