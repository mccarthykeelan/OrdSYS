using OrdSYS.Models.Customer;
using OrdSYS.Models.Order;
using OrdSYS.Views.Customer;
using OrdSYS.Views.Order;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OrdSYS.Presenters
{
    public class CustomerPresenter
    {
        // Private
        private ICustomerView _view;
        private ICustomerRepository _repository;
        private BindingSource customersBindingSource;
        private IEnumerable<CustomerModel> customerList;

        // Constructor
        public CustomerPresenter(ICustomerView view, ICustomerRepository repository)
        {
            this.customersBindingSource = new BindingSource();
            this._view = view;
            this._repository = repository;
            // Subscribe event handler methods to view events
            this._view.SearchEvent += SearchOrder;
            this._view.AddNewEvent += AddOrder;
            this._view.EditEvent += LoadSelectedCustomerToEdit;
            this._view.DeleteEvent += DeleteOrder;
            this._view.SaveEvent += SaveCustomer;
            this._view.CancelEvent += CancelAction;
            // Set the view's product list binding source
            this._view.SetCustomerListBindingSource(customersBindingSource);
            // Load the product view
            LoadAllCustomersList();
            // Show view
            this._view.Show();
        }


        private void LoadAllCustomersList()
        {
            customerList = _repository.GetAll();
            customersBindingSource.DataSource = customerList; // Set Data Source
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCustomer(object sender, EventArgs e)
        {
            var model = new CustomerModel();
            model.Id = Convert.ToInt32(_view.CustomerID);
            model.Username = _view.Username;
            model.Password = _view.Password;
            model.FirstName = _view.FirstName;
            model.LastName = _view.LastName;
            model.Email = _view.Email;
            model.PhoneNumber = _view.PhoneNumber;
            model.Address = _view.Address;
            model.City = _view.City;
            model.County = _view.County;
            model.Eircode = _view.Eircode;
            model.AccountStatus = _view.AccountStatus;
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
                LoadAllCustomersList();
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
            _view.CustomerID = "";
            _view.Username = "";
            _view.FirstName = "";
            _view.LastName = "";
            _view.Email = "";
            _view.PhoneNumber = "";
            _view.Address = "";
            _view.City = "";
            _view.County = "";
            _view.Eircode = "";
            _view.AccountStatus = '\0';
        }

        private void DeleteOrder(object sender, EventArgs e)
        {
            try
            {
                var customer = (CustomerModel)customersBindingSource.Current;
                _repository.Delete(customer.Id);
                _view.IsSuccessful = true;
                _view.Message = "Order deleted successfully";
                LoadAllCustomersList();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = "An error ocurred, could not delete order" + ex.Message;
            }
        }

        private void LoadSelectedCustomerToEdit(object sender, EventArgs e)
        {
            var customer = (CustomerModel)customersBindingSource.Current;
            _view.CustomerID = customer.Id.ToString();
            _view.Username = customer.Username;
            _view.FirstName = customer.FirstName;
            _view.LastName = customer.LastName;
            _view.Email = customer.Email;
            _view.PhoneNumber = customer.PhoneNumber;
            _view.Address = customer.Address;
            _view.City = customer.City;
            _view.County = customer.County;
            _view.Eircode = customer.Eircode;
            _view.AccountStatus = customer.AccountStatus;
            _view.Password = customer.Password;

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
                customerList = _repository.GetByValue(this._view.SearchValue);
            }
            else
            {
                customerList = _repository.GetAll();
            }
            customersBindingSource.DataSource = customerList;
        }
    }
}
