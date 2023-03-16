using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS
{
    class UserModel
    {
        private int user_id;
        private String username;
        private String password;
        private DateTime reg_date;
        private String status;
        private Boolean isAdmin;
        private String address1;
        private String address2;
        private String city;
        private String county;
        private String eircode;

        public UserModel(int user_id, string username, string password, DateTime reg_date, string status, bool isAdmin, string address1, string address2, string city, string county, string eircode)
        {
            this.user_id = user_id;
            this.username = username;
            this.password = password;
            this.reg_date = reg_date;
            this.status = status;
            this.isAdmin = isAdmin;
            this.address1 = address1;
            this.address2 = address2;
            this.city = city;
            this.county = county;
            this.eircode = eircode;
        }

        public int User_id { get => user_id; set => user_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Reg_date { get => reg_date; set => reg_date = value; }
        public string Status { get => status; set => status = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public string Address1 { get => address1; set => address1 = value; }
        public string Address2 { get => address2; set => address2 = value; }
        public string City { get => city; set => city = value; }
        public string County { get => county; set => county = value; }
        public string Eircode { get => eircode; set => eircode = value; }
    }
}
