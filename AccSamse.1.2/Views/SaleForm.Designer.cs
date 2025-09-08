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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodeProduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.comboBoxSaller = new System.Windows.Forms.ComboBox();
            this.labelSaller = new System.Windows.Forms.Label();
            this.dateTimePickerDateSale = new System.Windows.Forms.DateTimePicker();
            this.LabelDateSale = new System.Windows.Forms.Label();
            this.labelCodeSale = new System.Windows.Forms.Label();
            this.labelSaleNo = new System.Windows.Forms.Label();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.comboBoxSearchClient = new System.Windows.Forms.ComboBox();
            this.checkBoxMinorAmount = new System.Windows.Forms.CheckBox();
            this.labelClientSearch = new System.Windows.Forms.Label();
            this.groupBoxSaleForm.SuspendLayout();
            this.groupBoxFinishSale.SuspendLayout();
            this.groupBoxPayment.SuspendLayout();
            this.groupBoxProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBoxSaleForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSaleForm.Name = "groupBoxSaleForm";
            this.groupBoxSaleForm.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSaleForm.Size = new System.Drawing.Size(1242, 727);
            this.groupBoxSaleForm.TabIndex = 1;
            this.groupBoxSaleForm.TabStop = false;
            this.groupBoxSaleForm.Text = "Sale";
            // 
            // groupBoxFinishSale
            // 
            this.groupBoxFinishSale.Controls.Add(this.button1);
            this.groupBoxFinishSale.Controls.Add(this.textBoxTotalSale);
            this.groupBoxFinishSale.Controls.Add(this.labelTotalSale);
            this.groupBoxFinishSale.Location = new System.Drawing.Point(970, 192);
            this.groupBoxFinishSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFinishSale.Name = "groupBoxFinishSale";
            this.groupBoxFinishSale.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxFinishSale.Size = new System.Drawing.Size(212, 491);
            this.groupBoxFinishSale.TabIndex = 3;
            this.groupBoxFinishSale.TabStop = false;
            this.groupBoxFinishSale.Text = "FinishSale";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Finish sale";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxTotalSale
            // 
            this.textBoxTotalSale.Enabled = false;
            this.textBoxTotalSale.Location = new System.Drawing.Point(9, 68);
            this.textBoxTotalSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTotalSale.Name = "textBoxTotalSale";
            this.textBoxTotalSale.ReadOnly = true;
            this.textBoxTotalSale.Size = new System.Drawing.Size(192, 33);
            this.textBoxTotalSale.TabIndex = 2;
            // 
            // labelTotalSale
            // 
            this.labelTotalSale.AutoSize = true;
            this.labelTotalSale.Location = new System.Drawing.Point(9, 37);
            this.labelTotalSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalSale.Name = "labelTotalSale";
            this.labelTotalSale.Size = new System.Drawing.Size(95, 28);
            this.labelTotalSale.TabIndex = 1;
            this.labelTotalSale.Text = "Total Sale";
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.textBoxAmountPayment);
            this.groupBoxPayment.Controls.Add(this.labelAmountPayment);
            this.groupBoxPayment.Controls.Add(this.comboBoxPaymentMethod);
            this.groupBoxPayment.Controls.Add(this.labelPaymentMethod);
            this.groupBoxPayment.Location = new System.Drawing.Point(20, 591);
            this.groupBoxPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPayment.Size = new System.Drawing.Size(933, 92);
            this.groupBoxPayment.TabIndex = 2;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Payment";
            // 
            // textBoxAmountPayment
            // 
            this.textBoxAmountPayment.Location = new System.Drawing.Point(501, 37);
            this.textBoxAmountPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAmountPayment.Name = "textBoxAmountPayment";
            this.textBoxAmountPayment.Size = new System.Drawing.Size(232, 33);
            this.textBoxAmountPayment.TabIndex = 4;
            // 
            // labelAmountPayment
            // 
            this.labelAmountPayment.AutoSize = true;
            this.labelAmountPayment.Location = new System.Drawing.Point(412, 40);
            this.labelAmountPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmountPayment.Name = "labelAmountPayment";
            this.labelAmountPayment.Size = new System.Drawing.Size(83, 28);
            this.labelAmountPayment.TabIndex = 6;
            this.labelAmountPayment.Text = "Amount";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(177, 35);
            this.comboBoxPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPaymentMethod.MaxDropDownItems = 100;
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(210, 36);
            this.comboBoxPaymentMethod.TabIndex = 5;
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Location = new System.Drawing.Point(9, 40);
            this.labelPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(161, 28);
            this.labelPaymentMethod.TabIndex = 0;
            this.labelPaymentMethod.Text = "Payment method";
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.groupBox1);
            this.groupBoxProduct.Controls.Add(this.ButtonAddProduct);
            this.groupBoxProduct.Controls.Add(this.dataGridView1);
            this.groupBoxProduct.Controls.Add(this.textBox1);
            this.groupBoxProduct.Controls.Add(this.label1);
            this.groupBoxProduct.Location = new System.Drawing.Point(20, 192);
            this.groupBoxProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxProduct.Size = new System.Drawing.Size(933, 398);
            this.groupBoxProduct.TabIndex = 1;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Product";
            this.groupBoxProduct.Enter += new System.EventHandler(this.groupBoxProduct_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(942, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(172, 305);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(486, 37);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 33);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.MaxDropDownItems = 100;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 36);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Payment method";
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Location = new System.Drawing.Point(368, 28);
            this.ButtonAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(42, 35);
            this.ButtonAddProduct.TabIndex = 3;
            this.ButtonAddProduct.Text = "+";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeProduc,
            this.ProductName,
            this.StockProduct,
            this.PriceProduct,
            this.SubtotalProduct,
            this.DeleteProduct});
            this.dataGridView1.Location = new System.Drawing.Point(9, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(894, 231);
            this.dataGridView1.TabIndex = 2;
            // 
            // CodeProduc
            // 
            this.CodeProduc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 33);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search products";
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.comboBoxSaller);
            this.groupBoxClient.Controls.Add(this.labelSaller);
            this.groupBoxClient.Controls.Add(this.dateTimePickerDateSale);
            this.groupBoxClient.Controls.Add(this.LabelDateSale);
            this.groupBoxClient.Controls.Add(this.labelCodeSale);
            this.groupBoxClient.Controls.Add(this.labelSaleNo);
            this.groupBoxClient.Controls.Add(this.buttonNewClient);
            this.groupBoxClient.Controls.Add(this.comboBoxSearchClient);
            this.groupBoxClient.Controls.Add(this.checkBoxMinorAmount);
            this.groupBoxClient.Controls.Add(this.labelClientSearch);
            this.groupBoxClient.Location = new System.Drawing.Point(18, 29);
            this.groupBoxClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxClient.Size = new System.Drawing.Size(1164, 154);
            this.groupBoxClient.TabIndex = 0;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client-Saller";
            // 
            // comboBoxSaller
            // 
            this.comboBoxSaller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSaller.FormattingEnabled = true;
            this.comboBoxSaller.Location = new System.Drawing.Point(196, 88);
            this.comboBoxSaller.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSaller.MaxDropDownItems = 100;
            this.comboBoxSaller.Name = "comboBoxSaller";
            this.comboBoxSaller.Size = new System.Drawing.Size(462, 36);
            this.comboBoxSaller.TabIndex = 11;
            // 
            // labelSaller
            // 
            this.labelSaller.AutoSize = true;
            this.labelSaller.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaller.Location = new System.Drawing.Point(64, 91);
            this.labelSaller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaller.Name = "labelSaller";
            this.labelSaller.Size = new System.Drawing.Size(120, 28);
            this.labelSaller.TabIndex = 10;
            this.labelSaller.Text = "Saller search";
            // 
            // dateTimePickerDateSale
            // 
            this.dateTimePickerDateSale.Enabled = false;
            this.dateTimePickerDateSale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateSale.Location = new System.Drawing.Point(952, 72);
            this.dateTimePickerDateSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerDateSale.Name = "dateTimePickerDateSale";
            this.dateTimePickerDateSale.Size = new System.Drawing.Size(162, 33);
            this.dateTimePickerDateSale.TabIndex = 9;
            // 
            // LabelDateSale
            // 
            this.LabelDateSale.AutoSize = true;
            this.LabelDateSale.Location = new System.Drawing.Point(891, 78);
            this.LabelDateSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDateSale.Name = "LabelDateSale";
            this.LabelDateSale.Size = new System.Drawing.Size(53, 28);
            this.LabelDateSale.TabIndex = 8;
            this.LabelDateSale.Text = "Date";
            // 
            // labelCodeSale
            // 
            this.labelCodeSale.AutoSize = true;
            this.labelCodeSale.Location = new System.Drawing.Point(982, 40);
            this.labelCodeSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodeSale.Name = "labelCodeSale";
            this.labelCodeSale.Size = new System.Drawing.Size(97, 28);
            this.labelCodeSale.TabIndex = 7;
            this.labelCodeSale.Text = "S-000123";
            // 
            // labelSaleNo
            // 
            this.labelSaleNo.AutoSize = true;
            this.labelSaleNo.Location = new System.Drawing.Point(891, 40);
            this.labelSaleNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaleNo.Name = "labelSaleNo";
            this.labelSaleNo.Size = new System.Drawing.Size(80, 28);
            this.labelSaleNo.TabIndex = 6;
            this.labelSaleNo.Text = "Sale No";
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(700, 28);
            this.buttonNewClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(182, 43);
            this.buttonNewClient.TabIndex = 5;
            this.buttonNewClient.Text = "New client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            // 
            // comboBoxSearchClient
            // 
            this.comboBoxSearchClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchClient.FormattingEnabled = true;
            this.comboBoxSearchClient.Location = new System.Drawing.Point(196, 28);
            this.comboBoxSearchClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSearchClient.MaxDropDownItems = 100;
            this.comboBoxSearchClient.Name = "comboBoxSearchClient";
            this.comboBoxSearchClient.Size = new System.Drawing.Size(462, 36);
            this.comboBoxSearchClient.TabIndex = 4;
            // 
            // checkBoxMinorAmount
            // 
            this.checkBoxMinorAmount.AutoSize = true;
            this.checkBoxMinorAmount.Location = new System.Drawing.Point(700, 91);
            this.checkBoxMinorAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMinorAmount.Name = "checkBoxMinorAmount";
            this.checkBoxMinorAmount.Size = new System.Drawing.Size(164, 32);
            this.checkBoxMinorAmount.TabIndex = 3;
            this.checkBoxMinorAmount.Text = "Minor amount";
            this.checkBoxMinorAmount.UseVisualStyleBackColor = true;
            // 
            // labelClientSearch
            // 
            this.labelClientSearch.AutoSize = true;
            this.labelClientSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientSearch.Location = new System.Drawing.Point(64, 32);
            this.labelClientSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClientSearch.Name = "labelClientSearch";
            this.labelClientSearch.Size = new System.Drawing.Size(122, 28);
            this.labelClientSearch.TabIndex = 0;
            this.labelClientSearch.Text = "Client search";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 727);
            this.Controls.Add(this.groupBoxSaleForm);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.groupBoxSaleForm.ResumeLayout(false);
            this.groupBoxFinishSale.ResumeLayout(false);
            this.groupBoxFinishSale.PerformLayout();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalProduct;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteProduct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.ComboBox comboBoxSaller;
        private System.Windows.Forms.Label labelSaller;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateSale;
        private System.Windows.Forms.Label LabelDateSale;
        private System.Windows.Forms.Label labelCodeSale;
        private System.Windows.Forms.Label labelSaleNo;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.ComboBox comboBoxSearchClient;
        private System.Windows.Forms.CheckBox checkBoxMinorAmount;
        private System.Windows.Forms.Label labelClientSearch;
    }
}