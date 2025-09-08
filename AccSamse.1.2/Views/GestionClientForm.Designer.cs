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
            this.btnExit = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.gridAdmin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridAdmin)).BeginInit();
            this.grpManageArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // ADMIN
            // 
            this.ADMIN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ADMIN.Controls.Add(this.btnExit);
            this.ADMIN.Controls.Add(this.grpList);
            this.ADMIN.Controls.Add(this.btnEdit);
            this.ADMIN.Controls.Add(this.btnDelete);
            this.ADMIN.Controls.Add(this.btnAdd);
            this.ADMIN.Controls.Add(this.grpManageArea);
            this.ADMIN.Location = new System.Drawing.Point(1, -1);
            this.ADMIN.Name = "ADMIN";
            this.ADMIN.Size = new System.Drawing.Size(1590, 937);
            this.ADMIN.TabIndex = 2;
            this.ADMIN.TabStop = false;
            this.ADMIN.Text = "GestionClients";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1382, 849);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 51);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.gridAdmin);
            this.grpList.Location = new System.Drawing.Point(31, 394);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(1472, 434);
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
            this.gridAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gridAdmin.EnableHeadersVisualStyles = false;
            this.gridAdmin.GridColor = System.Drawing.Color.Black;
            this.gridAdmin.Location = new System.Drawing.Point(28, 35);
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
            this.gridAdmin.Size = new System.Drawing.Size(1394, 368);
            this.gridAdmin.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Document";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "email";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(672, 337);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 51);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(1146, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 51);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(271, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 51);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
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
            this.grpManageArea.Location = new System.Drawing.Point(31, 51);
            this.grpManageArea.Name = "grpManageArea";
            this.grpManageArea.Size = new System.Drawing.Size(1490, 248);
            this.grpManageArea.TabIndex = 0;
            this.grpManageArea.TabStop = false;
            this.grpManageArea.Text = "Manage area";
            // 
            // PhoneClient
            // 
            this.PhoneClient.Location = new System.Drawing.Point(660, 163);
            this.PhoneClient.Name = "PhoneClient";
            this.PhoneClient.Size = new System.Drawing.Size(193, 26);
            this.PhoneClient.TabIndex = 19;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(554, 166);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(59, 20);
            this.phone.TabIndex = 18;
            this.phone.Text = "Phone:";
            // 
            // EmailClient
            // 
            this.EmailClient.Location = new System.Drawing.Point(139, 169);
            this.EmailClient.Name = "EmailClient";
            this.EmailClient.Size = new System.Drawing.Size(193, 26);
            this.EmailClient.TabIndex = 17;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(24, 169);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(52, 20);
            this.Email.TabIndex = 16;
            this.Email.Text = "Email:";
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(1177, 103);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(193, 26);
            this.last.TabIndex = 15;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(1051, 106);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(90, 20);
            this.LastName.TabIndex = 14;
            this.LastName.Text = "Last Name:";
            // 
            // nombreClient
            // 
            this.nombreClient.Location = new System.Drawing.Point(660, 103);
            this.nombreClient.Name = "nombreClient";
            this.nombreClient.Size = new System.Drawing.Size(193, 26);
            this.nombreClient.TabIndex = 13;
            // 
            // nameClient
            // 
            this.nameClient.AutoSize = true;
            this.nameClient.Location = new System.Drawing.Point(554, 106);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(55, 20);
            this.nameClient.TabIndex = 12;
            this.nameClient.Text = "Name:";
            // 
            // idcliente
            // 
            this.idcliente.Location = new System.Drawing.Point(139, 109);
            this.idcliente.Name = "idcliente";
            this.idcliente.Size = new System.Drawing.Size(193, 26);
            this.idcliente.TabIndex = 11;
            // 
            // IdClient
            // 
            this.IdClient.AutoSize = true;
            this.IdClient.Location = new System.Drawing.Point(24, 109);
            this.IdClient.Name = "IdClient";
            this.IdClient.Size = new System.Drawing.Size(87, 20);
            this.IdClient.TabIndex = 10;
            this.IdClient.Text = "Document:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(507, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BuscarClient
            // 
            this.BuscarClient.Location = new System.Drawing.Point(240, 44);
            this.BuscarClient.Name = "BuscarClient";
            this.BuscarClient.Size = new System.Drawing.Size(193, 26);
            this.BuscarClient.TabIndex = 1;
            // 
            // SearchClient
            // 
            this.SearchClient.AutoSize = true;
            this.SearchClient.Location = new System.Drawing.Point(33, 44);
            this.SearchClient.Name = "SearchClient";
            this.SearchClient.Size = new System.Drawing.Size(148, 20);
            this.SearchClient.TabIndex = 0;
            this.SearchClient.Text = "Search Clients (Id): ";
            // 
            // GestionClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 928);
            this.Controls.Add(this.ADMIN);
            this.Name = "GestionClientForm";
            this.Text = "GestionClientForm";
            this.ADMIN.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAdmin)).EndInit();
            this.grpManageArea.ResumeLayout(false);
            this.grpManageArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ADMIN;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView gridAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
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
    }
}