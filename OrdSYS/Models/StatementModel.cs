using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OrdSYS.Models
{
    public class StatementModel
    {
        // Fields
        private int _customerId;
        private DateTime _startDate;
        private DateTime _endDate;
        private decimal _ordersTotal;

        // Properties - Validations
        [DisplayName("Customer ID")]
        public int CustomerId { get => _customerId; set => _customerId = value; }
        [DisplayName("Start Date")]
        [Required(ErrorMessage = "A start date required")]
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        [DisplayName("End Date")]
        [Required(ErrorMessage = "An end date required")]
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
        [DisplayName("Orders Total")]
        [Required(ErrorMessage = "Orders Total is required")]
        public decimal OrdersTotal { get => _ordersTotal; set => _ordersTotal = value; }
    }
}
