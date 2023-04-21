using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OrdSYS.Views.Customer
{
    public interface ICustomerView
    {
        //Properties - Fields
        string CustomerID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string County { get; set; }
        string Eircode { get; set; }
        string AccountStatus { get; set; }
        string AccountType { get; set; }
        string Password { get; set; }
        string DateCreated { get; set; }
        string DateUpdated { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetCustomerListBindingSource(BindingSource customerList);
        void Show();
    }
}
