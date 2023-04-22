using OrdSYS.Models.Order;
using OrdSYS.Views.Order;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdSYS.Presenters
{
    public class OrderPresenter
    {
        // Private
        private IOrderView _view;
        private IOrderRepository _repository;
        private BindingSource ordersBindingSource;
        private IEnumerable<OrderModel> orderList;

        // Constructor
        public OrderPresenter(IOrderView view, IOrderRepository repository)
        {

            this.ordersBindingSource = new BindingSource();
            this._view = view;
            this._repository = repository;
            // Subscribe event handler methods to view events
            this._view.SearchEvent += SearchOrder;
            this._view.AddNewEvent += AddOrder;
            this._view.EditEvent += LoadSelectedOrderToEdit;
            this._view.DeleteEvent += DeleteOrder;
            this._view.SaveEvent += SaveOrder;
            this._view.CancelEvent += CancelAction;
            // Set the view's product list binding source
            this._view.SetOrderListBindingSource(ordersBindingSource);
            // Load the product view
            LoadAllOrdersList();
            // Show view
            this._view.Show();
        }


        private void LoadAllOrdersList()
        {
            orderList = _repository.GetAll();
            ordersBindingSource.DataSource = orderList; // Set Data Source
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveOrder(object sender, EventArgs e)
        {
            var model = new OrderModel();
            model.Id = Convert.ToInt32(_view.OrderID);
            model.CustomerId = Convert.ToInt32(_view.CustomerID);
            model.Date = System.DateTime.Now;
            model.Status = _view.Status;
            try
            {
                new Models.Common.ModelDataValidation().Validate(model);
                if (_view.IsEdit)
                {
                    _repository.Edit(model);
                    _view.Message = "Product edited successfuly";
                }
                else
                {
                    _repository.Add(model);
                    _view.Message = "Product added successfully.";
                }
                _view.IsSuccessful = true;
                LoadAllOrdersList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            _view.OrderID = "0";
            _view.CustomerID = "";
            _view.Date = DateTime.Now;
            _view.Status = '\0';
            _view.Total = 0;
        }

        private void DeleteOrder(object sender, EventArgs e)
        {
            try
            {
                var order = (OrderModel)ordersBindingSource.Current;
                _repository.Delete(order.Id);
                _view.IsSuccessful = true;
                _view.Message = "Order deleted successfully";
                LoadAllOrdersList();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = "An error ocurred, could not delete order" + ex.Message;
            }
        }

        private void LoadSelectedOrderToEdit(object sender, EventArgs e)
        {
            var order = (OrderModel)ordersBindingSource.Current;
            _view.OrderID = order.Id.ToString();
            _view.CustomerID = order.CustomerId.ToString();
            _view.Date = order.Date;
            _view.Status = order.Status;
            _view.Total = order.Total;
            _view.IsEdit = true;
        }

        private void AddOrder(object sender, EventArgs e)
        {
            _view.IsEdit = false;
        }

        private void SearchOrder(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this._view.SearchValue);
            if (emptyValue == false)
            {
                orderList = _repository.GetByValue(this._view.SearchValue);
            }
            else
            {
                orderList = _repository.GetAll();
            }
            ordersBindingSource.DataSource = orderList;
        }
    }
}
