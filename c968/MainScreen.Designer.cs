namespace c968
{
    partial class MainScreen
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
            this.labelIMS = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnPartsSearch = new System.Windows.Forms.Button();
            this.btnProductsSearch = new System.Windows.Forms.Button();
            this.searchBoxParts = new System.Windows.Forms.TextBox();
            this.searchBoxProducts = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnModifyPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.mainProductsGrid = new System.Windows.Forms.DataGridView();
            this.groupBoxParts = new System.Windows.Forms.GroupBox();
            this.mainPartsGrid = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBoxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainProductsGrid)).BeginInit();
            this.groupBoxParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIMS
            // 
            this.labelIMS.AutoSize = true;
            this.labelIMS.Location = new System.Drawing.Point(13, 13);
            this.labelIMS.Name = "labelIMS";
            this.labelIMS.Size = new System.Drawing.Size(153, 13);
            this.labelIMS.TabIndex = 0;
            this.labelIMS.Text = "Inventory Management System";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(34, 86);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(31, 13);
            this.lblParts.TabIndex = 1;
            this.lblParts.Text = "Parts";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(502, 86);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(49, 13);
            this.lblProducts.TabIndex = 2;
            this.lblProducts.Text = "Products";
            // 
            // btnPartsSearch
            // 
            this.btnPartsSearch.Location = new System.Drawing.Point(180, 17);
            this.btnPartsSearch.Name = "btnPartsSearch";
            this.btnPartsSearch.Size = new System.Drawing.Size(75, 23);
            this.btnPartsSearch.TabIndex = 3;
            this.btnPartsSearch.Text = "Search";
            this.btnPartsSearch.UseVisualStyleBackColor = true;
            this.btnPartsSearch.Click += new System.EventHandler(this.btnPartsSearch_Click);
            // 
            // btnProductsSearch
            // 
            this.btnProductsSearch.Location = new System.Drawing.Point(667, 87);
            this.btnProductsSearch.Name = "btnProductsSearch";
            this.btnProductsSearch.Size = new System.Drawing.Size(75, 23);
            this.btnProductsSearch.TabIndex = 4;
            this.btnProductsSearch.Text = "Search";
            this.btnProductsSearch.UseVisualStyleBackColor = true;
            this.btnProductsSearch.Click += new System.EventHandler(this.btnProductsSearch_Click);
            // 
            // searchBoxParts
            // 
            this.searchBoxParts.Location = new System.Drawing.Point(275, 18);
            this.searchBoxParts.Name = "searchBoxParts";
            this.searchBoxParts.Size = new System.Drawing.Size(125, 20);
            this.searchBoxParts.TabIndex = 5;
            // 
            // searchBoxProducts
            // 
            this.searchBoxProducts.Location = new System.Drawing.Point(772, 88);
            this.searchBoxProducts.Name = "searchBoxProducts";
            this.searchBoxProducts.Size = new System.Drawing.Size(125, 20);
            this.searchBoxProducts.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddPart);
            this.flowLayoutPanel1.Controls.Add(this.btnModifyPart);
            this.flowLayoutPanel1.Controls.Add(this.btnDeletePart);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(157, 250);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 25);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(3, 3);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 0;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnModifyPart
            // 
            this.btnModifyPart.Location = new System.Drawing.Point(84, 3);
            this.btnModifyPart.Name = "btnModifyPart";
            this.btnModifyPart.Size = new System.Drawing.Size(75, 23);
            this.btnModifyPart.TabIndex = 1;
            this.btnModifyPart.Text = "Modify";
            this.btnModifyPart.UseVisualStyleBackColor = true;
            this.btnModifyPart.Click += new System.EventHandler(this.btnModifyPart_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(165, 3);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePart.TabIndex = 2;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAddProduct);
            this.flowLayoutPanel2.Controls.Add(this.btnModifyProduct);
            this.flowLayoutPanel2.Controls.Add(this.btnDeleteProduct);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(630, 250);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(250, 25);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(84, 3);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(75, 23);
            this.btnModifyProduct.TabIndex = 1;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(165, 3);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(795, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.mainProductsGrid);
            this.groupBoxProducts.Location = new System.Drawing.Point(480, 68);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(436, 234);
            this.groupBoxProducts.TabIndex = 12;
            this.groupBoxProducts.TabStop = false;
            // 
            // mainProductsGrid
            // 
            this.mainProductsGrid.AllowUserToAddRows = false;
            this.mainProductsGrid.AllowUserToDeleteRows = false;
            this.mainProductsGrid.AllowUserToResizeColumns = false;
            this.mainProductsGrid.AllowUserToResizeRows = false;
            this.mainProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainProductsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mainProductsGrid.Location = new System.Drawing.Point(20, 48);
            this.mainProductsGrid.MultiSelect = false;
            this.mainProductsGrid.Name = "mainProductsGrid";
            this.mainProductsGrid.RowHeadersVisible = false;
            this.mainProductsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainProductsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainProductsGrid.Size = new System.Drawing.Size(400, 120);
            this.mainProductsGrid.TabIndex = 0;
            // 
            // groupBoxParts
            // 
            this.groupBoxParts.Controls.Add(this.mainPartsGrid);
            this.groupBoxParts.Controls.Add(this.btnPartsSearch);
            this.groupBoxParts.Controls.Add(this.searchBoxParts);
            this.groupBoxParts.Location = new System.Drawing.Point(26, 68);
            this.groupBoxParts.Name = "groupBoxParts";
            this.groupBoxParts.Size = new System.Drawing.Size(437, 234);
            this.groupBoxParts.TabIndex = 13;
            this.groupBoxParts.TabStop = false;
            // 
            // mainPartsGrid
            // 
            this.mainPartsGrid.AllowUserToAddRows = false;
            this.mainPartsGrid.AllowUserToDeleteRows = false;
            this.mainPartsGrid.AllowUserToResizeColumns = false;
            this.mainPartsGrid.AllowUserToResizeRows = false;
            this.mainPartsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainPartsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mainPartsGrid.Location = new System.Drawing.Point(16, 48);
            this.mainPartsGrid.MultiSelect = false;
            this.mainPartsGrid.Name = "mainPartsGrid";
            this.mainPartsGrid.RowHeadersVisible = false;
            this.mainPartsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainPartsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainPartsGrid.Size = new System.Drawing.Size(400, 120);
            this.mainPartsGrid.TabIndex = 6;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 386);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.searchBoxProducts);
            this.Controls.Add(this.btnProductsSearch);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.labelIMS);
            this.Controls.Add(this.groupBoxProducts);
            this.Controls.Add(this.groupBoxParts);
            this.Name = "MainScreen";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBoxProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainProductsGrid)).EndInit();
            this.groupBoxParts.ResumeLayout(false);
            this.groupBoxParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIMS;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnPartsSearch;
        private System.Windows.Forms.Button btnProductsSearch;
        private System.Windows.Forms.TextBox searchBoxParts;
        private System.Windows.Forms.TextBox searchBoxProducts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnModifyPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.GroupBox groupBoxParts;
        public  System.Windows.Forms.DataGridView mainProductsGrid;
        public  System.Windows.Forms.DataGridView mainPartsGrid;

        public int searchBoxPartsText
        {
            get { return int.Parse(searchBoxParts.Text); }
            set { searchBoxParts.Text = value.ToString(); }
        }
        
        public int searchBoxProductsText
        {
            get { return int.Parse(searchBoxProducts.Text); }
            set { searchBoxProducts.Text = value.ToString(); }
        }
    }
}

