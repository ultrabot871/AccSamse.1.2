namespace AccSamse._1._2.Views
{
    partial class AdminForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.GestionClient = new System.Windows.Forms.GroupBox();
            this.GestorClient = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpReports = new System.Windows.Forms.GroupBox();
            this.btnGenerateAdvanced = new System.Windows.Forms.Button();
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.btnUpdateInventory = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.gridAdmin = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpManageArea = new System.Windows.Forms.GroupBox();
            this.PasswordEmployeers = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.RoleUser = new System.Windows.Forms.TextBox();
            this.Role = new System.Windows.Forms.Label();
            this.PhoneEmpleado = new System.Windows.Forms.TextBox();
            this.phoneEmployeers = new System.Windows.Forms.Label();
            this.EmailEmpleado = new System.Windows.Forms.TextBox();
            this.EmailEmployeers = new System.Windows.Forms.Label();
            this.lastEmployeers = new System.Windows.Forms.TextBox();
            this.LastNameEmployeers = new System.Windows.Forms.Label();
            this.nombreEmployeers = new System.Windows.Forms.TextBox();
            this.nameEmployeers = new System.Windows.Forms.Label();
            this.idempleado = new System.Windows.Forms.TextBox();
            this.IdEmployeers = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BuscarEmployeers = new System.Windows.Forms.TextBox();
            this.SearchEmployeers = new System.Windows.Forms.Label();
            this.ADMIN.SuspendLayout();
            this.GestionClient.SuspendLayout();
            this.grpReports.SuspendLayout();
            this.grpInventory.SuspendLayout();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdmin)).BeginInit();
            this.grpManageArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // ADMIN
            // 
            this.ADMIN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ADMIN.Controls.Add(this.button2);
            this.ADMIN.Controls.Add(this.GestionClient);
            this.ADMIN.Controls.Add(this.btnExit);
            this.ADMIN.Controls.Add(this.grpReports);
            this.ADMIN.Controls.Add(this.grpInventory);
            this.ADMIN.Controls.Add(this.grpList);
            this.ADMIN.Controls.Add(this.btnEdit);
            this.ADMIN.Controls.Add(this.btnDelete);
            this.ADMIN.Controls.Add(this.btnAdd);
            this.ADMIN.Controls.Add(this.grpManageArea);
            this.ADMIN.Location = new System.Drawing.Point(-1, 1);
            this.ADMIN.Margin = new System.Windows.Forms.Padding(2);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Padding = new System.Windows.Forms.Padding(2);
            this.ADMIN.Size = new System.Drawing.Size(1076, 626);
            this.ADMIN.TabIndex = 1;
            this.ADMIN.TabStop = false;
            this.ADMIN.Text = "Administration";
            this.ADMIN.Enter += new System.EventHandler(this.ADMIN_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(517, 219);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "LoadUsers";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GestionClient
            // 
            this.GestionClient.Controls.Add(this.GestorClient);
            this.GestionClient.Location = new System.Drawing.Point(755, 41);
            this.GestionClient.Margin = new System.Windows.Forms.Padding(2);
            this.GestionClient.Name = "GestionClient";
            this.GestionClient.Padding = new System.Windows.Forms.Padding(2);
            this.GestionClient.Size = new System.Drawing.Size(299, 116);
            this.GestionClient.TabIndex = 12;
            this.GestionClient.TabStop = false;
            this.GestionClient.Text = "Gestor";
            // 
            // GestorClient
            // 
            this.GestorClient.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GestorClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GestorClient.Location = new System.Drawing.Point(26, 35);
            this.GestorClient.Margin = new System.Windows.Forms.Padding(2);
            this.GestorClient.Name = "GestorClient";
            this.GestorClient.Size = new System.Drawing.Size(241, 42);
            this.GestorClient.TabIndex = 11;
            this.GestorClient.Text = "Gestion Clients";
            this.GestorClient.UseVisualStyleBackColor = false;
            this.GestorClient.Click += new System.EventHandler(this.GestorClient_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(941, 579);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // grpReports
            // 
            this.grpReports.Controls.Add(this.btnGenerateAdvanced);
            this.grpReports.Location = new System.Drawing.Point(755, 410);
            this.grpReports.Margin = new System.Windows.Forms.Padding(2);
            this.grpReports.Name = "grpReports";
            this.grpReports.Padding = new System.Windows.Forms.Padding(2);
            this.grpReports.Size = new System.Drawing.Size(299, 110);
            this.grpReports.TabIndex = 7;
            this.grpReports.TabStop = false;
            this.grpReports.Text = "Reports";
            // 
            // btnGenerateAdvanced
            // 
            this.btnGenerateAdvanced.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerateAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateAdvanced.Location = new System.Drawing.Point(27, 34);
            this.btnGenerateAdvanced.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateAdvanced.Name = "btnGenerateAdvanced";
            this.btnGenerateAdvanced.Size = new System.Drawing.Size(241, 42);
            this.btnGenerateAdvanced.TabIndex = 11;
            this.btnGenerateAdvanced.Text = "Generate Advanced";
            this.btnGenerateAdvanced.UseVisualStyleBackColor = false;
            this.btnGenerateAdvanced.Click += new System.EventHandler(this.btnGenerateAdvanced_Click);
            // 
            // grpInventory
            // 
            this.grpInventory.Controls.Add(this.btnUpdateInventory);
            this.grpInventory.Location = new System.Drawing.Point(755, 183);
            this.grpInventory.Margin = new System.Windows.Forms.Padding(2);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Padding = new System.Windows.Forms.Padding(2);
            this.grpInventory.Size = new System.Drawing.Size(299, 194);
            this.grpInventory.TabIndex = 6;
            this.grpInventory.TabStop = false;
            this.grpInventory.Text = "Inventory";
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdateInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInventory.Location = new System.Drawing.Point(27, 73);
            this.btnUpdateInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(241, 42);
            this.btnUpdateInventory.TabIndex = 10;
            this.btnUpdateInventory.Text = "inventory";
            this.btnUpdateInventory.UseVisualStyleBackColor = false;
            this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.gridAdmin);
            this.grpList.Location = new System.Drawing.Point(21, 256);
            this.grpList.Margin = new System.Windows.Forms.Padding(2);
            this.grpList.Name = "grpList";
            this.grpList.Padding = new System.Windows.Forms.Padding(2);
            this.grpList.Size = new System.Drawing.Size(714, 323);
            this.grpList.TabIndex = 4;
            this.grpList.TabStop = false;
            this.grpList.Text = "List";
            // 
            // gridAdmin
            // 
            this.gridAdmin.AllowUserToAddRows = false;
            this.gridAdmin.AllowUserToDeleteRows = false;
            this.gridAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAdmin.BackgroundColor = System.Drawing.Color.White;
            this.gridAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAdmin.EnableHeadersVisualStyles = false;
            this.gridAdmin.GridColor = System.Drawing.Color.Black;
            this.gridAdmin.Location = new System.Drawing.Point(2, 15);
            this.gridAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.gridAdmin.Name = "gridAdmin";
            this.gridAdmin.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAdmin.RowHeadersVisible = false;
            this.gridAdmin.RowHeadersWidth = 62;
            this.gridAdmin.RowTemplate.Height = 28;
            this.gridAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAdmin.Size = new System.Drawing.Size(710, 306);
            this.gridAdmin.TabIndex = 0;
            this.gridAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAdmin_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(230, 219);
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
            this.btnDelete.Location = new System.Drawing.Point(372, 219);
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
            this.btnAdd.Location = new System.Drawing.Point(88, 219);
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
            this.grpManageArea.Controls.Add(this.PasswordEmployeers);
            this.grpManageArea.Controls.Add(this.Password);
            this.grpManageArea.Controls.Add(this.RoleUser);
            this.grpManageArea.Controls.Add(this.Role);
            this.grpManageArea.Controls.Add(this.PhoneEmpleado);
            this.grpManageArea.Controls.Add(this.phoneEmployeers);
            this.grpManageArea.Controls.Add(this.EmailEmpleado);
            this.grpManageArea.Controls.Add(this.EmailEmployeers);
            this.grpManageArea.Controls.Add(this.lastEmployeers);
            this.grpManageArea.Controls.Add(this.LastNameEmployeers);
            this.grpManageArea.Controls.Add(this.nombreEmployeers);
            this.grpManageArea.Controls.Add(this.nameEmployeers);
            this.grpManageArea.Controls.Add(this.idempleado);
            this.grpManageArea.Controls.Add(this.IdEmployeers);
            this.grpManageArea.Controls.Add(this.button1);
            this.grpManageArea.Controls.Add(this.BuscarEmployeers);
            this.grpManageArea.Controls.Add(this.SearchEmployeers);
            this.grpManageArea.Location = new System.Drawing.Point(21, 33);
            this.grpManageArea.Margin = new System.Windows.Forms.Padding(2);
            this.grpManageArea.Name = "grpManageArea";
            this.grpManageArea.Padding = new System.Windows.Forms.Padding(2);
            this.grpManageArea.Size = new System.Drawing.Size(714, 172);
            this.grpManageArea.TabIndex = 0;
            this.grpManageArea.TabStop = false;
            this.grpManageArea.Text = "Manage area";
            this.grpManageArea.Enter += new System.EventHandler(this.grpManageArea_Enter);
            // 
            // PasswordEmployeers
            // 
            this.PasswordEmployeers.Location = new System.Drawing.Point(83, 142);
            this.PasswordEmployeers.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordEmployeers.Name = "PasswordEmployeers";
            this.PasswordEmployeers.Size = new System.Drawing.Size(130, 20);
            this.PasswordEmployeers.TabIndex = 23;
            this.PasswordEmployeers.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(16, 142);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 13);
            this.Password.TabIndex = 22;
            this.Password.Text = "Password:";
            // 
            // RoleUser
            // 
            this.RoleUser.Location = new System.Drawing.Point(519, 108);
            this.RoleUser.Margin = new System.Windows.Forms.Padding(2);
            this.RoleUser.Name = "RoleUser";
            this.RoleUser.Size = new System.Drawing.Size(130, 20);
            this.RoleUser.TabIndex = 21;
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(435, 110);
            this.Role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(32, 13);
            this.Role.TabIndex = 20;
            this.Role.Text = "Role:";
            // 
            // PhoneEmpleado
            // 
            this.PhoneEmpleado.Location = new System.Drawing.Point(283, 108);
            this.PhoneEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneEmpleado.Name = "PhoneEmpleado";
            this.PhoneEmpleado.Size = new System.Drawing.Size(130, 20);
            this.PhoneEmpleado.TabIndex = 19;
            // 
            // phoneEmployeers
            // 
            this.phoneEmployeers.AutoSize = true;
            this.phoneEmployeers.Location = new System.Drawing.Point(227, 110);
            this.phoneEmployeers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneEmployeers.Name = "phoneEmployeers";
            this.phoneEmployeers.Size = new System.Drawing.Size(41, 13);
            this.phoneEmployeers.TabIndex = 18;
            this.phoneEmployeers.Text = "Phone:";
            // 
            // EmailEmpleado
            // 
            this.EmailEmpleado.Location = new System.Drawing.Point(59, 110);
            this.EmailEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.EmailEmpleado.Name = "EmailEmpleado";
            this.EmailEmpleado.Size = new System.Drawing.Size(130, 20);
            this.EmailEmpleado.TabIndex = 17;
            // 
            // EmailEmployeers
            // 
            this.EmailEmployeers.AutoSize = true;
            this.EmailEmployeers.Location = new System.Drawing.Point(16, 110);
            this.EmailEmployeers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailEmployeers.Name = "EmailEmployeers";
            this.EmailEmployeers.Size = new System.Drawing.Size(35, 13);
            this.EmailEmployeers.TabIndex = 16;
            this.EmailEmployeers.Text = "Email:";
            // 
            // lastEmployeers
            // 
            this.lastEmployeers.Location = new System.Drawing.Point(519, 69);
            this.lastEmployeers.Margin = new System.Windows.Forms.Padding(2);
            this.lastEmployeers.Name = "lastEmployeers";
            this.lastEmployeers.Size = new System.Drawing.Size(130, 20);
            this.lastEmployeers.TabIndex = 15;
            // 
            // LastNameEmployeers
            // 
            this.LastNameEmployeers.AutoSize = true;
            this.LastNameEmployeers.Location = new System.Drawing.Point(435, 71);
            this.LastNameEmployeers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameEmployeers.Name = "LastNameEmployeers";
            this.LastNameEmployeers.Size = new System.Drawing.Size(61, 13);
            this.LastNameEmployeers.TabIndex = 14;
            this.LastNameEmployeers.Text = "Last Name:";
            // 
            // nombreEmployeers
            // 
            this.nombreEmployeers.Location = new System.Drawing.Point(283, 69);
            this.nombreEmployeers.Margin = new System.Windows.Forms.Padding(2);
            this.nombreEmployeers.Name = "nombreEmployeers";
            this.nombreEmployeers.Size = new System.Drawing.Size(130, 20);
            this.nombreEmployeers.TabIndex = 13;
            // 
            // nameEmployeers
            // 
            this.nameEmployeers.AutoSize = true;
            this.nameEmployeers.Location = new System.Drawing.Point(227, 71);
            this.nameEmployeers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameEmployeers.Name = "nameEmployeers";
            this.nameEmployeers.Size = new System.Drawing.Size(38, 13);
            this.nameEmployeers.TabIndex = 12;
            this.nameEmployeers.Text = "Name:";
            // 
            // idempleado
            // 
            this.idempleado.Location = new System.Drawing.Point(93, 71);
            this.idempleado.Margin = new System.Windows.Forms.Padding(2);
            this.idempleado.Name = "idempleado";
            this.idempleado.Size = new System.Drawing.Size(121, 20);
            this.idempleado.TabIndex = 11;
            // 
            // IdEmployeers
            // 
            this.IdEmployeers.AutoSize = true;
            this.IdEmployeers.Location = new System.Drawing.Point(16, 71);
            this.IdEmployeers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdEmployeers.Name = "IdEmployeers";
            this.IdEmployeers.Size = new System.Drawing.Size(59, 13);
            this.IdEmployeers.TabIndex = 10;
            this.IdEmployeers.Text = "Document:";
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
            // BuscarEmployeers
            // 
            this.BuscarEmployeers.Location = new System.Drawing.Point(180, 29);
            this.BuscarEmployeers.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarEmployeers.Name = "BuscarEmployeers";
            this.BuscarEmployeers.Size = new System.Drawing.Size(130, 20);
            this.BuscarEmployeers.TabIndex = 1;
            // 
            // SearchEmployeers
            // 
            this.SearchEmployeers.AutoSize = true;
            this.SearchEmployeers.Location = new System.Drawing.Point(16, 32);
            this.SearchEmployeers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchEmployeers.Name = "SearchEmployeers";
            this.SearchEmployeers.Size = new System.Drawing.Size(162, 13);
            this.SearchEmployeers.TabIndex = 0;
            this.SearchEmployeers.Text = "Search Employeers (Document): ";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 624);
            this.Controls.Add(this.ADMIN);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ADMIN.ResumeLayout(false);
            this.GestionClient.ResumeLayout(false);
            this.grpReports.ResumeLayout(false);
            this.grpInventory.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAdmin)).EndInit();
            this.grpManageArea.ResumeLayout(false);
            this.grpManageArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ADMIN;
        private System.Windows.Forms.GroupBox GestionClient;
        private System.Windows.Forms.Button GestorClient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpReports;
        private System.Windows.Forms.Button btnGenerateAdvanced;
        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.Button btnUpdateInventory;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView gridAdmin;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpManageArea;
        private System.Windows.Forms.TextBox RoleUser;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.TextBox PhoneEmpleado;
        private System.Windows.Forms.Label phoneEmployeers;
        private System.Windows.Forms.TextBox EmailEmpleado;
        private System.Windows.Forms.Label EmailEmployeers;
        private System.Windows.Forms.TextBox lastEmployeers;
        private System.Windows.Forms.Label LastNameEmployeers;
        private System.Windows.Forms.TextBox nombreEmployeers;
        private System.Windows.Forms.Label nameEmployeers;
        private System.Windows.Forms.TextBox idempleado;
        private System.Windows.Forms.Label IdEmployeers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BuscarEmployeers;
        private System.Windows.Forms.Label SearchEmployeers;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordEmployeers;
        private System.Windows.Forms.Button button2;
    }
}