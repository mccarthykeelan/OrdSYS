namespace OrdSYS.Views.Order
{
    partial class frmOrders
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
            tcTabControl = new System.Windows.Forms.TabControl();
            tpOrderSearch = new System.Windows.Forms.TabPage();
            btnAddNew = new System.Windows.Forms.Button();
            grdOrders = new System.Windows.Forms.DataGridView();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            tpOrderDetails = new System.Windows.Forms.TabPage();
            pnlCart = new System.Windows.Forms.Panel();
            btnCancel = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            grdCart = new System.Windows.Forms.DataGridView();
            pnlStock = new System.Windows.Forms.Panel();
            btnAdd = new System.Windows.Forms.Button();
            grdStock = new System.Windows.Forms.DataGridView();
            tcTabControl.SuspendLayout();
            tpOrderSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdOrders).BeginInit();
            tpOrderDetails.SuspendLayout();
            pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdCart).BeginInit();
            pnlStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdStock).BeginInit();
            SuspendLayout();
            // 
            // tcTabControl
            // 
            tcTabControl.Controls.Add(tpOrderSearch);
            tcTabControl.Controls.Add(tpOrderDetails);
            tcTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tcTabControl.Location = new System.Drawing.Point(0, 0);
            tcTabControl.Name = "tcTabControl";
            tcTabControl.SelectedIndex = 0;
            tcTabControl.Size = new System.Drawing.Size(2080, 1002);
            tcTabControl.TabIndex = 4;
            // 
            // tpOrderSearch
            // 
            tpOrderSearch.Controls.Add(btnAddNew);
            tpOrderSearch.Controls.Add(grdOrders);
            tpOrderSearch.Controls.Add(btnDelete);
            tpOrderSearch.Controls.Add(btnEdit);
            tpOrderSearch.Controls.Add(btnSearch);
            tpOrderSearch.Controls.Add(lblSearch);
            tpOrderSearch.Controls.Add(txtSearch);
            tpOrderSearch.Location = new System.Drawing.Point(10, 58);
            tpOrderSearch.Name = "tpOrderSearch";
            tpOrderSearch.Padding = new System.Windows.Forms.Padding(3);
            tpOrderSearch.Size = new System.Drawing.Size(2060, 934);
            tpOrderSearch.TabIndex = 0;
            tpOrderSearch.Text = "Search Orders";
            tpOrderSearch.UseVisualStyleBackColor = true;
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
            btnAddNew.TabIndex = 12;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            // 
            // grdOrders
            // 
            grdOrders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grdOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdOrders.Location = new System.Drawing.Point(30, 175);
            grdOrders.Margin = new System.Windows.Forms.Padding(4);
            grdOrders.Name = "grdOrders";
            grdOrders.RowHeadersWidth = 72;
            grdOrders.RowTemplate.Height = 37;
            grdOrders.Size = new System.Drawing.Size(1639, 731);
            grdOrders.TabIndex = 14;
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
            lblSearch.Location = new System.Drawing.Point(17, 19);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(329, 62);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search Orders:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Location = new System.Drawing.Point(27, 84);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(1341, 70);
            txtSearch.TabIndex = 8;
            // 
            // tpOrderDetails
            // 
            tpOrderDetails.Controls.Add(pnlCart);
            tpOrderDetails.Controls.Add(pnlStock);
            tpOrderDetails.Location = new System.Drawing.Point(10, 58);
            tpOrderDetails.Name = "tpOrderDetails";
            tpOrderDetails.Padding = new System.Windows.Forms.Padding(3);
            tpOrderDetails.Size = new System.Drawing.Size(2060, 1093);
            tpOrderDetails.TabIndex = 1;
            tpOrderDetails.Text = "Order Details";
            tpOrderDetails.UseVisualStyleBackColor = true;
            // 
            // pnlCart
            // 
            pnlCart.Controls.Add(btnCancel);
            pnlCart.Controls.Add(btnRemove);
            pnlCart.Controls.Add(grdCart);
            pnlCart.Dock = System.Windows.Forms.DockStyle.Top;
            pnlCart.Location = new System.Drawing.Point(3, 494);
            pnlCart.Name = "pnlCart";
            pnlCart.Size = new System.Drawing.Size(2054, 590);
            pnlCart.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(255, 164, 0);
            btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(0, 471);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(1025, 119);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = System.Drawing.Color.FromArgb(243, 98, 94);
            btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRemove.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRemove.ForeColor = System.Drawing.Color.White;
            btnRemove.Location = new System.Drawing.Point(0, 375);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(2054, 96);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove Product";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // grdCart
            // 
            grdCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCart.Dock = System.Windows.Forms.DockStyle.Top;
            grdCart.Location = new System.Drawing.Point(0, 0);
            grdCart.Name = "grdCart";
            grdCart.RowHeadersWidth = 102;
            grdCart.RowTemplate.Height = 49;
            grdCart.Size = new System.Drawing.Size(2054, 375);
            grdCart.TabIndex = 0;
            // 
            // pnlStock
            // 
            pnlStock.Controls.Add(btnAdd);
            pnlStock.Controls.Add(grdStock);
            pnlStock.Dock = System.Windows.Forms.DockStyle.Top;
            pnlStock.Location = new System.Drawing.Point(3, 3);
            pnlStock.Name = "pnlStock";
            pnlStock.Size = new System.Drawing.Size(2054, 491);
            pnlStock.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 0;
            // 
            // grdStock
            // 
            grdStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdStock.Dock = System.Windows.Forms.DockStyle.Top;
            grdStock.Location = new System.Drawing.Point(0, 0);
            grdStock.Name = "grdStock";
            grdStock.RowHeadersWidth = 102;
            grdStock.RowTemplate.Height = 49;
            grdStock.Size = new System.Drawing.Size(2054, 375);
            grdStock.TabIndex = 1;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2080, 1002);
            Controls.Add(tcTabControl);
            Name = "frmOrders";
            Text = "Orders";
            tcTabControl.ResumeLayout(false);
            tpOrderSearch.ResumeLayout(false);
            tpOrderSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdOrders).EndInit();
            tpOrderDetails.ResumeLayout(false);
            pnlCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdCart).EndInit();
            pnlStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tcTabControl;
        private System.Windows.Forms.TabPage tpOrderSearch;
        private System.Windows.Forms.DataGridView grdOrders;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tpOrderDetails;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView grdCart;
        private System.Windows.Forms.Panel pnlStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView grdStock;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNew;
    }
}