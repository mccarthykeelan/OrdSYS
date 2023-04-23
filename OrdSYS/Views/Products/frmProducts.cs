using OrdSYS.Views.Product;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdSYS
{
    public partial class frmProducts : Form, IProductView
    {
        private string _message;
        private bool _isSuccessful;
        private bool _isEdit;

        public frmProducts()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tcTabControl.TabPages.Remove(tpProductDetails);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Others
            // ADD
            btnAddNew.Click += delegate
            {
                //AddEvent?.Invoke(this, EventArgs.Empty);
                tcTabControl.TabPages.Remove(tpSearchProducts);
                tcTabControl.TabPages.Add(tpProductDetails);
                tpProductDetails.Text = "Add New Product";

            };
            // EDIT
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tcTabControl.TabPages.Remove(tpSearchProducts);
                tcTabControl.TabPages.Add(tpProductDetails);
                tpProductDetails.Text = "Edit Product";
            };
            // SAVE
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tcTabControl.TabPages.Remove(tpProductDetails);
                    tcTabControl.TabPages.Add(tpSearchProducts);
                }
                else
                {
                    MessageBox.Show(Message);
                }
            };
            // CANCEL
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tcTabControl.TabPages.Remove(tpProductDetails);
                tcTabControl.TabPages.Add(tpSearchProducts);
            };
            // DELETE
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected pet?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public int ProductId
        {
            get { return Convert.ToInt32(txtProductID.Text); }
            set { txtProductID.Text = value.ToString(); }
        }
        public string ProductName
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }
        public string ProductDescription
        {
            get { return txtProductDescription.Text; }
            set { txtProductDescription.Text = value; }
        }
        public decimal ProductPrice
        {
            get { return nudPrice.Value; }
            set { nudPrice.Value = value; }
        }
        public int ProductStock
        {
            get { return Convert.ToInt32(nudQuantityAvailable.Value); }
            set { nudQuantityAvailable.Value = Convert.ToDecimal(value); }
        }
        public string SearchValue
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }
        public bool IsEdit
        {
            get { return _isEdit; }
            set { _isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return _isSuccessful; }
            set { _isSuccessful = value; }
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public char ProductStatus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler SearchEvent;
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler AddNewEvent;

        public static frmProducts instance;
        public static frmProducts GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmProducts();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        public void SetProductListBindingSource(BindingSource productList)
        {
            grdProducts.DataSource = productList;
        }
    }
}
