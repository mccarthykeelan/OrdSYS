namespace OrdSYS.Views.User
{
    partial class frmCustomers
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
            tpSearchUsers = new System.Windows.Forms.TabPage();
            grdUsers = new System.Windows.Forms.DataGridView();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnAddNew = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            tpUserDetails = new System.Windows.Forms.TabPage();
            grpUserDetails = new System.Windows.Forms.GroupBox();
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
            tcTabControl.SuspendLayout();
            tpSearchUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsers).BeginInit();
            tpUserDetails.SuspendLayout();
            grpUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantityAvailable).BeginInit();
            SuspendLayout();
            // 
            // tcTabControl
            // 
            tcTabControl.Controls.Add(tpSearchUsers);
            tcTabControl.Controls.Add(tpUserDetails);
            tcTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tcTabControl.Location = new System.Drawing.Point(0, 0);
            tcTabControl.Name = "tcTabControl";
            tcTabControl.SelectedIndex = 0;
            tcTabControl.Size = new System.Drawing.Size(2080, 1076);
            tcTabControl.TabIndex = 5;
            // 
            // tpSearchUsers
            // 
            tpSearchUsers.Controls.Add(grdUsers);
            tpSearchUsers.Controls.Add(btnDelete);
            tpSearchUsers.Controls.Add(btnEdit);
            tpSearchUsers.Controls.Add(btnAddNew);
            tpSearchUsers.Controls.Add(btnSearch);
            tpSearchUsers.Controls.Add(lblSearch);
            tpSearchUsers.Controls.Add(txtSearch);
            tpSearchUsers.Location = new System.Drawing.Point(10, 58);
            tpSearchUsers.Name = "tpSearchUsers";
            tpSearchUsers.Padding = new System.Windows.Forms.Padding(3);
            tpSearchUsers.Size = new System.Drawing.Size(2060, 1008);
            tpSearchUsers.TabIndex = 0;
            tpSearchUsers.Text = "Search Users";
            tpSearchUsers.UseVisualStyleBackColor = true;
            // 
            // grdUsers
            // 
            grdUsers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUsers.Location = new System.Drawing.Point(30, 175);
            grdUsers.Margin = new System.Windows.Forms.Padding(4);
            grdUsers.Name = "grdUsers";
            grdUsers.RowHeadersWidth = 72;
            grdUsers.RowTemplate.Height = 37;
            grdUsers.Size = new System.Drawing.Size(1639, 823);
            grdUsers.TabIndex = 14;
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
            lblSearch.Location = new System.Drawing.Point(20, 22);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(302, 62);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search Users:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.Location = new System.Drawing.Point(30, 87);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(1341, 70);
            txtSearch.TabIndex = 8;
            // 
            // tpUserDetails
            // 
            tpUserDetails.Controls.Add(grpUserDetails);
            tpUserDetails.Location = new System.Drawing.Point(10, 58);
            tpUserDetails.Name = "tpUserDetails";
            tpUserDetails.Padding = new System.Windows.Forms.Padding(3);
            tpUserDetails.Size = new System.Drawing.Size(2060, 1008);
            tpUserDetails.TabIndex = 1;
            tpUserDetails.Text = "User Details";
            tpUserDetails.UseVisualStyleBackColor = true;
            // 
            // grpUserDetails
            // 
            grpUserDetails.Controls.Add(cboStatus);
            grpUserDetails.Controls.Add(nudPrice);
            grpUserDetails.Controls.Add(nudQuantityAvailable);
            grpUserDetails.Controls.Add(btnCancel);
            grpUserDetails.Controls.Add(btnSave);
            grpUserDetails.Controls.Add(lblStatus);
            grpUserDetails.Controls.Add(lblQuantityAvailable);
            grpUserDetails.Controls.Add(lblPrice);
            grpUserDetails.Controls.Add(txtProductDescription);
            grpUserDetails.Controls.Add(lblDescription);
            grpUserDetails.Controls.Add(txtProductName);
            grpUserDetails.Controls.Add(lblProductName);
            grpUserDetails.Controls.Add(txtProductID);
            grpUserDetails.Controls.Add(lblProductID);
            grpUserDetails.Location = new System.Drawing.Point(623, 56);
            grpUserDetails.Margin = new System.Windows.Forms.Padding(4);
            grpUserDetails.Name = "grpUserDetails";
            grpUserDetails.Padding = new System.Windows.Forms.Padding(4);
            grpUserDetails.Size = new System.Drawing.Size(812, 916);
            grpUserDetails.TabIndex = 1;
            grpUserDetails.TabStop = false;
            grpUserDetails.Text = "Product Details";
            // 
            // cboStatus
            // 
            cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Available", "Unavilable" });
            cboStatus.Location = new System.Drawing.Point(60, 757);
            cboStatus.Margin = new System.Windows.Forms.Padding(4);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new System.Drawing.Size(299, 49);
            cboStatus.TabIndex = 9;
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrice.Location = new System.Drawing.Point(60, 493);
            nudPrice.Margin = new System.Windows.Forms.Padding(4);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new System.Drawing.Size(298, 47);
            nudPrice.TabIndex = 5;
            nudPrice.ThousandsSeparator = true;
            // 
            // nudQuantityAvailable
            // 
            nudQuantityAvailable.Location = new System.Drawing.Point(60, 629);
            nudQuantityAvailable.Margin = new System.Windows.Forms.Padding(4);
            nudQuantityAvailable.Name = "nudQuantityAvailable";
            nudQuantityAvailable.Size = new System.Drawing.Size(298, 47);
            nudQuantityAvailable.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Location = new System.Drawing.Point(424, 834);
            btnCancel.Margin = new System.Windows.Forms.Padding(4);
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
            btnSave.Margin = new System.Windows.Forms.Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(336, 55);
            btnSave.TabIndex = 10;
            btnSave.Text = "Add Product";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(62, 700);
            lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(217, 41);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Product Status:";
            // 
            // lblQuantityAvailable
            // 
            lblQuantityAvailable.AutoSize = true;
            lblQuantityAvailable.Location = new System.Drawing.Point(62, 573);
            lblQuantityAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblQuantityAvailable.Name = "lblQuantityAvailable";
            lblQuantityAvailable.Size = new System.Drawing.Size(264, 41);
            lblQuantityAvailable.TabIndex = 6;
            lblQuantityAvailable.Text = "Quantity Available:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(62, 448);
            lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(89, 41);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // txtProductDescription
            // 
            txtProductDescription.Location = new System.Drawing.Point(60, 368);
            txtProductDescription.Margin = new System.Windows.Forms.Padding(4);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new System.Drawing.Size(408, 47);
            txtProductDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(62, 325);
            lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(176, 41);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(60, 250);
            txtProductName.Margin = new System.Windows.Forms.Padding(4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(408, 47);
            txtProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new System.Drawing.Point(62, 207);
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
            txtProductID.Margin = new System.Windows.Forms.Padding(4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(195, 47);
            txtProductID.TabIndex = 1;
            txtProductID.TabStop = false;
            txtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new System.Drawing.Point(324, 76);
            lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new System.Drawing.Size(166, 41);
            lblProductID.TabIndex = 0;
            lblProductID.Text = "Product ID:";
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2080, 1076);
            Controls.Add(tcTabControl);
            Name = "frmCustomers";
            Text = "Users";
            tcTabControl.ResumeLayout(false);
            tpSearchUsers.ResumeLayout(false);
            tpSearchUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsers).EndInit();
            tpUserDetails.ResumeLayout(false);
            grpUserDetails.ResumeLayout(false);
            grpUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantityAvailable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tcTabControl;
        private System.Windows.Forms.TabPage tpSearchUsers;
        private System.Windows.Forms.DataGridView grdUsers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tpUserDetails;
        private System.Windows.Forms.GroupBox grpUserDetails;
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
    }
}