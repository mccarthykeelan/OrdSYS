using OrdSYS.Models.Admin;
using OrdSYS.Models.Customer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OrdSYS.Views.Admin
{
    public interface IAdminView
    {
        //Properties - Fields
        int AdminID { get; set; }
        string Username { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        char AccountStatus { get; set; }
        char IsRoot { get; set; }

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
        void SetAdminListBindingSource(BindingSource adminList);
        void Show();
        void SetAdminListBindingSource(IEnumerable<AdminModel> adminList);
    }
}
