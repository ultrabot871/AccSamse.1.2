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
    public partial class Reports : Form
    {
        private User currentUser;

        public Reports(User u)
        {
            InitializeComponent();
            currentUser = u;
        }

        private void btnReportsExit_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm(currentUser);
            form.Show();
            this.Hide();
        }

        private void ReportsAdmin_Enter(object sender, EventArgs e)
        {

        }
    }
}
