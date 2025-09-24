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
    public partial class GestionClientForm : Form
    {
        // Controller para clientes
        private readonly ClientsController _clients = new ClientsController();
        private User currentUser;

        public GestionClientForm(User u)
        {
            InitializeComponent();
            currentUser = u;
        }

        private void grpManageArea_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm(currentUser);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(BuscarClient.Text, out id))
                {
                    MessageBox.Show("ID de búsqueda inválido.");
                    return;
                }

                Client u = _clients.GetById(id);
                if (u == null)
                {
                    MessageBox.Show("⚠ No se encontró el usuario");
                    return;
                }

                // Llenar los campos
                idcliente.Text = u.Id_person.ToString();
                nombreClient.Text = u.Name;
                last.Text = u.Last_Name;
                EmailClient.Text = u.Email;
                PhoneClient.Text = u.Document;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message);
            }
        }

        private void ADMIN_Enter(object sender, EventArgs e)
        {

        }

        private void nombreClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones 
                if (string.IsNullOrWhiteSpace(nombreClient.Text) ||
                    string.IsNullOrWhiteSpace(last.Text) ||
                    string.IsNullOrWhiteSpace(EmailClient.Text) ||
                    string.IsNullOrWhiteSpace(idcliente.Text))
                {
                    MessageBox.Show("Completa al menos: Name, Last Name, Email y Document.");
                    return;
                }

                // Solo dígitos en documento
                string doc = idcliente.Text.Trim();
                if (!System.Text.RegularExpressions.Regex.IsMatch(doc, @"^\d+$"))
                {
                    MessageBox.Show("Document debe contener solo números (0-9).");
                    idcliente.Focus();
                    return;
                }

                Client u = new Client();
                u.Name = nombreClient.Text;
                u.Last_Name = last.Text;
                u.Email = EmailClient.Text;
                u.Document = idcliente.Text;
                u.Phone = PhoneClient.Text;

                bool ok = _clients.Create(u);
                MessageBox.Show(ok ? "✅ Usuario agregado" : "❌ No se pudo agregar");

                if (ok) CargarClientesEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void CargarClientesEnGrid()
        {
            try
            {
                List<Client> data = _clients.GetAll();
                gridAdminClient.DataSource = null;
                gridAdminClient.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(idcliente.Text, out id))
                {
                    MessageBox.Show("Document inválido.");
                    return;
                }

                Client u = new Client();
                u.Id_person = id;
                u.Name = nombreClient.Text;
                u.Last_Name = last.Text;
                u.Email = EmailClient.Text;
                u.Document = idcliente.Text;
                u.Phone = PhoneClient.Text;

                bool ok = _clients.Update(u);
                MessageBox.Show(ok ? "✅ Usuario actualizado" : "⚠ No se actualizó");
                if (ok) CargarClientesEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(idcliente.Text, out id))
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

                bool ok = _clients.Delete(id);
                MessageBox.Show(ok ? "✅ Usuario eliminado" : "⚠ No se encontró el usuario");
                if (ok) LimpiarFormulario();
                if (ok) CargarClientesEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            idcliente.Clear();
            nombreClient.Clear();
            last.Clear();
            EmailClient.Clear();
            PhoneClient.Clear();
        }

        private void buttonLoadUsers_Click(object sender, EventArgs e)
        {
            CargarClientesEnGrid();
        }

        private void GestionClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
