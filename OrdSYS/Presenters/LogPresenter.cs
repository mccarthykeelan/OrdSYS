using OrdSYS.Models.Log;
using OrdSYS.Models.Order;
using OrdSYS.Views.Logs;
using OrdSYS.Views.Order;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OrdSYS.Presenters
{
    public class LogPresenter
    {
        // Private
        private ILogView _view;
        private ILogRepository _repository;
        private BindingSource logBindingSource;
        private IEnumerable<LogModel> logList;

        // Constructor
        public LogPresenter(ILogView view, ILogRepository repository)
        {
            this.logBindingSource = new BindingSource();
            this._view = view;
            this._repository = repository;
            // Subscribe event handler methods to view events
            this._view.SearchEvent += SearchOrder;
            // Set the view's product list binding source
            this._view.SetLogListBindingSource(logBindingSource);
            // Load the product view
            LoadAllLogsList();
            // Show view
            this._view.Show();
        }


        private void LoadAllLogsList()
        {
            logList = _repository.GetAll();
            logBindingSource.DataSource = logList; // Set Data Source
        }



        private void SearchOrder(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this._view.SearchValue);
            if (emptyValue == false)
            {
                logList = _repository.GetByValue(this._view.SearchValue);
            }
            else
            {
                logList = _repository.GetAll();
            }
            logBindingSource.DataSource = logList;
        }
    }
}
