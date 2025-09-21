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
            CargarVentas();
        }

        private void CargarVentas()
        {
            using (SqlConnection conn = ConexionDataBase.GetConnection())
            {
                conn.Open();

                string query = "SELECT IdVenta, Fecha, Estado, Total FROM Ventas";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewSaleMenuForm.DataSource = dt;
            }
        }

        private void dataGridViewSaleMenuForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSaleMenuForm.Columns[e.ColumnIndex].Name == "Delete")
            {
                int idVenta = Convert.ToInt32(dataGridViewSaleMenuForm.Rows[e.RowIndex].Cells["IdVenta"].Value);

                using (SqlConnection conn = ConexionDataBase.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Ventas WHERE IdVenta = @id", conn);
                    cmd.Parameters.AddWithValue("@id", idVenta);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Venta eliminada correctamente.");
                CargarVentas(); // refresca la grilla
            }

            if (dataGridViewSaleMenuForm.Columns[e.ColumnIndex].Name == "Edit")
            {
                int idVenta = Convert.ToInt32(dataGridViewSaleMenuForm.Rows[e.RowIndex].Cells["IdVenta"].Value);

                // abrir SaleForm pasando el IdVenta
                SaleForm form = new SaleForm(idVenta);
                form.Show();
                this.Hide();
            }

        }




    }
}
