﻿namespace OrdSYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            pnlMenu = new System.Windows.Forms.Panel();
            btnLogs = new System.Windows.Forms.Button();
            btnCustomers = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnStatements = new System.Windows.Forms.Button();
            btnOrders = new System.Windows.Forms.Button();
            btnProducts = new System.Windows.Forms.Button();
            pnlLogo = new System.Windows.Forms.Panel();
            lblUsername = new System.Windows.Forms.Label();
            picLogo = new System.Windows.Forms.PictureBox();
            pnlTitleBar = new System.Windows.Forms.Panel();
            lblChildForm = new System.Windows.Forms.Label();
            pnlDesktop = new System.Windows.Forms.Panel();
            picOrderSYS = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlTitleBar.SuspendLayout();
            pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOrderSYS).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
            pnlMenu.Controls.Add(button1);
            pnlMenu.Controls.Add(btnLogs);
            pnlMenu.Controls.Add(btnCustomers);
            pnlMenu.Controls.Add(btnExit);
            pnlMenu.Controls.Add(btnStatements);
            pnlMenu.Controls.Add(btnOrders);
            pnlMenu.Controls.Add(btnProducts);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            pnlMenu.Location = new System.Drawing.Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new System.Drawing.Size(540, 1117);
            pnlMenu.TabIndex = 0;
            // 
            // btnLogs
            // 
            btnLogs.Dock = System.Windows.Forms.DockStyle.Top;
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogs.ForeColor = System.Drawing.Color.White;
            btnLogs.Location = new System.Drawing.Point(0, 718);
            btnLogs.Name = "btnLogs";
            btnLogs.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            btnLogs.Size = new System.Drawing.Size(540, 108);
            btnLogs.TabIndex = 7;
            btnLogs.Text = "View Logs";
            btnLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCustomers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCustomers.ForeColor = System.Drawing.Color.White;
            btnCustomers.Location = new System.Drawing.Point(0, 610);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            btnCustomers.Size = new System.Drawing.Size(540, 108);
            btnCustomers.TabIndex = 6;
            btnCustomers.Text = "Manage Customers";
            btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnUsers_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnExit.Location = new System.Drawing.Point(0, 1009);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(540, 108);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnStatements
            // 
            btnStatements.Dock = System.Windows.Forms.DockStyle.Top;
            btnStatements.FlatAppearance.BorderSize = 0;
            btnStatements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStatements.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStatements.ForeColor = System.Drawing.Color.White;
            btnStatements.Location = new System.Drawing.Point(0, 502);
            btnStatements.Name = "btnStatements";
            btnStatements.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            btnStatements.Size = new System.Drawing.Size(540, 108);
            btnStatements.TabIndex = 3;
            btnStatements.Text = "Statements";
            btnStatements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStatements.UseVisualStyleBackColor = true;
            btnStatements.Click += btnOrders_Click;
            // 
            // btnOrders
            // 
            btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOrders.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOrders.ForeColor = System.Drawing.Color.White;
            btnOrders.Location = new System.Drawing.Point(0, 394);
            btnOrders.Name = "btnOrders";
            btnOrders.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            btnOrders.Size = new System.Drawing.Size(540, 108);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Orders";
            btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click_1;
            // 
            // btnProducts
            // 
            btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProducts.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnProducts.ForeColor = System.Drawing.Color.White;
            btnProducts.Location = new System.Drawing.Point(0, 286);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            btnProducts.Size = new System.Drawing.Size(540, 108);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(lblUsername);
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            pnlLogo.Location = new System.Drawing.Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new System.Drawing.Size(540, 286);
            pnlLogo.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUsername.ForeColor = System.Drawing.Color.White;
            lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblUsername.Location = new System.Drawing.Point(148, 215);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(240, 54);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "USERNAME";
            lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLogo
            // 
            picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(540, 202);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click_1;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
            pnlTitleBar.Controls.Add(lblChildForm);
            pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTitleBar.Location = new System.Drawing.Point(540, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new System.Drawing.Size(1559, 126);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // lblChildForm
            // 
            lblChildForm.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblChildForm.AutoSize = true;
            lblChildForm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblChildForm.ForeColor = System.Drawing.Color.White;
            lblChildForm.Location = new System.Drawing.Point(650, 40);
            lblChildForm.Name = "lblChildForm";
            lblChildForm.Size = new System.Drawing.Size(160, 62);
            lblChildForm.TabIndex = 0;
            lblChildForm.Text = "Home";
            lblChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDesktop
            // 
            pnlDesktop.Controls.Add(picOrderSYS);
            pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDesktop.Location = new System.Drawing.Point(540, 126);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new System.Drawing.Size(1559, 991);
            pnlDesktop.TabIndex = 2;
            // 
            // picOrderSYS
            // 
            picOrderSYS.Dock = System.Windows.Forms.DockStyle.Fill;
            picOrderSYS.Image = Properties.Resources.OrderSYS;
            picOrderSYS.Location = new System.Drawing.Point(0, 0);
            picOrderSYS.Name = "picOrderSYS";
            picOrderSYS.Size = new System.Drawing.Size(1559, 991);
            picOrderSYS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picOrderSYS.TabIndex = 0;
            picOrderSYS.TabStop = false;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(0, 826);
            button1.Name = "button1";
            button1.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            button1.Size = new System.Drawing.Size(540, 108);
            button1.TabIndex = 8;
            button1.Text = "Manage Customers";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2099, 1117);
            Controls.Add(pnlDesktop);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlMenu);
            IsMdiContainer = true;
            Name = "frmMainMenu";
            Text = "frmMainMenu";
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            pnlDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picOrderSYS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStatements;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblChildForm;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.PictureBox picOrderSYS;
        private System.Windows.Forms.Button button1;
    }
}