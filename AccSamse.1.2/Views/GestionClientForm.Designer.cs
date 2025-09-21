namespace AccSamse._1._2.Views
{
    partial class GestionClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ADMIN = new System.Windows.Forms.GroupBox();
            this.buttonLoadUsers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.gridAdminClient = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpManageArea = new System.Windows.Forms.GroupBox();
            this.PhoneClient = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.EmailClient = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.nombreClient = new System.Windows.Forms.TextBox();
            this.nameClient = new System.Windows.Forms.Label();
            this.idcliente = new System.Windows.Forms.TextBox();
            this.IdClient = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BuscarClient = new System.Windows.Forms.TextBox();
            this.SearchClient = new System.Windows.Forms.Label();
            this.ADMIN.SuspendLayout();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdminClient)).BeginInit();
            this.grpManageArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // ADMIN
            // 
            this.ADMIN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ADMIN.Controls.Add(this.buttonLoadUsers);
            this.ADMIN.Controls.Add(this.btnExit);
            this.ADMIN.Controls.Add(this.grpList);
            this.ADMIN.Controls.Add(this.btnEdit);
            this.ADMIN.Controls.Add(this.btnDelete);
            this.ADMIN.Controls.Add(this.btnAdd);
            this.ADMIN.Controls.Add(this.grpManageArea);
            this.ADMIN.Location = new System.Drawing.Point(1, -1);
            this.ADMIN.Margin = new System.Windows.Forms.Padding(2);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Padding = new System.Windows.Forms.Padding(2);
            this.ADMIN.Size = new System.Drawing.Size(1060, 609);
            this.ADMIN.TabIndex = 2;
            this.ADMIN.TabStop = false;
            this.ADMIN.Text = "GestionClients";
            this.ADMIN.Enter += new System.EventHandler(this.ADMIN_Enter);
            // 
            // buttonLoadUsers
            // 
            this.buttonLoadUsers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLoadUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadUsers.Location = new System.Drawing.Point(739, 219);
            this.buttonLoadUsers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadUsers.Name = "buttonLoadUsers";
            this.buttonLoadUsers.Size = new System.Drawing.Size(106, 33);
            this.buttonLoadUsers.TabIndex = 14;
            this.buttonLoadUsers.Text = "LoadUsers";
            this.buttonLoadUsers.UseVisualStyleBackColor = false;
            this.buttonLoadUsers.Click += new System.EventHandler(this.buttonLoadUsers_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(921, 552);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.gridAdminClient);
            this.grpList.Location = new System.Drawing.Point(21, 256);
            this.grpList.Margin = new System.Windows.Forms.Padding(2);
            this.grpList.Name = "grpList";
            this.grpList.Padding = new System.Windows.Forms.Padding(2);
            this.grpList.Size = new System.Drawing.Size(981, 282);
            this.grpList.TabIndex = 4;
            this.grpList.TabStop = false;
            this.grpList.Text = "List";
            // 
            // gridAdminClient
            // 
            this.gridAdminClient.AllowUserToAddRows = false;
            this.gridAdminClient.AllowUserToDeleteRows = false;
            this.gridAdminClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAdminClient.BackgroundColor = System.Drawing.Color.White;
            this.gridAdminClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridAdminClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridAdminClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAdminClient.EnableHeadersVisualStyles = false;
            this.gridAdminClient.GridColor = System.Drawing.Color.Black;
            this.gridAdminClient.Location = new System.Drawing.Point(19, 23);
            this.gridAdminClient.Margin = new System.Windows.Forms.Padding(2);
            this.gridAdminClient.Name = "gridAdminClient";
            this.gridAdminClient.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAdminClient.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAdminClient.RowHeadersVisible = false;
            this.gridAdminClient.RowHeadersWidth = 62;
            this.gridAdminClient.RowTemplate.Height = 28;
            this.gridAdminClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAdminClient.Size = new System.Drawing.Size(929, 239);
            this.gridAdminClient.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(372, 219);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 33);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(555, 219);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(181, 219);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpManageArea
            // 
            this.grpManageArea.Controls.Add(this.PhoneClient);
            this.grpManageArea.Controls.Add(this.phone);
            this.grpManageArea.Controls.Add(this.EmailClient);
            this.grpManageArea.Controls.Add(this.Email);
            this.grpManageArea.Controls.Add(this.last);
            this.grpManageArea.Controls.Add(this.LastName);
            this.grpManageArea.Controls.Add(this.nombreClient);
            this.grpManageArea.Controls.Add(this.nameClient);
            this.grpManageArea.Controls.Add(this.idcliente);
            this.grpManageArea.Controls.Add(this.IdClient);
            this.grpManageArea.Controls.Add(this.button1);
            this.grpManageArea.Controls.Add(this.BuscarClient);
            this.grpManageArea.Controls.Add(this.SearchClient);
            this.grpManageArea.Location = new System.Drawing.Point(21, 33);
            this.grpManageArea.Margin = new System.Windows.Forms.Padding(2);
            this.grpManageArea.Name = "grpManageArea";
            this.grpManageArea.Padding = new System.Windows.Forms.Padding(2);
            this.grpManageArea.Size = new System.Drawing.Size(993, 161);
            this.grpManageArea.TabIndex = 0;
            this.grpManageArea.TabStop = false;
            this.grpManageArea.Text = "Manage area";
            this.grpManageArea.Enter += new System.EventHandler(this.grpManageArea_Enter);
            // 
            // PhoneClient
            // 
            this.PhoneClient.Location = new System.Drawing.Point(440, 106);
            this.PhoneClient.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneClient.Name = "PhoneClient";
            this.PhoneClient.Size = new System.Drawing.Size(130, 20);
            this.PhoneClient.TabIndex = 19;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(369, 108);
            this.phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(41, 13);
            this.phone.TabIndex = 18;
            this.phone.Text = "Phone:";
            // 
            // EmailClient
            // 
            this.EmailClient.Location = new System.Drawing.Point(93, 110);
            this.EmailClient.Margin = new System.Windows.Forms.Padding(2);
            this.EmailClient.Name = "EmailClient";
            this.EmailClient.Size = new System.Drawing.Size(130, 20);
            this.EmailClient.TabIndex = 17;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(16, 110);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 16;
            this.Email.Text = "Email:";
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(785, 67);
            this.last.Margin = new System.Windows.Forms.Padding(2);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(130, 20);
            this.last.TabIndex = 15;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(701, 69);
            this.LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(61, 13);
            this.LastName.TabIndex = 14;
            this.LastName.Text = "Last Name:";
            // 
            // nombreClient
            // 
            this.nombreClient.Location = new System.Drawing.Point(440, 67);
            this.nombreClient.Margin = new System.Windows.Forms.Padding(2);
            this.nombreClient.Name = "nombreClient";
            this.nombreClient.Size = new System.Drawing.Size(130, 20);
            this.nombreClient.TabIndex = 13;
            this.nombreClient.TextChanged += new System.EventHandler(this.nombreClient_TextChanged);
            // 
            // nameClient
            // 
            this.nameClient.AutoSize = true;
            this.nameClient.Location = new System.Drawing.Point(369, 69);
            this.nameClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(38, 13);
            this.nameClient.TabIndex = 12;
            this.nameClient.Text = "Name:";
            // 
            // idcliente
            // 
            this.idcliente.Location = new System.Drawing.Point(93, 71);
            this.idcliente.Margin = new System.Windows.Forms.Padding(2);
            this.idcliente.Name = "idcliente";
            this.idcliente.Size = new System.Drawing.Size(130, 20);
            this.idcliente.TabIndex = 11;
            // 
            // IdClient
            // 
            this.IdClient.AutoSize = true;
            this.IdClient.Location = new System.Drawing.Point(16, 71);
            this.IdClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdClient.Name = "IdClient";
            this.IdClient.Size = new System.Drawing.Size(59, 13);
            this.IdClient.TabIndex = 10;
            this.IdClient.Text = "Document:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(338, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuscarClient
            // 
            this.BuscarClient.Location = new System.Drawing.Point(160, 29);
            this.BuscarClient.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarClient.Name = "BuscarClient";
            this.BuscarClient.Size = new System.Drawing.Size(130, 20);
            this.BuscarClient.TabIndex = 1;
            // 
            // SearchClient
            // 
            this.SearchClient.AutoSize = true;
            this.SearchClient.Location = new System.Drawing.Point(22, 29);
            this.SearchClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchClient.Name = "SearchClient";
            this.SearchClient.Size = new System.Drawing.Size(99, 13);
            this.SearchClient.TabIndex = 0;
            this.SearchClient.Text = "Search Clients (Id): ";
            // 
            // GestionClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 603);
            this.Controls.Add(this.ADMIN);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionClientForm";
            this.Text = "GestionClientForm";
            this.Load += new System.EventHandler(this.GestionClientForm_Load);
            this.ADMIN.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAdminClient)).EndInit();
            this.grpManageArea.ResumeLayout(false);
            this.grpManageArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ADMIN;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView gridAdminClient;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpManageArea;
        private System.Windows.Forms.TextBox PhoneClient;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox EmailClient;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox nombreClient;
        private System.Windows.Forms.Label nameClient;
        private System.Windows.Forms.TextBox idcliente;
        private System.Windows.Forms.Label IdClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BuscarClient;
        private System.Windows.Forms.Label SearchClient;
        private System.Windows.Forms.Button buttonLoadUsers;
    }
}