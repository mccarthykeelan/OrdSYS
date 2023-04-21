
namespace OrdSYS
{
    partial class frmProducts
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
            tcProduct = new System.Windows.Forms.TabControl();
            tpSearchProducts = new System.Windows.Forms.TabPage();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnAddNew = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            tpAddProduct = new System.Windows.Forms.TabPage();
            tpUpdateProduct = new System.Windows.Forms.TabPage();
            tcProduct.SuspendLayout();
            tpSearchProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tcProduct
            // 
            tcProduct.Controls.Add(tpSearchProducts);
            tcProduct.Controls.Add(tpAddProduct);
            tcProduct.Controls.Add(tpUpdateProduct);
            tcProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            tcProduct.Location = new System.Drawing.Point(0, 0);
            tcProduct.Name = "tcProduct";
            tcProduct.SelectedIndex = 0;
            tcProduct.Size = new System.Drawing.Size(2079, 1035);
            tcProduct.TabIndex = 3;
            // 
            // tpSearchProducts
            // 
            tpSearchProducts.Controls.Add(btnDelete);
            tpSearchProducts.Controls.Add(btnUpdate);
            tpSearchProducts.Controls.Add(btnAddNew);
            tpSearchProducts.Controls.Add(btnSearch);
            tpSearchProducts.Controls.Add(lblSearch);
            tpSearchProducts.Controls.Add(txtSearch);
            tpSearchProducts.Controls.Add(dataGridView1);
            tpSearchProducts.Location = new System.Drawing.Point(10, 58);
            tpSearchProducts.Name = "tpSearchProducts";
            tpSearchProducts.Padding = new System.Windows.Forms.Padding(3);
            tpSearchProducts.Size = new System.Drawing.Size(2059, 967);
            tpSearchProducts.TabIndex = 0;
            tpSearchProducts.Text = "Search Products";
            tpSearchProducts.UseVisualStyleBackColor = true;
            tpSearchProducts.Click += tpSearchProducts_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnDelete.BackColor = System.Drawing.Color.FromArgb(243, 98, 94);
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(1688, 448);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(349, 95);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(95, 148, 240);
            btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(1688, 308);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(349, 95);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddNew.BackColor = System.Drawing.Color.FromArgb(53, 162, 113);
            btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddNew.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddNew.ForeColor = System.Drawing.Color.White;
            btnAddNew.Location = new System.Drawing.Point(1688, 170);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new System.Drawing.Size(349, 95);
            btnAddNew.TabIndex = 11;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSearch.BackColor = System.Drawing.Color.FromArgb(255, 164, 0);
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Location = new System.Drawing.Point(1402, 81);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(261, 70);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSearch.Location = new System.Drawing.Point(14, 16);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(372, 62);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search Products:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Location = new System.Drawing.Point(24, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(1342, 70);
            txtSearch.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(24, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.Height = 49;
            dataGridView1.Size = new System.Drawing.Size(1639, 781);
            dataGridView1.TabIndex = 7;
            // 
            // tpAddProduct
            // 
            tpAddProduct.Location = new System.Drawing.Point(10, 58);
            tpAddProduct.Name = "tpAddProduct";
            tpAddProduct.Padding = new System.Windows.Forms.Padding(3);
            tpAddProduct.Size = new System.Drawing.Size(2059, 967);
            tpAddProduct.TabIndex = 1;
            tpAddProduct.Text = "Add Product";
            tpAddProduct.UseVisualStyleBackColor = true;
            // 
            // tpUpdateProduct
            // 
            tpUpdateProduct.Location = new System.Drawing.Point(10, 58);
            tpUpdateProduct.Name = "tpUpdateProduct";
            tpUpdateProduct.Size = new System.Drawing.Size(2059, 967);
            tpUpdateProduct.TabIndex = 2;
            tpUpdateProduct.Text = "Update Product";
            tpUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2079, 1035);
            Controls.Add(tcProduct);
            Name = "frmProducts";
            Text = "Products";
            tcProduct.ResumeLayout(false);
            tpSearchProducts.ResumeLayout(false);
            tpSearchProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TabControl tcProduct;
        private System.Windows.Forms.TabPage tpSearchProducts;
        private System.Windows.Forms.TabPage tpAddProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tpUpdateProduct;
    }
}