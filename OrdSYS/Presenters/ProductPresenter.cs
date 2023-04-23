using OrdSYS.Models.Product;
using OrdSYS.Views.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OrdSYS.Presenters
{
    public class ProductPresenter
    {
        // Private
        private IProductView _view;
        private IProductRepository _repository;
        private BindingSource productsBindingSource;
        private IEnumerable<ProductModel> productList;

        // Constructor
        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productsBindingSource = new BindingSource();
            this._view = view;
            this._repository = repository;
            // Subscribe event handler methods to view events
            this._view.SearchEvent += SearchProduct;
            this._view.AddNewEvent += AddProduct;
            this._view.EditEvent += LoadSelectedProductToEdit;
            this._view.DeleteEvent += DeleteProduct;
            this._view.SaveEvent += SaveProduct;
            this._view.CancelEvent += CancelAction;
            // Set the view's product list binding source
            this._view.SetProductListBindingSource(productsBindingSource);
            // Load the product view
            LoadAllProductList();
            // Show view
            this._view.Show();
        }

        private void LoadAllProductList()
        {
            productList = _repository.GetAll();
            productsBindingSource.DataSource = productList; // Set Data Source
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object sender, EventArgs e)
        {
            var model = new ProductModel();
            model.Id = Convert.ToInt32(_view.ProductId);
            model.Name = _view.ProductName;
            model.Description = _view.ProductDescription;
            model.Price = Convert.ToInt32(_view.ProductPrice);
            model.Stock = Convert.ToInt32(_view.ProductStock);
            model.Status = _view.ProductStatus;
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
                LoadAllProductList();
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
            _view.ProductId = 0;
            _view.ProductName = "";
            _view.ProductDescription = "";
            _view.ProductPrice = 0;
            _view.ProductStock = 0;
            _view.ProductStatus = '\0';
        }

        private void DeleteProduct(object sender, EventArgs e)
        {
            try
            {
                var product = (ProductModel)productsBindingSource.Current;
                _repository.Delete(product.Id);
                _view.IsSuccessful = true;
                _view.Message = "Products deleted successfully";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = "An error ocurred, could not delete product" + ex.Message;
            }
        }

        private void LoadSelectedProductToEdit(object sender, EventArgs e)
        {
            var product = (ProductModel)productsBindingSource.Current;
            _view.ProductId = product.Id;
            _view.ProductName = product.Name;
            _view.ProductDescription = product.Description;
            _view.ProductPrice = product.Price;
            _view.ProductStock = product.Stock;
            _view.ProductStatus = product.Status;
            _view.IsEdit = true;
        }

        private void AddProduct(object sender, EventArgs e)
        {
            _view.IsEdit = false;
        }

        private void SearchProduct(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this._view.SearchValue);
            if (emptyValue == false)
            {
                productList = _repository.GetByValue(this._view.SearchValue);
            }
            else
            {
                productList = _repository.GetAll();
            }
            productsBindingSource.DataSource = productList;
        }
    }
}
