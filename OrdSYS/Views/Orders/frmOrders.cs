using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdSYS.Views.Order
{
    public partial class frmOrders : Form, IOrderView
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        public string OrderID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public char Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessfull { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public static frmOrders instance;
        public static frmOrders GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmOrders();
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

        public void SetOrderListBindingSource(BindingSource orderList)
        {
            grdOrders.DataSource = orderList;
        }
    }
}
