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
            this.buttonInventoryExit = new System.Windows.Forms.Button();
            this.ListProducts = new System.Windows.Forms.GroupBox();
            this.gridAdmin = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ManageProduct = new System.Windows.Forms.GroupBox();
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
            this.LoadProducts = new System.Windows.Forms.Button();
            this.CategoryProduct = new System.Windows.Forms.TextBox();
            this.AdminInventoryProducts.SuspendLayout();
            this.ListProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdmin)).BeginInit();
            this.ManageProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminInventoryProducts
            // 
            this.AdminInventoryProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AdminInventoryProducts.Controls.Add(this.LoadProducts);
            this.AdminInventoryProducts.Controls.Add(this.buttonInventoryExit);
            this.AdminInventoryProducts.Controls.Add(this.ListProducts);
            this.AdminInventoryProducts.Controls.Add(this.btnDelete);
            this.AdminInventoryProducts.Controls.Add(this.btnEdit);
            this.AdminInventoryProducts.Controls.Add(this.btnAdd);
            this.AdminInventoryProducts.Controls.Add(this.ManageProduct);
            this.AdminInventoryProducts.Location = new System.Drawing.Point(-2, 2);
            this.AdminInventoryProducts.Name = "AdminInventoryProducts";
            this.AdminInventoryProducts.Size = new System.Drawing.Size(1563, 925);
            this.AdminInventoryProducts.TabIndex = 1;
            this.AdminInventoryProducts.TabStop = false;
            this.AdminInventoryProducts.Text = "Inventory";
            this.AdminInventoryProducts.Enter += new System.EventHandler(this.AdminInventoryProducts_Enter);
            // 
            // buttonInventoryExit
            // 
            this.buttonInventoryExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonInventoryExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventoryExit.Location = new System.Drawing.Point(1365, 868);
            this.buttonInventoryExit.Name = "buttonInventoryExit";
            this.buttonInventoryExit.Size = new System.Drawing.Size(159, 51);
            this.buttonInventoryExit.TabIndex = 7;
            this.buttonInventoryExit.Text = "EXIT";
            this.buttonInventoryExit.UseVisualStyleBackColor = false;
            this.buttonInventoryExit.Click += new System.EventHandler(this.buttonInventoryExit_Click);
            // 
            // ListProducts
            // 
            this.ListProducts.Controls.Add(this.gridAdmin);
            this.ListProducts.Location = new System.Drawing.Point(28, 398);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(1496, 468);
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
            this.gridAdmin.EnableHeadersVisualStyles = false;
            this.gridAdmin.GridColor = System.Drawing.Color.Black;
            this.gridAdmin.Location = new System.Drawing.Point(20, 25);
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
            this.gridAdmin.Size = new System.Drawing.Size(1460, 428);
            this.gridAdmin.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(868, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 51);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(578, 292);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 51);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(292, 292);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 51);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ManageProduct
            // 
            this.ManageProduct.Controls.Add(this.CategoryProduct);
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
            this.ManageProduct.Location = new System.Drawing.Point(28, 43);
            this.ManageProduct.Name = "ManageProduct";
            this.ManageProduct.Size = new System.Drawing.Size(1496, 202);
            this.ManageProduct.TabIndex = 1;
            this.ManageProduct.TabStop = false;
            this.ManageProduct.Text = "Manage Products";
            // 
            // CategoryProducts
            // 
            this.CategoryProducts.AutoSize = true;
            this.CategoryProducts.Location = new System.Drawing.Point(52, 165);
            this.CategoryProducts.Name = "CategoryProducts";
            this.CategoryProducts.Size = new System.Drawing.Size(77, 20);
            this.CategoryProducts.TabIndex = 21;
            this.CategoryProducts.Text = "Category:";
            // 
            // Stok
            // 
            this.Stok.Location = new System.Drawing.Point(1146, 105);
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(193, 26);
            this.Stok.TabIndex = 20;
            // 
            // StockProducts
            // 
            this.StockProducts.AutoSize = true;
            this.StockProducts.Location = new System.Drawing.Point(1077, 111);
            this.StockProducts.Name = "StockProducts";
            this.StockProducts.Size = new System.Drawing.Size(54, 20);
            this.StockProducts.TabIndex = 19;
            this.StockProducts.Text = "Stock:";
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.Location = new System.Drawing.Point(806, 108);
            this.PrecioProducto.Name = "PrecioProducto";
            this.PrecioProducto.Size = new System.Drawing.Size(193, 26);
            this.PrecioProducto.TabIndex = 18;
            // 
            // PriceProduct
            // 
            this.PriceProduct.AutoSize = true;
            this.PriceProduct.Location = new System.Drawing.Point(747, 111);
            this.PriceProduct.Name = "PriceProduct";
            this.PriceProduct.Size = new System.Drawing.Size(48, 20);
            this.PriceProduct.TabIndex = 17;
            this.PriceProduct.Text = "Price:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(482, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 26);
            this.textBox1.TabIndex = 16;
            // 
            // DescriptionProducto
            // 
            this.DescriptionProducto.AutoSize = true;
            this.DescriptionProducto.Location = new System.Drawing.Point(374, 111);
            this.DescriptionProducto.Name = "DescriptionProducto";
            this.DescriptionProducto.Size = new System.Drawing.Size(93, 20);
            this.DescriptionProducto.TabIndex = 15;
            this.DescriptionProducto.Text = "Description:";
            // 
            // nombreproduct
            // 
            this.nombreproduct.Location = new System.Drawing.Point(135, 111);
            this.nombreproduct.Name = "nombreproduct";
            this.nombreproduct.Size = new System.Drawing.Size(193, 26);
            this.nombreproduct.TabIndex = 14;
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSize = true;
            this.nameProduct.Location = new System.Drawing.Point(52, 112);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(55, 20);
            this.nameProduct.TabIndex = 13;
            this.nameProduct.Text = "Name:";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(458, 28);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(159, 51);
            this.search.TabIndex = 10;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // BuscarProduct
            // 
            this.BuscarProduct.Location = new System.Drawing.Point(230, 43);
            this.BuscarProduct.Name = "BuscarProduct";
            this.BuscarProduct.Size = new System.Drawing.Size(193, 26);
            this.BuscarProduct.TabIndex = 2;
            // 
            // SearchProducts
            // 
            this.SearchProducts.AutoSize = true;
            this.SearchProducts.Location = new System.Drawing.Point(52, 43);
            this.SearchProducts.Name = "SearchProducts";
            this.SearchProducts.Size = new System.Drawing.Size(163, 20);
            this.SearchProducts.TabIndex = 1;
            this.SearchProducts.Text = "Search Products (Id): ";
            // 
            // LoadProducts
            // 
            this.LoadProducts.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoadProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadProducts.Location = new System.Drawing.Point(1109, 292);
            this.LoadProducts.Name = "LoadProducts";
            this.LoadProducts.Size = new System.Drawing.Size(159, 51);
            this.LoadProducts.TabIndex = 8;
            this.LoadProducts.Text = "Load";
            this.LoadProducts.UseVisualStyleBackColor = false;
            this.LoadProducts.Click += new System.EventHandler(this.LoadProducts_Click);
            // 
            // CategoryProduct
            // 
            this.CategoryProduct.Location = new System.Drawing.Point(135, 159);
            this.CategoryProduct.Name = "CategoryProduct";
            this.CategoryProduct.Size = new System.Drawing.Size(193, 26);
            this.CategoryProduct.TabIndex = 22;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 925);
            this.Controls.Add(this.AdminInventoryProducts);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox ManageProduct;
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
        private System.Windows.Forms.Button LoadProducts;
        private System.Windows.Forms.TextBox CategoryProduct;
    }
}