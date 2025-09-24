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
    public partial class InitForm : Form
    {
        UsersController usersController = new UsersController();
        public InitForm()
        {
            InitializeComponent();
        }

        private void Init_Enter(object sender, EventArgs e)
        {

        }

        

        private void Init_Enter_1(object sender, EventArgs e)
        {

        }

        private void buttonStartSystem_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            UsersController uc = new UsersController();
            User u = uc.Login(email, password);

            if (u != null)
            {
                this.Hide();
                MenuForm menu = new MenuForm(u);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Email o contraseña incorrectos o usuario inactivo.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
