using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using OrdSYS.Models.User;

namespace OrdSYS.Models.Customer
{
    public class CustomerModel : UserModel
    {
        // Fields
        private int _id;
        private string _address;
        private string _city;
        private string _county;
        private string _eircode;

        // Properties - Validations
        [DisplayName("Customer ID")]
        [Required(ErrorMessage = "Customer ID is required")]
        public int Id { get => _id; set => _id = value; }
        [DisplayName("Address")]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get => _address; set => _address = value; }
        [DisplayName("City")]
        [Required(ErrorMessage = "City is required")]
        public string City { get => _city; set => _city = value; }
        [DisplayName("County")]
        [Required(ErrorMessage = "County is required")]
        public string County { get => _county; set => _county = value; }
        [DisplayName("Eircode")]
        [Required(ErrorMessage = "Eircode is required")]
        public string Eircode { get => _eircode; set => _eircode = value; }
    }
}
