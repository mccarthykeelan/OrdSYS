using OrdSYS.Models.Admin;
using OrdSYS.Models.Order;
using OrdSYS.Views.Admin;
using OrdSYS.Views.Order;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OrdSYS.Presenters
{
    public class AdminPresenter
    {
        // Private
        private IAdminView _view;
        private IAdminRepository _repository;
        private BindingSource adminsBindingSource;
        private IEnumerable<AdminModel> adminList;

        // Constructor
        public AdminPresenter(IAdminView view, IAdminRepository repository)
        {
            this.adminsBindingSource = new BindingSource();
            this._view = view;
            this._repository = repository;
            // Subscribe event handler methods to view events
            this._view.SearchEvent += SearchAdmin;
            this._view.AddNewEvent += AddAdmin;
            this._view.EditEvent += LoadSelectedAdminToEdit;
            this._view.DeleteEvent += DeleteAdmin;
            this._view.SaveEvent += SaveAdmin;
            this._view.CancelEvent += CancelAction;
            // Set the view's product list binding source
            this._view.SetAdminListBindingSource(adminsBindingSource);
            // Load the product view
            LoadAllAdminsList();
            // Show view
            this._view.Show();
        }


        private void LoadAllAdminsList()
        {
            adminList = _repository.GetAll();
            adminsBindingSource.DataSource = adminList; // Set Data Source
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveAdmin(object sender, EventArgs e)
        {
            var model = new AdminModel();
            model.Id = _view.AdminID;
            model.Username = _view.Username;
            model.FirstName = _view.FirstName;
            model.LastName = _view.LastName;
            model.Email = _view.Email;
            model.Password = _view.Password;
            model.AccountStatus = _view.AccountStatus;
            model.IsRoot = _view.IsRoot;

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
                LoadAllAdminsList();
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
            _view.AdminID = 0;
            _view.Username = "";
            _view.FirstName = "";
            _view.LastName = "";
            _view.Email = "";
            _view.Password = "";
            _view.AccountStatus = '\0';
            _view.IsRoot = '\0';
        }

        private void DeleteAdmin(object sender, EventArgs e)
        {
            try
            {
                var order = (OrderModel)adminsBindingSource.Current;
                _repository.Delete(order.Id);
                _view.IsSuccessful = true;
                _view.Message = "Admin deleted successfully";
                LoadAllAdminsList();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = "An error ocurred, could not delete admin" + ex.Message;
            }
        }

        private void LoadSelectedAdminToEdit(object sender, EventArgs e)
        {
            var admin = (AdminModel)adminsBindingSource.Current;
            _view.AdminID = admin.Id;
            _view.Username = admin.Username;
            _view.FirstName = admin.FirstName;
            _view.LastName = admin.LastName;
            _view.Email = admin.Email;
            _view.Password = admin.Password;
            _view.AccountStatus = admin.AccountStatus;
            _view.IsRoot = admin.IsRoot;

            _view.IsEdit = true;
        }

        private void AddAdmin(object sender, EventArgs e)
        {
            _view.IsEdit = false;
        }

        private void SearchAdmin(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this._view.SearchValue);
            if (emptyValue == false)
            {
                adminList = _repository.GetByValue(this._view.SearchValue);
            }
            else
            {
                adminList = _repository.GetAll();
            }
            adminsBindingSource.DataSource = adminList;
        }
    }
}
