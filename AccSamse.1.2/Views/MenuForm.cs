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
    public partial class MenuForm : Form
    {

        private User currentUser;

        public MenuForm(User u)
        {
            InitializeComponent();
            currentUser = u;
        }

        private void groupBoxMenu_Enter(object sender, EventArgs e)
        {
            

            // 🔹 Ocultar/mostrar botones según rol
            switch (currentUser.Role.ToLower())
            {
                case "admin":
                    buttonEntrySale.Visible = true;
                    buttonEntryInventory.Visible = true;
                    buttonEntryAdministration.Visible = true;
                    break;

                case "empleado":
                    buttonEntrySale.Visible = true;
                    buttonEntryInventory.Visible = true;
                    buttonEntryAdministration.Visible = false;
                    break;

                case "usuario":
                    buttonEntrySale.Visible = true;
                    buttonEntryInventory.Visible = true;
                    buttonEntryAdministration.Visible = false;
                    break;
            }
        }

        private void buttonOffSytem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
