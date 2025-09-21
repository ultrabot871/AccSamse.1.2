namespace AccSamse._1._2.Views
{
    partial class SaleForm
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
            this.groupBoxSaleForm = new System.Windows.Forms.GroupBox();
            this.groupBoxFinishSale = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTotalSale = new System.Windows.Forms.TextBox();
            this.labelTotalSale = new System.Windows.Forms.Label();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.textBoxAmountPayment = new System.Windows.Forms.TextBox();
            this.labelAmountPayment = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.CodeProduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TextBuscarProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.NameSallerSale = new System.Windows.Forms.TextBox();
            this.NameClientSale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.BuscarSallerSale = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BuscarClientSale = new System.Windows.Forms.TextBox();
            this.labelSaller = new System.Windows.Forms.Label();
            this.dateTimePickerDateSale = new System.Windows.Forms.DateTimePicker();
            this.LabelDateSale = new System.Windows.Forms.Label();
            this.labelSaleNo = new System.Windows.Forms.Label();
            this.labelClientSearch = new System.Windows.Forms.Label();
            this.textBoxSaleNo = new System.Windows.Forms.TextBox();
            this.ExitSaleForm = new System.Windows.Forms.Button();
            this.groupBoxSaleForm.SuspendLayout();
            this.groupBoxFinishSale.SuspendLayout();
            this.groupBoxPayment.SuspendLayout();
            this.groupBoxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSaleForm
            // 
            this.groupBoxSaleForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxSaleForm.Controls.Add(this.groupBoxFinishSale);
            this.groupBoxSaleForm.Controls.Add(this.groupBoxPayment);
            this.groupBoxSaleForm.Controls.Add(this.groupBoxProduct);
            this.groupBoxSaleForm.Controls.Add(this.groupBoxClient);
            this.groupBoxSaleForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSaleForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSaleForm.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSaleForm.Name = "groupBoxSaleForm";
            this.groupBoxSaleForm.Size = new System.Drawing.Size(1001, 452);
            this.groupBoxSaleForm.TabIndex = 1;
            this.groupBoxSaleForm.TabStop = false;
            this.groupBoxSaleForm.Text = "Sale";
            this.groupBoxSaleForm.Enter += new System.EventHandler(this.groupBoxSaleForm_Enter);
            // 
            // groupBoxFinishSale
            // 
            this.groupBoxFinishSale.Controls.Add(this.ExitSaleForm);
            this.groupBoxFinishSale.Controls.Add(this.button1);
            this.groupBoxFinishSale.Controls.Add(this.textBoxTotalSale);
            this.groupBoxFinishSale.Controls.Add(this.labelTotalSale);
            this.groupBoxFinishSale.Location = new System.Drawing.Point(852, 125);
            this.groupBoxFinishSale.Name = "groupBoxFinishSale";
            this.groupBoxFinishSale.Size = new System.Drawing.Size(141, 319);
            this.groupBoxFinishSale.TabIndex = 3;
            this.groupBoxFinishSale.TabStop = false;
            this.groupBoxFinishSale.Text = "FinishSale";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Finish sale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTotalSale
            // 
            this.textBoxTotalSale.Enabled = false;
            this.textBoxTotalSale.Location = new System.Drawing.Point(6, 44);
            this.textBoxTotalSale.Name = "textBoxTotalSale";
            this.textBoxTotalSale.ReadOnly = true;
            this.textBoxTotalSale.Size = new System.Drawing.Size(129, 25);
            this.textBoxTotalSale.TabIndex = 2;
            // 
            // labelTotalSale
            // 
            this.labelTotalSale.AutoSize = true;
            this.labelTotalSale.Location = new System.Drawing.Point(6, 24);
            this.labelTotalSale.Name = "labelTotalSale";
            this.labelTotalSale.Size = new System.Drawing.Size(64, 17);
            this.labelTotalSale.TabIndex = 1;
            this.labelTotalSale.Text = "Total Sale";
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.textBoxAmountPayment);
            this.groupBoxPayment.Controls.Add(this.labelAmountPayment);
            this.groupBoxPayment.Controls.Add(this.comboBoxPaymentMethod);
            this.groupBoxPayment.Controls.Add(this.labelPaymentMethod);
            this.groupBoxPayment.Location = new System.Drawing.Point(13, 384);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(833, 60);
            this.groupBoxPayment.TabIndex = 2;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Payment";
            // 
            // textBoxAmountPayment
            // 
            this.textBoxAmountPayment.Location = new System.Drawing.Point(334, 23);
            this.textBoxAmountPayment.Name = "textBoxAmountPayment";
            this.textBoxAmountPayment.Size = new System.Drawing.Size(156, 25);
            this.textBoxAmountPayment.TabIndex = 4;
            // 
            // labelAmountPayment
            // 
            this.labelAmountPayment.AutoSize = true;
            this.labelAmountPayment.Location = new System.Drawing.Point(275, 26);
            this.labelAmountPayment.Name = "labelAmountPayment";
            this.labelAmountPayment.Size = new System.Drawing.Size(53, 17);
            this.labelAmountPayment.TabIndex = 6;
            this.labelAmountPayment.Text = "Amount";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Items.AddRange(new object[] {
            "Debito",
            "Credito",
            "Efectivo"});
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(118, 23);
            this.comboBoxPaymentMethod.MaxDropDownItems = 100;
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(141, 25);
            this.comboBoxPaymentMethod.TabIndex = 5;
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Location = new System.Drawing.Point(6, 26);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(106, 17);
            this.labelPaymentMethod.TabIndex = 0;
            this.labelPaymentMethod.Text = "Payment method";
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.ButtonAddProduct);
            this.groupBoxProduct.Controls.Add(this.dataGridViewProducts);
            this.groupBoxProduct.Controls.Add(this.TextBuscarProduct);
            this.groupBoxProduct.Controls.Add(this.label1);
            this.groupBoxProduct.Location = new System.Drawing.Point(13, 125);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(833, 259);
            this.groupBoxProduct.TabIndex = 1;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Product";
            this.groupBoxProduct.Enter += new System.EventHandler(this.groupBoxProduct_Enter);
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Location = new System.Drawing.Point(259, 20);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(28, 23);
            this.ButtonAddProduct.TabIndex = 3;
            this.ButtonAddProduct.Text = "+";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeProduc,
            this.ProductName,
            this.StockProduct,
            this.PriceProduct,
            this.SubtotalProduct,
            this.DeleteProduct});
            this.dataGridViewProducts.Location = new System.Drawing.Point(6, 63);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.Size = new System.Drawing.Size(816, 150);
            this.dataGridViewProducts.TabIndex = 2;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            // 
            // CodeProduc
            // 
            this.CodeProduc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodeProduc.FillWeight = 50F;
            this.CodeProduc.HeaderText = "Code";
            this.CodeProduc.MinimumWidth = 8;
            this.CodeProduc.Name = "CodeProduc";
            this.CodeProduc.Width = 101;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 150;
            // 
            // StockProduct
            // 
            this.StockProduct.HeaderText = "Stock";
            this.StockProduct.MinimumWidth = 8;
            this.StockProduct.Name = "StockProduct";
            this.StockProduct.Width = 150;
            // 
            // PriceProduct
            // 
            this.PriceProduct.HeaderText = "Price";
            this.PriceProduct.MinimumWidth = 8;
            this.PriceProduct.Name = "PriceProduct";
            this.PriceProduct.Width = 150;
            // 
            // SubtotalProduct
            // 
            this.SubtotalProduct.HeaderText = "Subtotal";
            this.SubtotalProduct.MinimumWidth = 8;
            this.SubtotalProduct.Name = "SubtotalProduct";
            this.SubtotalProduct.Width = 150;
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.HeaderText = "Delete";
            this.DeleteProduct.MinimumWidth = 8;
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Text = "-";
            this.DeleteProduct.Width = 50;
            // 
            // TextBuscarProduct
            // 
            this.TextBuscarProduct.Location = new System.Drawing.Point(153, 18);
            this.TextBuscarProduct.Name = "TextBuscarProduct";
            this.TextBuscarProduct.Size = new System.Drawing.Size(100, 25);
            this.TextBuscarProduct.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search products (id)";
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.textBoxSaleNo);
            this.groupBoxClient.Controls.Add(this.NameSallerSale);
            this.groupBoxClient.Controls.Add(this.NameClientSale);
            this.groupBoxClient.Controls.Add(this.label5);
            this.groupBoxClient.Controls.Add(this.label4);
            this.groupBoxClient.Controls.Add(this.button3);
            this.groupBoxClient.Controls.Add(this.BuscarSallerSale);
            this.groupBoxClient.Controls.Add(this.button2);
            this.groupBoxClient.Controls.Add(this.BuscarClientSale);
            this.groupBoxClient.Controls.Add(this.labelSaller);
            this.groupBoxClient.Controls.Add(this.dateTimePickerDateSale);
            this.groupBoxClient.Controls.Add(this.LabelDateSale);
            this.groupBoxClient.Controls.Add(this.labelSaleNo);
            this.groupBoxClient.Controls.Add(this.labelClientSearch);
            this.groupBoxClient.Location = new System.Drawing.Point(12, 19);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(981, 100);
            this.groupBoxClient.TabIndex = 0;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client-Saller";
            this.groupBoxClient.Enter += new System.EventHandler(this.groupBoxClient_Enter);
            // 
            // NameSallerSale
            // 
            this.NameSallerSale.Location = new System.Drawing.Point(471, 56);
            this.NameSallerSale.Margin = new System.Windows.Forms.Padding(2);
            this.NameSallerSale.Name = "NameSallerSale";
            this.NameSallerSale.Size = new System.Drawing.Size(130, 25);
            this.NameSallerSale.TabIndex = 19;
            // 
            // NameClientSale
            // 
            this.NameClientSale.Location = new System.Drawing.Point(471, 18);
            this.NameClientSale.Margin = new System.Windows.Forms.Padding(2);
            this.NameClientSale.Name = "NameClientSale";
            this.NameClientSale.Size = new System.Drawing.Size(130, 25);
            this.NameClientSale.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Saller name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Client name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(279, 51);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 33);
            this.button3.TabIndex = 15;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BuscarSallerSale
            // 
            this.BuscarSallerSale.Location = new System.Drawing.Point(130, 56);
            this.BuscarSallerSale.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarSallerSale.Name = "BuscarSallerSale";
            this.BuscarSallerSale.Size = new System.Drawing.Size(130, 25);
            this.BuscarSallerSale.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(279, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BuscarClientSale
            // 
            this.BuscarClientSale.Location = new System.Drawing.Point(131, 18);
            this.BuscarClientSale.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarClientSale.Name = "BuscarClientSale";
            this.BuscarClientSale.Size = new System.Drawing.Size(130, 25);
            this.BuscarClientSale.TabIndex = 12;
            // 
            // labelSaller
            // 
            this.labelSaller.AutoSize = true;
            this.labelSaller.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaller.Location = new System.Drawing.Point(43, 59);
            this.labelSaller.Name = "labelSaller";
            this.labelSaller.Size = new System.Drawing.Size(82, 17);
            this.labelSaller.TabIndex = 10;
            this.labelSaller.Text = "Saller search";
            // 
            // dateTimePickerDateSale
            // 
            this.dateTimePickerDateSale.Enabled = false;
            this.dateTimePickerDateSale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateSale.Location = new System.Drawing.Point(849, 63);
            this.dateTimePickerDateSale.Name = "dateTimePickerDateSale";
            this.dateTimePickerDateSale.Size = new System.Drawing.Size(109, 25);
            this.dateTimePickerDateSale.TabIndex = 9;
            this.dateTimePickerDateSale.ValueChanged += new System.EventHandler(this.dateTimePickerDateSale_ValueChanged);
            // 
            // LabelDateSale
            // 
            this.LabelDateSale.AutoSize = true;
            this.LabelDateSale.Location = new System.Drawing.Point(799, 69);
            this.LabelDateSale.Name = "LabelDateSale";
            this.LabelDateSale.Size = new System.Drawing.Size(35, 17);
            this.LabelDateSale.TabIndex = 8;
            this.LabelDateSale.Text = "Date";
            // 
            // labelSaleNo
            // 
            this.labelSaleNo.AutoSize = true;
            this.labelSaleNo.Location = new System.Drawing.Point(780, 29);
            this.labelSaleNo.Name = "labelSaleNo";
            this.labelSaleNo.Size = new System.Drawing.Size(54, 17);
            this.labelSaleNo.TabIndex = 6;
            this.labelSaleNo.Text = "Sale No";
            // 
            // labelClientSearch
            // 
            this.labelClientSearch.AutoSize = true;
            this.labelClientSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientSearch.Location = new System.Drawing.Point(43, 21);
            this.labelClientSearch.Name = "labelClientSearch";
            this.labelClientSearch.Size = new System.Drawing.Size(82, 17);
            this.labelClientSearch.TabIndex = 0;
            this.labelClientSearch.Text = "Client search";
            // 
            // textBoxSaleNo
            // 
            this.textBoxSaleNo.Location = new System.Drawing.Point(839, 26);
            this.textBoxSaleNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSaleNo.Name = "textBoxSaleNo";
            this.textBoxSaleNo.ReadOnly = true;
            this.textBoxSaleNo.Size = new System.Drawing.Size(130, 25);
            this.textBoxSaleNo.TabIndex = 20;
            this.textBoxSaleNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ExitSaleForm
            // 
            this.ExitSaleForm.Location = new System.Drawing.Point(9, 245);
            this.ExitSaleForm.Name = "ExitSaleForm";
            this.ExitSaleForm.Size = new System.Drawing.Size(121, 28);
            this.ExitSaleForm.TabIndex = 7;
            this.ExitSaleForm.Text = "Exit sale";
            this.ExitSaleForm.UseVisualStyleBackColor = true;
            this.ExitSaleForm.Click += new System.EventHandler(this.button4_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 452);
            this.Controls.Add(this.groupBoxSaleForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.groupBoxSaleForm.ResumeLayout(false);
            this.groupBoxFinishSale.ResumeLayout(false);
            this.groupBoxFinishSale.PerformLayout();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSaleForm;
        private System.Windows.Forms.GroupBox groupBoxFinishSale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTotalSale;
        private System.Windows.Forms.Label labelTotalSale;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.TextBox textBoxAmountPayment;
        private System.Windows.Forms.Label labelAmountPayment;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.TextBox TextBuscarProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Label labelSaller;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateSale;
        private System.Windows.Forms.Label LabelDateSale;
        private System.Windows.Forms.Label labelSaleNo;
        private System.Windows.Forms.Label labelClientSearch;
        private System.Windows.Forms.TextBox BuscarClientSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox BuscarSallerSale;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameSallerSale;
        private System.Windows.Forms.TextBox NameClientSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalProduct;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteProduct;
        private System.Windows.Forms.TextBox textBoxSaleNo;
        private System.Windows.Forms.Button ExitSaleForm;
    }
}