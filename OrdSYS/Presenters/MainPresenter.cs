using OrdSYS._repositories;
using OrdSYS.Models.Product;
using OrdSYS.Views;
using OrdSYS.Views.Product;
using System;
using System.Collections.Generic;
using System.Text;

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
        }

        private void ShowProductsView(object sender, EventArgs e)
        {
            IProductView view = frmOrders.GetInstance((frmMainMenu)_mainView);
            IProductRepository repository = new ProductRepository(sqlConnection);
            new ProductPresenter(view, repository);
            view.Show();
        }
    }
}
