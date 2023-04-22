using Oracle.ManagedDataAccess.Client;
using OrdSYS.Models.Customer;
using OrdSYS.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS._repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(String connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(CustomerModel customerModel)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            using (OracleCommand command = new OracleCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customers VALUES (:ID, :USERNAME, :FIRST_NAME, :LAST_NAME, :EMAIL, :PHONE, :ADDRESS, :CITY, :COUNTY, :EIRCODE, :ACCOUNT_STATUS)";
                command.Parameters.Add(":ID", customerModel.Id);
                command.Parameters.Add(":USERNAME", customerModel.Username);
                command.Parameters.Add(":FIRST_NAME", customerModel.FirstName);
                command.Parameters.Add(":LAST_NAME", customerModel.LastName);
                command.Parameters.Add(":EMAIL", customerModel.Email);
                command.Parameters.Add(":PHONE", customerModel.PhoneNumber);
                command.Parameters.Add(":ADDRESS", customerModel.Address);
                command.Parameters.Add(":CITY", customerModel.City);
                command.Parameters.Add(":COUNTY", customerModel.County);
                command.Parameters.Add(":EIRCODE", customerModel.Eircode);
                command.Parameters.Add(":ACCOUNT_STATUS", customerModel.AccountStatus);
                command.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            using (OracleCommand command = new OracleCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Customers WHERE CUSTOMER_ID = :ID";
                command.Parameters.Add(":ID", id);
                command.ExecuteNonQuery();
            }
        }
        public void Edit(CustomerModel customerModel)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            using (OracleCommand command = new OracleCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Customers VALUES (:NAME, :PRICE, :QTY, :STATUS) WHERE CUSTOMER_ID = :ID";
                command.Parameters.Add(":USERNAME", customerModel.Username);
                command.Parameters.Add(":FIRST_NAME", customerModel.FirstName);
                command.Parameters.Add(":LAST_NAME", customerModel.LastName);
                command.Parameters.Add(":EMAIL", customerModel.Email);
                command.Parameters.Add(":PHONE", customerModel.PhoneNumber);
                command.Parameters.Add(":ADDRESS", customerModel.Address);
                command.Parameters.Add(":CITY", customerModel.City);
                command.Parameters.Add(":COUNTY", customerModel.County);
                command.Parameters.Add(":EIRCODE", customerModel.Eircode);
                command.Parameters.Add(":ACCOUNT_STATUS", customerModel.AccountStatus);
                command.Parameters.Add(":ID", customerModel.Id);
                command.ExecuteNonQuery();

            }
        }
        public IEnumerable<CustomerModel> GetAll()
        {
            var customerList = new List<CustomerModel>();

            using (OracleConnection con = new OracleConnection(_connectionString))
            using (OracleCommand cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM Customers ORDER BY CUSTOMER_ID DESC";
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customer = new CustomerModel();
                        customer.Id = reader.GetInt32(0);
                        customer.Username = reader.GetString(1);
                        customer.FirstName = reader.GetString(2);
                        customer.LastName = reader.GetString(3);
                        customer.Email = reader.GetString(4);
                        customer.PhoneNumber = reader.GetString(5);
                        customer.Address = reader.GetString(6);
                        customer.City = reader.GetString(7);
                        customer.County = reader.GetString(8);
                        customer.Eircode = reader.GetString(9);
                        customer.AccountStatus = Char.Parse(reader.GetString(10));

                        customerList.Add(customer);
                    }
                }
                return customerList;
            }
        }
        public IEnumerable<CustomerModel> GetByValue(string value)
        {
            var customerList = new List<CustomerModel>();
            int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string username = value;
            string firstname = value;
            string lastname = value;
            string email = value;
            string phone = value;
            string city = value;
            string county = value;
            string eircode = value;

            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                string sql = "SELECT * FROM CUSTOMERS WHERE PRODUCT_ID = :PRODUCT_ID or PRODUCT_NAME like :PRODUCT_NAME||'%' ORDER BY PRODUCT_ID DESC";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();

                cmd.Parameters.Add(":CUSTOMER_ID", customerId);
                cmd.Parameters.Add(":USERNAME", username);
                cmd.Parameters.Add(":FIRST_NAME", firstname);
                cmd.Parameters.Add(":LAST_NAME", lastname);
                cmd.Parameters.Add(":EMAIL", email);
                cmd.Parameters.Add(":PHONE", phone);
                cmd.Parameters.Add(":CITY", city);
                cmd.Parameters.Add(":COUNTY", county);
                cmd.Parameters.Add(":EIRCODE", eircode);

                cmd.Prepare();

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customer = new CustomerModel();
                        customer.Id = reader.GetInt32(0);
                        customer.Username = reader.GetString(1);
                        customer.FirstName = reader.GetString(2);
                        customer.LastName = reader.GetString(3);
                        customer.Email = reader.GetString(4);
                        customer.PhoneNumber = reader.GetString(5);
                        customer.Address = reader.GetString(6);
                        customer.City = reader.GetString(7);
                        customer.County = reader.GetString(8);
                        customer.Eircode = reader.GetString(9);
                        customer.AccountStatus = Char.Parse(reader.GetString(10));

                        customerList.Add(customer);
                    }
                    reader.Close();
                    con.Close();
                }
                return customerList;
            }
        }
    }
}
