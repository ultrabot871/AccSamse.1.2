namespace AccSamse._1._2.Views
{
    partial class MenuForm
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
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateMenu = new System.Windows.Forms.DateTimePicker();
            this.LabelDateMenu = new System.Windows.Forms.Label();
            this.labelMenuRoleUser = new System.Windows.Forms.Label();
            this.labelMenuNameUser = new System.Windows.Forms.Label();
            this.groupBoxViewsSales = new System.Windows.Forms.GroupBox();
            this.dataGridViewSaleMenuForm = new System.Windows.Forms.DataGridView();
            this.id_SaleMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateSaleMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateSaleMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSaleMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteSaleMenu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditSaleMenu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonEntryAdministration = new System.Windows.Forms.Button();
            this.buttonOffSytem = new System.Windows.Forms.Button();
            this.buttonEntryInventory = new System.Windows.Forms.Button();
            this.buttonEntrySale = new System.Windows.Forms.Button();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxViewsSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleMenuForm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxMenu.Controls.Add(this.dateTimePickerDateMenu);
            this.groupBoxMenu.Controls.Add(this.LabelDateMenu);
            this.groupBoxMenu.Controls.Add(this.labelMenuRoleUser);
            this.groupBoxMenu.Controls.Add(this.labelMenuNameUser);
            this.groupBoxMenu.Controls.Add(this.groupBoxViewsSales);
            this.groupBoxMenu.Controls.Add(this.buttonEntryAdministration);
            this.groupBoxMenu.Controls.Add(this.buttonOffSytem);
            this.groupBoxMenu.Controls.Add(this.buttonEntryInventory);
            this.groupBoxMenu.Controls.Add(this.buttonEntrySale);
            this.groupBoxMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMenu.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(816, 490);
            this.groupBoxMenu.TabIndex = 1;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            this.groupBoxMenu.Enter += new System.EventHandler(this.groupBoxMenu_Enter);
            // 
            // dateTimePickerDateMenu
            // 
            this.dateTimePickerDateMenu.Enabled = false;
            this.dateTimePickerDateMenu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateMenu.Location = new System.Drawing.Point(63, 421);
            this.dateTimePickerDateMenu.Name = "dateTimePickerDateMenu";
            this.dateTimePickerDateMenu.Size = new System.Drawing.Size(109, 22);
            this.dateTimePickerDateMenu.TabIndex = 11;
            // 
            // LabelDateMenu
            // 
            this.LabelDateMenu.AutoSize = true;
            this.LabelDateMenu.Location = new System.Drawing.Point(22, 425);
            this.LabelDateMenu.Name = "LabelDateMenu";
            this.LabelDateMenu.Size = new System.Drawing.Size(31, 13);
            this.LabelDateMenu.TabIndex = 10;
            this.LabelDateMenu.Text = "Date";
            // 
            // labelMenuRoleUser
            // 
            this.labelMenuRoleUser.AutoSize = true;
            this.labelMenuRoleUser.Location = new System.Drawing.Point(400, 18);
            this.labelMenuRoleUser.Name = "labelMenuRoleUser";
            this.labelMenuRoleUser.Size = new System.Drawing.Size(30, 13);
            this.labelMenuRoleUser.TabIndex = 6;
            this.labelMenuRoleUser.Text = "Role";
            // 
            // labelMenuNameUser
            // 
            this.labelMenuNameUser.AutoSize = true;
            this.labelMenuNameUser.Location = new System.Drawing.Point(400, 47);
            this.labelMenuNameUser.Name = "labelMenuNameUser";
            this.labelMenuNameUser.Size = new System.Drawing.Size(30, 13);
            this.labelMenuNameUser.TabIndex = 5;
            this.labelMenuNameUser.Text = "User";
            // 
            // groupBoxViewsSales
            // 
            this.groupBoxViewsSales.Controls.Add(this.dataGridViewSaleMenuForm);
            this.groupBoxViewsSales.Location = new System.Drawing.Point(12, 71);
            this.groupBoxViewsSales.Name = "groupBoxViewsSales";
            this.groupBoxViewsSales.Size = new System.Drawing.Size(799, 338);
            this.groupBoxViewsSales.TabIndex = 4;
            this.groupBoxViewsSales.TabStop = false;
            this.groupBoxViewsSales.Text = "Sales";
            // 
            // dataGridViewSaleMenuForm
            // 
            this.dataGridViewSaleMenuForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleMenuForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_SaleMenu,
            this.DateSaleMenu,
            this.StateSaleMenu,
            this.TotalSaleMenu,
            this.DeleteSaleMenu,
            this.EditSaleMenu});
            this.dataGridViewSaleMenuForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSaleMenuForm.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewSaleMenuForm.Name = "dataGridViewSaleMenuForm";
            this.dataGridViewSaleMenuForm.RowHeadersWidth = 62;
            this.dataGridViewSaleMenuForm.Size = new System.Drawing.Size(793, 317);
            this.dataGridViewSaleMenuForm.TabIndex = 0;
            // 
            // id_SaleMenu
            // 
            this.id_SaleMenu.HeaderText = "Sale No";
            this.id_SaleMenu.MinimumWidth = 8;
            this.id_SaleMenu.Name = "id_SaleMenu";
            this.id_SaleMenu.Width = 150;
            // 
            // DateSaleMenu
            // 
            this.DateSaleMenu.HeaderText = "Date";
            this.DateSaleMenu.MinimumWidth = 8;
            this.DateSaleMenu.Name = "DateSaleMenu";
            this.DateSaleMenu.Width = 150;
            // 
            // StateSaleMenu
            // 
            this.StateSaleMenu.HeaderText = "State";
            this.StateSaleMenu.MinimumWidth = 8;
            this.StateSaleMenu.Name = "StateSaleMenu";
            this.StateSaleMenu.Width = 180;
            // 
            // TotalSaleMenu
            // 
            this.TotalSaleMenu.HeaderText = "Total";
            this.TotalSaleMenu.MinimumWidth = 8;
            this.TotalSaleMenu.Name = "TotalSaleMenu";
            this.TotalSaleMenu.Width = 150;
            // 
            // DeleteSaleMenu
            // 
            this.DeleteSaleMenu.HeaderText = "Delete";
            this.DeleteSaleMenu.MinimumWidth = 8;
            this.DeleteSaleMenu.Name = "DeleteSaleMenu";
            this.DeleteSaleMenu.Width = 50;
            // 
            // EditSaleMenu
            // 
            this.EditSaleMenu.HeaderText = "Edit";
            this.EditSaleMenu.MinimumWidth = 8;
            this.EditSaleMenu.Name = "EditSaleMenu";
            this.EditSaleMenu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditSaleMenu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditSaleMenu.Width = 50;
            // 
            // buttonEntryAdministration
            // 
            this.buttonEntryAdministration.Location = new System.Drawing.Point(254, 42);
            this.buttonEntryAdministration.Name = "buttonEntryAdministration";
            this.buttonEntryAdministration.Size = new System.Drawing.Size(99, 23);
            this.buttonEntryAdministration.TabIndex = 3;
            this.buttonEntryAdministration.Text = "Administration";
            this.buttonEntryAdministration.UseVisualStyleBackColor = true;
            this.buttonEntryAdministration.Click += new System.EventHandler(this.buttonEntryAdministration_Click);
            // 
            // buttonOffSytem
            // 
            this.buttonOffSytem.Location = new System.Drawing.Point(690, 413);
            this.buttonOffSytem.Name = "buttonOffSytem";
            this.buttonOffSytem.Size = new System.Drawing.Size(104, 31);
            this.buttonOffSytem.TabIndex = 2;
            this.buttonOffSytem.Text = "Off System";
            this.buttonOffSytem.UseVisualStyleBackColor = true;
            // 
            // buttonEntryInventory
            // 
            this.buttonEntryInventory.Location = new System.Drawing.Point(139, 42);
            this.buttonEntryInventory.Name = "buttonEntryInventory";
            this.buttonEntryInventory.Size = new System.Drawing.Size(99, 23);
            this.buttonEntryInventory.TabIndex = 1;
            this.buttonEntryInventory.Text = "Inventory";
            this.buttonEntryInventory.UseVisualStyleBackColor = true;
            this.buttonEntryInventory.Click += new System.EventHandler(this.buttonEntryInventory_Click);
            // 
            // buttonEntrySale
            // 
            this.buttonEntrySale.Location = new System.Drawing.Point(25, 42);
            this.buttonEntrySale.Name = "buttonEntrySale";
            this.buttonEntrySale.Size = new System.Drawing.Size(99, 23);
            this.buttonEntrySale.TabIndex = 0;
            this.buttonEntrySale.Text = "Sale";
            this.buttonEntrySale.UseVisualStyleBackColor = true;
            this.buttonEntrySale.Click += new System.EventHandler(this.buttonEntrySale_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 490);
            this.Controls.Add(this.groupBoxMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.groupBoxViewsSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleMenuForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateMenu;
        private System.Windows.Forms.Label LabelDateMenu;
        private System.Windows.Forms.Label labelMenuRoleUser;
        private System.Windows.Forms.Label labelMenuNameUser;
        private System.Windows.Forms.GroupBox groupBoxViewsSales;
        private System.Windows.Forms.DataGridView dataGridViewSaleMenuForm;
        private System.Windows.Forms.Button buttonEntryAdministration;
        private System.Windows.Forms.Button buttonOffSytem;
        private System.Windows.Forms.Button buttonEntryInventory;
        private System.Windows.Forms.Button buttonEntrySale;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_SaleMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateSaleMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateSaleMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSaleMenu;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteSaleMenu;
        private System.Windows.Forms.DataGridViewButtonColumn EditSaleMenu;
    }
}