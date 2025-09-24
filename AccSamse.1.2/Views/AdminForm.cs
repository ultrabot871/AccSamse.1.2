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
using System.Xml.Linq;

namespace AccSamse._1._2.Views
{
    public partial class AdminForm : Form
    {
        // Controller para usuarios
        private readonly UsersController _users = new UsersController();
        private User currentUser;

        public AdminForm(User u)
        {
            InitializeComponent();
            gridAdmin.AutoGenerateColumns = true;
            currentUser = u;
        }

        private void ADMIN_Enter(object sender, EventArgs e)
        {
            // probar conexión
            SqlConnection conn = ConexionDataBase.GetConnection();
            
        }

        private void GestorClient_Click(object sender, EventArgs e)
        {
            GestionClientForm form = new GestionClientForm(currentUser);
            form.Show();
            this.Hide();
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            Inventory form = new Inventory(currentUser);
            form.Show();
            this.Hide();
        }

        private void btnGenerateAdvanced_Click(object sender, EventArgs e)
        {
            Reports form = new Reports(currentUser);
            form.Show();
            this.Hide();
        }

        // ================== CRUD USUARIOS ==================

        // AGREGAR
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones 
                if (string.IsNullOrWhiteSpace(nombreEmployeers.Text) ||
                    string.IsNullOrWhiteSpace(lastEmployeers.Text) ||
                    string.IsNullOrWhiteSpace(EmailEmpleado.Text) ||
                    string.IsNullOrWhiteSpace(idempleado.Text))
                {
                    MessageBox.Show("Completa al menos: Nombre, Apellido, Email y Documento.");
                    return;
                }

                // Solo dígitos en documento
                string doc = idempleado.Text.Trim();
                if (!System.Text.RegularExpressions.Regex.IsMatch(doc, @"^\d+$"))
                {
                    MessageBox.Show("Documento debe contener solo números (0-9).");
                    idempleado.Focus();
                    return;
                }

                User u = new User();
                u.Name = nombreEmployeers.Text;
                u.Last_Name = lastEmployeers.Text;
                u.Email = EmailEmpleado.Text;
                u.Document = idempleado.Text;
                u.Phone = PhoneEmpleado.Text;
                u.Role = RoleUser.Text.Trim();
                u.Password = PasswordEmployeers.Text;
                u.State = "Activo";

                // 🔹 Validar que no se creen múltiples administradores
                string roleCheck = u.Role.ToLower();
                if (roleCheck == "admin" || roleCheck == "administrador")
                {
                    using (SqlConnection conn = ConexionDataBase.GetConnection())
                    {
                        conn.Open();
                        string checkSql = "SELECT COUNT(*) FROM dbo.usuarios WHERE LOWER(role) IN ('admin','administrador')";
                        using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                        {
                            int count = (int)checkCmd.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("❌ Solo se permite un administrador en el sistema.");
                                return;
                            }
                        }
                    }
                }

                bool ok = _users.Create(u);
                MessageBox.Show(ok ? "✅ Usuario agregado" : "❌ No se pudo agregar");

                if (ok) CargarUsuariosEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        // EDITAR
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(idempleado.Text, out id))
                {
                    MessageBox.Show("Document inválido.");
                    return;
                }

                User u = new User();
                u.Id_person = id;                     
                u.Name = nombreEmployeers.Text;
                u.Last_Name = lastEmployeers.Text;
                u.Email = EmailEmpleado.Text;
                u.Document = idempleado.Text;
                u.Phone = PhoneEmpleado.Text;
                u.Role = RoleUser.Text;
                u.Password = PasswordEmployeers.Text;
                u.State = "Activo";

                bool ok = _users.Update(u);
                MessageBox.Show(ok ? "✅ Usuario actualizado" : "⚠ No se actualizó");
                if (ok) CargarUsuariosEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        // ELIMINAR
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(idempleado.Text, out id))
                {
                    MessageBox.Show("ID inválido.");
                    return;
                }

                var confirmar = MessageBox.Show(
                    "¿Eliminar este usuario?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmar != DialogResult.Yes) return;

                bool ok = _users.Delete(id);
                MessageBox.Show(ok ? "✅ Usuario eliminado" : "⚠ No se encontró el usuario");
                if (ok) LimpiarFormulario();
                if (ok) CargarUsuariosEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        // BUSCAR POR ID
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(BuscarEmployeers.Text, out id))
                {
                    MessageBox.Show("Document de búsqueda inválido.");
                    return;
                }

                User u = _users.GetById(id);
                if (u == null)
                {
                    MessageBox.Show("⚠ No se encontró el usuario");
                    return;
                }

                // Llenar los campos
                idempleado.Text = u.Id_person.ToString();
                nombreEmployeers.Text = u.Name;
                lastEmployeers.Text = u.Last_Name;
                EmailEmpleado.Text = u.Email;
                idempleado.Text = u.Document;
                PhoneEmpleado.Text = u.Phone;
                RoleUser.Text = u.Role;
                PasswordEmployeers.Text = u.Password;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message);
            }
        }

        // LISTAR
        private void button2_Click(object sender, EventArgs e)
        {
            CargarUsuariosEnGrid();
        }

        // ================== UTILIDADES ==================
        private void CargarUsuariosEnGrid()
        {
            try
            {
                List<User> data = _users.GetAll();
                gridAdmin.DataSource = null; 
                gridAdmin.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            idempleado.Clear();
            nombreEmployeers.Clear();
            lastEmployeers.Clear();
            EmailEmpleado.Clear();
            PasswordEmployeers.Clear();
            PhoneEmpleado.Clear();
            RoleUser.Text = "";
            idempleado.Clear();
            BuscarEmployeers.Clear();
        }

        private void gridAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0 && gridAdmin.DataSource is List<User>)
            {
                User u = (User)gridAdmin.Rows[e.RowIndex].DataBoundItem;
                idempleado.Text = u.Id_person.ToString();
                nombreEmployeers.Text = u.Name;
                lastEmployeers.Text = u.Last_Name;
                EmailEmpleado.Text = u.Email;
                idempleado.Text = u.Document;
                PhoneEmpleado.Text = u.Phone;
                RoleUser.Text = u.Role;
                PasswordEmployeers.Text = u.Password;
            }
        }

        private void grpManageArea_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm(currentUser);
            form.Show();
            this.Hide();
        }
    }
}
