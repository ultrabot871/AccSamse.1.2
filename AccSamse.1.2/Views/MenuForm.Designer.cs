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
            this.textBoxNameUserMenuForm = new System.Windows.Forms.TextBox();
            this.textBoxRoleUserMenuForm = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateMenu = new System.Windows.Forms.DateTimePicker();
            this.LabelDateMenu = new System.Windows.Forms.Label();
            this.labelMenuRoleUser = new System.Windows.Forms.Label();
            this.labelMenuNameUser = new System.Windows.Forms.Label();
            this.groupBoxViewsSales = new System.Windows.Forms.GroupBox();
            this.dataGridViewSaleMenuForm = new System.Windows.Forms.DataGridView();
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
            this.groupBoxMenu.Controls.Add(this.textBoxNameUserMenuForm);
            this.groupBoxMenu.Controls.Add(this.textBoxRoleUserMenuForm);
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
            this.groupBoxMenu.Size = new System.Drawing.Size(998, 490);
            this.groupBoxMenu.TabIndex = 1;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            this.groupBoxMenu.Enter += new System.EventHandler(this.groupBoxMenu_Enter);
            // 
            // textBoxNameUserMenuForm
            // 
            this.textBoxNameUserMenuForm.Location = new System.Drawing.Point(437, 47);
            this.textBoxNameUserMenuForm.Name = "textBoxNameUserMenuForm";
            this.textBoxNameUserMenuForm.ReadOnly = true;
            this.textBoxNameUserMenuForm.Size = new System.Drawing.Size(100, 22);
            this.textBoxNameUserMenuForm.TabIndex = 13;
            // 
            // textBoxRoleUserMenuForm
            // 
            this.textBoxRoleUserMenuForm.Location = new System.Drawing.Point(436, 15);
            this.textBoxRoleUserMenuForm.Name = "textBoxRoleUserMenuForm";
            this.textBoxRoleUserMenuForm.ReadOnly = true;
            this.textBoxRoleUserMenuForm.Size = new System.Drawing.Size(100, 22);
            this.textBoxRoleUserMenuForm.TabIndex = 12;
            // 
            // dateTimePickerDateMenu
            // 
            this.dateTimePickerDateMenu.Enabled = false;
            this.dateTimePickerDateMenu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateMenu.Location = new System.Drawing.Point(63, 421);
            this.dateTimePickerDateMenu.Name = "dateTimePickerDateMenu";
            this.dateTimePickerDateMenu.Size = new System.Drawing.Size(109, 22);
            this.dateTimePickerDateMenu.TabIndex = 11;
            this.dateTimePickerDateMenu.ValueChanged += new System.EventHandler(this.dateTimePickerDateMenu_ValueChanged);
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
            this.groupBoxViewsSales.Size = new System.Drawing.Size(970, 338);
            this.groupBoxViewsSales.TabIndex = 4;
            this.groupBoxViewsSales.TabStop = false;
            this.groupBoxViewsSales.Text = "Sales";
            // 
            // dataGridViewSaleMenuForm
            // 
            this.dataGridViewSaleMenuForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleMenuForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSaleMenuForm.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewSaleMenuForm.Name = "dataGridViewSaleMenuForm";
            this.dataGridViewSaleMenuForm.RowHeadersWidth = 62;
            this.dataGridViewSaleMenuForm.Size = new System.Drawing.Size(964, 317);
            this.dataGridViewSaleMenuForm.TabIndex = 0;
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
            this.buttonOffSytem.Location = new System.Drawing.Point(878, 419);
            this.buttonOffSytem.Name = "buttonOffSytem";
            this.buttonOffSytem.Size = new System.Drawing.Size(104, 31);
            this.buttonOffSytem.TabIndex = 2;
            this.buttonOffSytem.Text = "Off System";
            this.buttonOffSytem.UseVisualStyleBackColor = true;
            this.buttonOffSytem.Click += new System.EventHandler(this.buttonOffSytem_Click);
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
            this.ClientSize = new System.Drawing.Size(998, 490);
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
        private System.Windows.Forms.TextBox textBoxNameUserMenuForm;
        private System.Windows.Forms.TextBox textBoxRoleUserMenuForm;
    }
}