using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OrdSYS.Models
{
    public class OrderModel
    {
        // Fields
        private int _id;
        private int _customerId;
        private DateTime _date;
        private string _status;
        private decimal _total;

        // Properties - Validations
        [DisplayName("Order ID")]
        [Required(ErrorMessage = "Order ID is required")]
        public int Id { get => _id; set => _id = value; }
        [DisplayName("Customer ID")]
        [Required(ErrorMessage = "Customer ID is required")]
        public int CustomerId { get => _customerId; set => _customerId = value; }
        [DisplayName("Order Date")]
        [Required(ErrorMessage = "Order Date is required")]
        public DateTime Date { get => _date; set => _date = value; }
        [DisplayName("Order Status")]
        [Required(ErrorMessage = "Order Status is required")]
        public string Status { get => _status; set => _status = value; }
        [DisplayName("Order Total")]
        [Required(ErrorMessage = "Order Total is required")]
        public decimal Total { get => _total; set => _total = value; }
    }
}
