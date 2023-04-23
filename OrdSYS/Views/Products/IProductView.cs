using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OrdSYS.Views.Product
{
    public interface IProductView
    {
        // Properties
        int ProductId { get; set; }
        string ProductName { get; set; }
        string ProductDescription { get; set; }
        decimal ProductPrice { get; set; }
        int ProductStock { get; set; }
        char ProductStatus { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetProductListBindingSource(BindingSource productList);
        void Show();
    }
}
