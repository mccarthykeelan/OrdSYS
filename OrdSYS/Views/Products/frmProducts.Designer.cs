
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
            tpProductDetails = new System.Windows.Forms.TabPage();
            grpProductDetails = new System.Windows.Forms.GroupBox();
            cboStatus = new System.Windows.Forms.ComboBox();
            nudPrice = new System.Windows.Forms.NumericUpDown();
            nudQuantityAvailable = new System.Windows.Forms.NumericUpDown();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            lblQuantityAvailable = new System.Windows.Forms.Label();
            lblPrice = new System.Windows.Forms.Label();
            txtProductDescription = new System.Windows.Forms.TextBox();
            lblDescription = new System.Windows.Forms.Label();
            txtProductName = new System.Windows.Forms.TextBox();
            lblProductName = new System.Windows.Forms.Label();
            txtProductID = new System.Windows.Forms.TextBox();
            lblProductID = new System.Windows.Forms.Label();
            tpSearchProducts = new System.Windows.Forms.TabPage();
            grdProducts = new System.Windows.Forms.DataGridView();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnAddNew = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            tcTabControl = new System.Windows.Forms.TabControl();
            tpProductDetails.SuspendLayout();
            grpProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantityAvailable).BeginInit();
            tpSearchProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdProducts).BeginInit();
            tcTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tpProductDetails
            // 
            tpProductDetails.Controls.Add(grpProductDetails);
            tpProductDetails.Location = new System.Drawing.Point(10, 58);
            tpProductDetails.Name = "tpProductDetails";
            tpProductDetails.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            tpProductDetails.Size = new System.Drawing.Size(2060, 1008);
            tpProductDetails.TabIndex = 1;
            tpProductDetails.Text = "Product Details";
            tpProductDetails.UseVisualStyleBackColor = true;
            // 
            // grpProductDetails
            // 
            grpProductDetails.Controls.Add(cboStatus);
            grpProductDetails.Controls.Add(nudPrice);
            grpProductDetails.Controls.Add(nudQuantityAvailable);
            grpProductDetails.Controls.Add(btnCancel);
            grpProductDetails.Controls.Add(btnSave);
            grpProductDetails.Controls.Add(lblStatus);
            grpProductDetails.Controls.Add(lblQuantityAvailable);
            grpProductDetails.Controls.Add(lblPrice);
            grpProductDetails.Controls.Add(txtProductDescription);
            grpProductDetails.Controls.Add(lblDescription);
            grpProductDetails.Controls.Add(txtProductName);
            grpProductDetails.Controls.Add(lblProductName);
            grpProductDetails.Controls.Add(txtProductID);
            grpProductDetails.Controls.Add(lblProductID);
            grpProductDetails.Location = new System.Drawing.Point(623, 56);
            grpProductDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            grpProductDetails.Name = "grpProductDetails";
            grpProductDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            grpProductDetails.Size = new System.Drawing.Size(812, 916);
            grpProductDetails.TabIndex = 1;
            grpProductDetails.TabStop = false;
            grpProductDetails.Text = "Product Details";
            // 
            // cboStatus
            // 
            cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Unavilable" });
            cboStatus.Location = new System.Drawing.Point(60, 757);
            cboStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new System.Drawing.Size(299, 49);
            cboStatus.TabIndex = 9;
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrice.Location = new System.Drawing.Point(60, 493);
            nudPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new System.Drawing.Size(298, 47);
            nudPrice.TabIndex = 5;
            nudPrice.ThousandsSeparator = true;
            // 
            // nudQuantityAvailable
            // 
            nudQuantityAvailable.Location = new System.Drawing.Point(60, 629);
            nudQuantityAvailable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            nudQuantityAvailable.Name = "nudQuantityAvailable";
            nudQuantityAvailable.Size = new System.Drawing.Size(298, 47);
            nudQuantityAvailable.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Location = new System.Drawing.Point(424, 834);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(336, 55);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Location = new System.Drawing.Point(60, 834);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(336, 55);
            btnSave.TabIndex = 10;
            btnSave.Text = "Add Product";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(60, 698);
            lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(217, 41);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Product Status:";
            // 
            // lblQuantityAvailable
            // 
            lblQuantityAvailable.AutoSize = true;
            lblQuantityAvailable.Location = new System.Drawing.Point(60, 571);
            lblQuantityAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblQuantityAvailable.Name = "lblQuantityAvailable";
            lblQuantityAvailable.Size = new System.Drawing.Size(264, 41);
            lblQuantityAvailable.TabIndex = 6;
            lblQuantityAvailable.Text = "Quantity Available:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(60, 446);
            lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(89, 41);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // txtProductDescription
            // 
            txtProductDescription.Location = new System.Drawing.Point(60, 368);
            txtProductDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new System.Drawing.Size(408, 47);
            txtProductDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(60, 323);
            lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(176, 41);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(60, 250);
            txtProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(408, 47);
            txtProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new System.Drawing.Point(60, 205);
            lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new System.Drawing.Size(216, 41);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name:";
            // 
            // txtProductID
            // 
            txtProductID.BackColor = System.Drawing.Color.Black;
            txtProductID.ForeColor = System.Drawing.Color.White;
            txtProductID.Location = new System.Drawing.Point(306, 119);
            txtProductID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(195, 47);
            txtProductID.TabIndex = 1;
            txtProductID.TabStop = false;
            txtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new System.Drawing.Point(322, 74);
            lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new System.Drawing.Size(166, 41);
            lblProductID.TabIndex = 0;
            lblProductID.Text = "Product ID:";
            // 
            // tpSearchProducts
            // 
            tpSearchProducts.Controls.Add(grdProducts);
            tpSearchProducts.Controls.Add(btnDelete);
            tpSearchProducts.Controls.Add(btnEdit);
            tpSearchProducts.Controls.Add(btnAddNew);
            tpSearchProducts.Controls.Add(btnSearch);
            tpSearchProducts.Controls.Add(lblSearch);
            tpSearchProducts.Controls.Add(txtSearch);
            tpSearchProducts.Location = new System.Drawing.Point(10, 58);
            tpSearchProducts.Name = "tpSearchProducts";
            tpSearchProducts.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            tpSearchProducts.Size = new System.Drawing.Size(2060, 1008);
            tpSearchProducts.TabIndex = 0;
            tpSearchProducts.Text = "Search Products";
            tpSearchProducts.UseVisualStyleBackColor = true;
            // 
            // grdProducts
            // 
            grdProducts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProducts.Location = new System.Drawing.Point(24, 169);
            grdProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            grdProducts.Name = "grdProducts";
            grdProducts.RowHeadersWidth = 72;
            grdProducts.RowTemplate.Height = 37;
            grdProducts.Size = new System.Drawing.Size(1639, 823);
            grdProducts.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnDelete.BackColor = System.Drawing.Color.FromArgb(243, 98, 94);
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(1689, 448);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(348, 96);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnEdit.BackColor = System.Drawing.Color.FromArgb(95, 148, 240);
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEdit.ForeColor = System.Drawing.Color.White;
            btnEdit.Location = new System.Drawing.Point(1689, 308);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(348, 96);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddNew.BackColor = System.Drawing.Color.FromArgb(53, 162, 113);
            btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddNew.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddNew.ForeColor = System.Drawing.Color.White;
            btnAddNew.Location = new System.Drawing.Point(1689, 169);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new System.Drawing.Size(348, 96);
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
            txtSearch.Size = new System.Drawing.Size(1341, 70);
            txtSearch.TabIndex = 8;
            // 
            // tcTabControl
            // 
            tcTabControl.Controls.Add(tpSearchProducts);
            tcTabControl.Controls.Add(tpProductDetails);
            tcTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tcTabControl.Location = new System.Drawing.Point(0, 0);
            tcTabControl.Name = "tcTabControl";
            tcTabControl.SelectedIndex = 0;
            tcTabControl.Size = new System.Drawing.Size(2080, 1076);
            tcTabControl.TabIndex = 3;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2080, 1076);
            Controls.Add(tcTabControl);
            Name = "frmProducts";
            Text = "Products";
            tpProductDetails.ResumeLayout(false);
            grpProductDetails.ResumeLayout(false);
            grpProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantityAvailable).EndInit();
            tpSearchProducts.ResumeLayout(false);
            tpSearchProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdProducts).EndInit();
            tcTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tpProductDetails;
        private System.Windows.Forms.GroupBox grpProductDetails;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudQuantityAvailable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblQuantityAvailable;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TabPage tpSearchProducts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabControl tcTabControl;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView grdProducts;
    }
}