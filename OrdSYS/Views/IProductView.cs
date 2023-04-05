using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OrdSYS.Views
{
    public interface IProductView
    {
        // Properties
        string ProductId { get; set; }
        string ProductName { get; set; }
        string ProductPrice { get; set; }
        string ProductStock { get; set; }
        string ProductStatus { get; set; }

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
        void SetPetListBindingSource(BindingSource petList);
        void Show();
    }
}
