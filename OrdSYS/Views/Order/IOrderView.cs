using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OrdSYS.Views.Order
{
    public interface IOrderView
    {
        // Properties
        string OrderID { get; set; }
        string CustomerID { get; set; }
        DateTime? OrderDate { get; set; }
        string status { get; set; }
        decimal Total { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessfull { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetOrderListBindingSource(BindingSource orderList);
        void Show();
    }
}
