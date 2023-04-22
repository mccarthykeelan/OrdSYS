using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS.Models.User
{
    public class UserModel
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _username;
        private string _email;
        private string _phoneNumber;
        private char _accountStatus;
        private string _password;
        private DateTime _dateCreated;
        private DateTime _dateUpdated;

        internal int Id { get => _id; set => _id = value; }
        internal string FirstName { get => _firstName; set => _firstName = value; }
        internal string LastName { get => _lastName; set => _lastName = value; }
        internal string Username { get => _username; set => _username = value; }
        internal string Email { get => _email; set => _email = value; }
        internal string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        internal char AccountStatus { get => _accountStatus; set => _accountStatus = value; }
        internal string Password { get => _password; set => _password = value; }
        internal DateTime DateCreated { get => _dateCreated; set => _dateCreated = value; }
        internal DateTime DateUpdated { get => _dateUpdated; set => _dateUpdated = value; }
    }
}
