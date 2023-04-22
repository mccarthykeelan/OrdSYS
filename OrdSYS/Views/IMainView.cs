using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS.Views
{
    public interface IMainView
    {
        event EventHandler ShowProductView;
        event EventHandler ShowOrderView;
        event EventHandler ShowLogView;
        event EventHandler ShowAdminView;
        event EventHandler ShowCustomerView;
    }
}
