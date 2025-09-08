namespace AccSamse._1._2.Views
{
    partial class Inventory
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
            this.AdminInventoryProducts = new System.Windows.Forms.GroupBox();
            this.ListProducts = new System.Windows.Forms.GroupBox();
            this.gridAdmin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ManageProduct = new System.Windows.Forms.GroupBox();
            this.categoriaProducts = new System.Windows.Forms.ComboBox();
            this.CategoryProducts = new System.Windows.Forms.Label();
            this.Stok = new System.Windows.Forms.TextBox();
            this.StockProducts = new System.Windows.Forms.Label();
            this.PrecioProducto = new System.Windows.Forms.TextBox();
            this.PriceProduct = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DescriptionProducto = new System.Windows.Forms.Label();
            this.nombreproduct = new System.Windows.Forms.TextBox();
            this.nameProduct = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.BuscarProduct = new System.Windows.Forms.TextBox();
            this.SearchProducts = new System.Windows.Forms.Label();
            this.buttonInventoryExit = new System.Windows.Forms.Button();
            this.AdminInventoryProducts.SuspendLayout();
            this.ListProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdmin)).BeginInit();
            this.ManageProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminInventoryProducts
            // 
            this.AdminInventoryProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AdminInventoryProducts.Controls.Add(this.buttonInventoryExit);
            this.AdminInventoryProducts.Controls.Add(this.ListProducts);
            this.AdminInventoryProducts.Controls.Add(this.btnDelete);
            this.AdminInventoryProducts.Controls.Add(this.btnEdit);
            this.AdminInventoryProducts.Controls.Add(this.btnAdd);
            this.AdminInventoryProducts.Controls.Add(this.ManageProduct);
            this.AdminInventoryProducts.Location = new System.Drawing.Point(-1, 1);
            this.AdminInventoryProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminInventoryProducts.Name = "AdminInventoryProducts";
            this.AdminInventoryProducts.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminInventoryProducts.Size = new System.Drawing.Size(1042, 601);
            this.AdminInventoryProducts.TabIndex = 1;
            this.AdminInventoryProducts.TabStop = false;
            this.AdminInventoryProducts.Text = "Inventory";
            // 
            // ListProducts
            // 
            this.ListProducts.Controls.Add(this.gridAdmin);
            this.ListProducts.Location = new System.Drawing.Point(19, 259);
            this.ListProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListProducts.Size = new System.Drawing.Size(997, 304);
            this.ListProducts.TabIndex = 6;
            this.ListProducts.TabStop = false;
            this.ListProducts.Text = "List";
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
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gridAdmin.EnableHeadersVisualStyles = false;
            this.gridAdmin.GridColor = System.Drawing.Color.Black;
            this.gridAdmin.Location = new System.Drawing.Point(13, 16);
            this.gridAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.gridAdmin.Size = new System.Drawing.Size(973, 278);
            this.gridAdmin.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id_Product";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
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
            this.Column3.HeaderText = "Categoria";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "State";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Stock";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(579, 190);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 33);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(385, 190);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 33);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(195, 190);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // ManageProduct
            // 
            this.ManageProduct.Controls.Add(this.categoriaProducts);
            this.ManageProduct.Controls.Add(this.CategoryProducts);
            this.ManageProduct.Controls.Add(this.Stok);
            this.ManageProduct.Controls.Add(this.StockProducts);
            this.ManageProduct.Controls.Add(this.PrecioProducto);
            this.ManageProduct.Controls.Add(this.PriceProduct);
            this.ManageProduct.Controls.Add(this.textBox1);
            this.ManageProduct.Controls.Add(this.DescriptionProducto);
            this.ManageProduct.Controls.Add(this.nombreproduct);
            this.ManageProduct.Controls.Add(this.nameProduct);
            this.ManageProduct.Controls.Add(this.search);
            this.ManageProduct.Controls.Add(this.BuscarProduct);
            this.ManageProduct.Controls.Add(this.SearchProducts);
            this.ManageProduct.Location = new System.Drawing.Point(19, 28);
            this.ManageProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManageProduct.Name = "ManageProduct";
            this.ManageProduct.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManageProduct.Size = new System.Drawing.Size(997, 131);
            this.ManageProduct.TabIndex = 1;
            this.ManageProduct.TabStop = false;
            this.ManageProduct.Text = "Manage Products";
            // 
            // categoriaProducts
            // 
            this.categoriaProducts.FormattingEnabled = true;
            this.categoriaProducts.Location = new System.Drawing.Point(90, 105);
            this.categoriaProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoriaProducts.Name = "categoriaProducts";
            this.categoriaProducts.Size = new System.Drawing.Size(130, 21);
            this.categoriaProducts.TabIndex = 22;
            // 
            // CategoryProducts
            // 
            this.CategoryProducts.AutoSize = true;
            this.CategoryProducts.Location = new System.Drawing.Point(35, 107);
            this.CategoryProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryProducts.Name = "CategoryProducts";
            this.CategoryProducts.Size = new System.Drawing.Size(52, 13);
            this.CategoryProducts.TabIndex = 21;
            this.CategoryProducts.Text = "Category:";
            // 
            // Stok
            // 
            this.Stok.Location = new System.Drawing.Point(764, 68);
            this.Stok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(130, 20);
            this.Stok.TabIndex = 20;
            // 
            // StockProducts
            // 
            this.StockProducts.AutoSize = true;
            this.StockProducts.Location = new System.Drawing.Point(718, 72);
            this.StockProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StockProducts.Name = "StockProducts";
            this.StockProducts.Size = new System.Drawing.Size(38, 13);
            this.StockProducts.TabIndex = 19;
            this.StockProducts.Text = "Stock:";
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.Location = new System.Drawing.Point(537, 70);
            this.PrecioProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.Size = new System.Drawing.Size(130, 20);
            this.PrecioProducto.TabIndex = 18;
            // 
            // PriceProduct
            // 
            this.PriceProduct.AutoSize = true;
            this.PriceProduct.Location = new System.Drawing.Point(498, 72);
            this.PriceProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceProduct.Name = "PriceProduct";
            this.PriceProduct.Size = new System.Drawing.Size(34, 13);
            this.PriceProduct.TabIndex = 17;
            this.PriceProduct.Text = "Price:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 16;
            // 
            // DescriptionProducto
            // 
            this.DescriptionProducto.AutoSize = true;
            this.DescriptionProducto.Location = new System.Drawing.Point(249, 72);
            this.DescriptionProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionProducto.Name = "DescriptionProducto";
            this.DescriptionProducto.Size = new System.Drawing.Size(63, 13);
            this.DescriptionProducto.TabIndex = 15;
            this.DescriptionProducto.Text = "Description:";
            // 
            // nombreproduct
            // 
            this.nombreproduct.Location = new System.Drawing.Point(90, 72);
            this.nombreproduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreproduct.Name = "nombreproduct";
            this.nombreproduct.Size = new System.Drawing.Size(130, 20);
            this.nombreproduct.TabIndex = 14;
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSize = true;
            this.nameProduct.Location = new System.Drawing.Point(35, 73);
            this.nameProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(38, 13);
            this.nameProduct.TabIndex = 13;
            this.nameProduct.Text = "Name:";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(305, 18);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(106, 33);
            this.search.TabIndex = 10;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            // 
            // BuscarProduct
            // 
            this.BuscarProduct.Location = new System.Drawing.Point(153, 28);
            this.BuscarProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuscarProduct.Name = "BuscarProduct";
            this.BuscarProduct.Size = new System.Drawing.Size(130, 20);
            this.BuscarProduct.TabIndex = 2;
            // 
            // SearchProducts
            // 
            this.SearchProducts.AutoSize = true;
            this.SearchProducts.Location = new System.Drawing.Point(35, 28);
            this.SearchProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchProducts.Name = "SearchProducts";
            this.SearchProducts.Size = new System.Drawing.Size(110, 13);
            this.SearchProducts.TabIndex = 1;
            this.SearchProducts.Text = "Search Products (Id): ";
            // 
            // buttonInventoryExit
            // 
            this.buttonInventoryExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonInventoryExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventoryExit.Location = new System.Drawing.Point(910, 564);
            this.buttonInventoryExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInventoryExit.Name = "buttonInventoryExit";
            this.buttonInventoryExit.Size = new System.Drawing.Size(106, 33);
            this.buttonInventoryExit.TabIndex = 7;
            this.buttonInventoryExit.Text = "EXIT";
            this.buttonInventoryExit.UseVisualStyleBackColor = false;
            this.buttonInventoryExit.Click += new System.EventHandler(this.buttonInventoryExit_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 601);
            this.Controls.Add(this.AdminInventoryProducts);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.AdminInventoryProducts.ResumeLayout(false);
            this.ListProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAdmin)).EndInit();
            this.ManageProduct.ResumeLayout(false);
            this.ManageProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AdminInventoryProducts;
        private System.Windows.Forms.GroupBox ListProducts;
        private System.Windows.Forms.DataGridView gridAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox ManageProduct;
        private System.Windows.Forms.ComboBox categoriaProducts;
        private System.Windows.Forms.Label CategoryProducts;
        private System.Windows.Forms.TextBox Stok;
        private System.Windows.Forms.Label StockProducts;
        private System.Windows.Forms.TextBox PrecioProducto;
        private System.Windows.Forms.Label PriceProduct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DescriptionProducto;
        private System.Windows.Forms.TextBox nombreproduct;
        private System.Windows.Forms.Label nameProduct;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox BuscarProduct;
        private System.Windows.Forms.Label SearchProducts;
        private System.Windows.Forms.Button buttonInventoryExit;
    }
}