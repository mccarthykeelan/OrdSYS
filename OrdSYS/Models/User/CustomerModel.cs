using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OrdSYS.Models.User
{
    public class CustomerModel
    {
        // Fields
        private string _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phoneNumber;
        private string _address;
        private string _city;
        private string _county;
        private string _eircode;
        private string _accountStatus;
        private string _accountType;
        private string _password;
        private string _dateCreated;
        private string _dateUpdated;

        // Properties - Validations
        [DisplayName("Customer ID")]
        [Required(ErrorMessage = "Customer ID is required")]
        public string Id { get => _id; set => _id = value; }
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get => _firstName; set => _firstName = value; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get => _lastName; set => _lastName = value; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get => _email; set => _email = value; }
        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
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
        [DisplayName("Account Status")]
        [Required(ErrorMessage = "Account Status is required")]
        public string AccountStatus { get => _accountStatus; set => _accountStatus = value; }
        [DisplayName("Account Type")]
        [Required(ErrorMessage = "Account Type is required")]
        public string AccountType { get => _accountType; set => _accountType = value; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get => _password; set => _password = value; }
        [DisplayName("Date Created")]
        [Required(ErrorMessage = "Date Created is required")]
        public string DateCreated { get => _dateCreated; set => _dateCreated = value; }
        [DisplayName("Date Updated")]
        public string DateUpdated { get => _dateUpdated; set => _dateUpdated = value; }
    }
}
