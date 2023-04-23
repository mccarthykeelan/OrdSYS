using OrdSYS._repositories;
using OrdSYS.Models.Admin;
using OrdSYS.Models.Customer;
using OrdSYS.Models.Order;
using OrdSYS.Models.Product;
using OrdSYS.Models.User;
using OrdSYS.Views;
using OrdSYS.Views.Admin;
using OrdSYS.Views.Customer;
using OrdSYS.Views.Order;
using OrdSYS.Views.Product;
using OrdSYS.Views.User;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace OrdSYS.Presenters
{
    public class MainPresenter
    {
        private IMainView _mainView;
        private readonly string sqlConnection;

        public MainPresenter(IMainView mainView, string sqlConnection)
        {
            this._mainView = mainView;
            this.sqlConnection = sqlConnection;
            this._mainView.ShowProductView += ShowProductsView;
            this._mainView.ShowOrderView += ShowOrdersView;
            this._mainView.ShowProductView += ShowProductsView;
            this._mainView.ShowAdminView += ShowAdminView;
            this._mainView.ShowCustomerView += ShowCustomerView;
        }

        private void ShowProductsView(object sender, EventArgs e)
        {
            IProductView view = frmProducts.GetInstance((frmMainMenu)_mainView);
            IProductRepository repository = new ProductRepository(sqlConnection);
            new ProductPresenter(view, repository);
            view.Show();
        }

        private void ShowOrdersView(object sender, EventArgs e)
        {
            IOrderView view = frmOrders.GetInstance((frmMainMenu)_mainView);
            IOrderRepository repository = new OrderRepository(sqlConnection);
            new OrderPresenter(view, repository);
            view.Show();
        }

        private void ShowAdminView(object sender, EventArgs e)
        {
            IAdminView view = frmAdmin.GetInstance((frmMainMenu)_mainView);
            IAdminRepository repository = new AdminRepository(sqlConnection);
            new AdminPresenter(view, repository);
            view.Show();
        }

        private void ShowCustomerView(object sender, EventArgs e)
        {
            ICustomerView view = frmCustomers.GetInstance((frmMainMenu)_mainView);
            ICustomerRepository repository = new CustomerRepository(sqlConnection);
            new CustomerPresenter(view, repository);
            view.Show();
        }
    }
}
