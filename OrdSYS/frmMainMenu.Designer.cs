namespace OrdSYS
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
            btnExit = new System.Windows.Forms.Button();
            btnStatements = new System.Windows.Forms.Button();
            btnOrders = new System.Windows.Forms.Button();
            btnProducts = new System.Windows.Forms.Button();
            btnDashboard = new System.Windows.Forms.Button();
            pnlLogo = new System.Windows.Forms.Panel();
            picLogo = new System.Windows.Forms.PictureBox();
            pnlTitleBar = new System.Windows.Forms.Panel();
            lblChildForm = new System.Windows.Forms.Label();
            pnlDesktop = new System.Windows.Forms.Panel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
            pnlMenu.Controls.Add(btnExit);
            pnlMenu.Controls.Add(btnStatements);
            pnlMenu.Controls.Add(btnOrders);
            pnlMenu.Controls.Add(btnProducts);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            pnlMenu.Location = new System.Drawing.Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new System.Drawing.Size(400, 978);
            pnlMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.Location = new System.Drawing.Point(0, 870);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(400, 108);
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
            btnStatements.Location = new System.Drawing.Point(0, 514);
            btnStatements.Name = "btnStatements";
            btnStatements.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            btnStatements.Size = new System.Drawing.Size(400, 108);
            btnStatements.TabIndex = 4;
            btnStatements.Text = "Statements";
            btnStatements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStatements.UseVisualStyleBackColor = true;
            btnStatements.Click += btnStatements_Click;
            // 
            // btnOrders
            // 
            btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOrders.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOrders.ForeColor = System.Drawing.Color.White;
            btnOrders.Location = new System.Drawing.Point(0, 406);
            btnOrders.Name = "btnOrders";
            btnOrders.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            btnOrders.Size = new System.Drawing.Size(400, 108);
            btnOrders.TabIndex = 3;
            btnOrders.Text = "Orders";
            btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnProducts
            // 
            btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProducts.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnProducts.ForeColor = System.Drawing.Color.White;
            btnProducts.Location = new System.Drawing.Point(0, 298);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            btnProducts.Size = new System.Drawing.Size(400, 108);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDashboard.ForeColor = System.Drawing.Color.White;
            btnDashboard.Location = new System.Drawing.Point(0, 190);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            btnDashboard.Size = new System.Drawing.Size(400, 108);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            pnlLogo.Location = new System.Drawing.Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new System.Drawing.Size(400, 190);
            pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            picLogo.Image = (System.Drawing.Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new System.Drawing.Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new System.Drawing.Size(400, 190);
            picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
            pnlTitleBar.Controls.Add(lblChildForm);
            pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTitleBar.Location = new System.Drawing.Point(400, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new System.Drawing.Size(1460, 126);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // lblChildForm
            // 
            lblChildForm.AutoSize = true;
            lblChildForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblChildForm.ForeColor = System.Drawing.Color.White;
            lblChildForm.Location = new System.Drawing.Point(42, 40);
            lblChildForm.Name = "lblChildForm";
            lblChildForm.Size = new System.Drawing.Size(129, 54);
            lblChildForm.TabIndex = 0;
            lblChildForm.Text = "Home";
            // 
            // pnlDesktop
            // 
            pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDesktop.Location = new System.Drawing.Point(400, 126);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new System.Drawing.Size(1460, 852);
            pnlDesktop.TabIndex = 2;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1860, 978);
            Controls.Add(pnlDesktop);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlMenu);
            Name = "frmMainMenu";
            Text = "frmMainMenu";
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStatements;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblChildForm;
        private System.Windows.Forms.Panel pnlDesktop;
    }
}