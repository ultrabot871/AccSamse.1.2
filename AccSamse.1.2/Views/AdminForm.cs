using AccSamse._1._2.Models;  // 👈 para usar ConexionDataBase
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
using System.Xml.Linq;

namespace AccSamse._1._2.Views
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            
        }

        private void ADMIN_Enter(object sender, EventArgs e)
        {
            // 👇 Solo llamar la conexión
            SqlConnection conn = ConexionDataBase.GetConnection();
        }

        private void GestorClient_Click(object sender, EventArgs e)
        {
            GestionClientForm form = new GestionClientForm();
            form.Show();   // abre nuevo form
            this.Hide(); 

        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            Inventory form = new Inventory();
            form.Show();
            this.Hide();
        }

        private void btnGenerateAdvanced_Click(object sender, EventArgs e)
        {
            Reports form = new Reports();
            form.Show();
            this.Hide();
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = ConexionDataBase.GetConnection();

                string query = "INSERT INTO Users (Id_User, Name, Last_Name, Email, Password, Phone, Rol, Status) " +
                               "VALUES (@Id_User, @Name, @Last_Name, @Email,@Password, @Phone, @Rol, @Status)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_User", idempleado.Text);
                cmd.Parameters.AddWithValue("@Name", nombreEmployeers.Text);
                cmd.Parameters.AddWithValue("@Last_Name", lastEmployeers.Text);
                cmd.Parameters.AddWithValue("@Email", EmailEmpleado.Text);
                cmd.Parameters.AddWithValue("@Phone", PhoneEmpleado.Text);
                cmd.Parameters.AddWithValue("@Rol", RoleUser.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordEmployeers.Text);
                cmd.Parameters.AddWithValue("@Status", 1); // 1 = Activo por defecto

                cmd.ExecuteNonQuery();
                MessageBox.Show("✅ Empleado agregado correctamente");

                ConexionDataBase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al agregar empleado: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = ConexionDataBase.GetConnection();

                // 🔹 Consulta SQL para actualizar al usuario
                string query = "UPDATE Users SET " +
                               "Name=@Name, " +
                               "Last_Name=@Last_Name, " +
                               "Email=@Email, " +
                               "Password=@Password, " +
                               "Phone=@Phone, " +
                               "Rol=@Rol, " +
                               "Status=@Status " +
                               "WHERE Id_User=@Id_User";

                SqlCommand cmd = new SqlCommand(query, conn);

                // 🔹 Asignamos los parámetros (igual que en Add, pero ahora sí usamos Id_User)
                cmd.Parameters.AddWithValue("@Id_User", Convert.ToInt32(idempleado.Text));
                cmd.Parameters.AddWithValue("@Name", nombreEmployeers.Text);
                cmd.Parameters.AddWithValue("@Last_Name", lastEmployeers.Text);
                cmd.Parameters.AddWithValue("@Email", EmailEmpleado.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordEmployeers.Text);
                cmd.Parameters.AddWithValue("@Phone", PhoneEmpleado.Text);
                cmd.Parameters.AddWithValue("@Rol", RoleUser.Text);
                cmd.Parameters.AddWithValue("@Status", 1); // 1 = Activo por defecto

                // 🔹 Ejecutar actualización
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("✅ Usuario actualizado correctamente");
                else
                    MessageBox.Show("⚠ No se encontró el usuario con ese ID");

                ConexionDataBase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al editar usuario: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = ConexionDataBase.GetConnection();

                // 🔹 Consulta SQL para eliminar usuario
                string query = "DELETE FROM Users WHERE Id_User=@Id_User";

                SqlCommand cmd = new SqlCommand(query, conn);

                // 🔹 Asignamos el parámetro (necesitamos el ID del usuario)
                cmd.Parameters.AddWithValue("@Id_User", Convert.ToInt32(idempleado.Text));

                // 🔹 Ejecutar eliminación
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("✅ Usuario eliminado correctamente");
                else
                    MessageBox.Show("⚠ No se encontró el usuario con ese ID");

                ConexionDataBase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar usuario: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = ConexionDataBase.GetConnection();

                // 🔹 Consulta SQL para buscar usuario por Id_User
                string query = "SELECT Id_User, Name, Last_Name, Email, Password, Phone, Rol, Status " +
                               "FROM Users WHERE Id_User = @Id_User";

                SqlCommand cmd = new SqlCommand(query, conn);

                // 🔹 Tomamos el valor del cuadro de búsqueda
                cmd.Parameters.AddWithValue("@Id_User", Convert.ToInt32(BuscarEmployeers.Text));

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // 🔹 Llenamos los campos del formulario con los datos encontrados
                    idempleado.Text = reader["Id_User"].ToString();
                    nombreEmployeers.Text = reader["Name"].ToString();
                    lastEmployeers.Text = reader["Last_Name"].ToString();
                    EmailEmpleado.Text = reader["Email"].ToString();
                    PasswordEmployeers.Text = reader["Password"].ToString();
                    PhoneEmpleado.Text = reader["Phone"].ToString();
                    RoleUser.Text = reader["Rol"].ToString();

                    MessageBox.Show("✅ Usuario encontrado");
                }
                else
                {
                    MessageBox.Show("⚠ No se encontró ningún usuario con ese ID");
                }

                reader.Close();
                ConexionDataBase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error en la búsqueda: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = ConexionDataBase.GetConnection();

                string query = "SELECT Id_User, Name, Last_Name, Email, Phone, Rol, Status FROM Users";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // 👇 Mostrar los datos en el DataGridView
                gridAdmin.DataSource = dt;

                ConexionDataBase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar usuarios: " + ex.Message);
            }
        }
        
        private void gridAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
