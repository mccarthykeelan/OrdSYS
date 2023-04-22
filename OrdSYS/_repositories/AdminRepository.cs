using Oracle.ManagedDataAccess.Client;
using OrdSYS.Models.Admin;
using OrdSYS.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS._repositories
{
    public class AdminRepository : BaseRepository, IAdminRepository
    {
        public AdminRepository(String connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(AdminModel adminModel)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            using (OracleCommand command = new OracleCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Administrators VALUES (:FIRST_NAME, :LAST_NAME, :USERNAME, :EMAIL, :PHONE_NUMBER, :STATUS, :IS_ROOT) WHERE ADMIN_ID = :ID";
                command.Parameters.Add(":ID", adminModel.Id);
                command.Parameters.Add(":FIRST_NAME", adminModel.FirstName);
                command.Parameters.Add(":LAST_NAME", adminModel.LastName);
                command.Parameters.Add(":USERNAME", adminModel.Username);
                command.Parameters.Add(":EMAIL", adminModel.Email);
                command.Parameters.Add(":PHONE_NUMBER", adminModel.PhoneNumber);
                command.Parameters.Add(":STATUS", adminModel.AccountStatus);
                command.Parameters.Add(":IS_ROOT", adminModel.IsRoot);
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
                command.CommandText = "DELETE FROM Administrators WHERE ADMIN_ID = :ID";
                command.Parameters.Add(":ID", id);
                command.ExecuteNonQuery();
            }
        }
        public void Edit(AdminModel adminModel)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            using (OracleCommand command = new OracleCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Administrators VALUES (:FIRST_NAME, :LAST_NAME, :USERNAME, :EMAIL, :PHONE_NUMBER, :STATUS, :IS_ROOT) WHERE ADMIN_ID = :ID";
                command.Parameters.Add(":ID", adminModel.Id);
                command.Parameters.Add(":FIRST_NAME", adminModel.FirstName);
                command.Parameters.Add(":LAST_NAME", adminModel.LastName);
                command.Parameters.Add(":USERNAME", adminModel.Username);
                command.Parameters.Add(":EMAIL", adminModel.Email);
                command.Parameters.Add(":PHONE_NUMBER", adminModel.PhoneNumber);
                command.Parameters.Add(":STATUS", adminModel.AccountStatus);
                command.Parameters.Add(":IS_ROOT", adminModel.IsRoot);
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<AdminModel> GetAll()
        {
            var adminList = new List<AdminModel>();

            using (OracleConnection con = new OracleConnection(_connectionString))
            using (OracleCommand cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM Administrators ORDER BY ADMIN_ID DESC";
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var admin = new AdminModel();
                        admin.Id = reader.GetInt32(0);
                        admin.FirstName = reader.GetString(1);
                        admin.LastName = reader.GetString(1);
                        admin.Username = reader.GetString(2);
                        admin.Email = reader.GetString(3);
                        admin.PhoneNumber = reader.GetString(4);
                        admin.AccountStatus = reader.GetChar(4);
                        admin.IsRoot = reader.GetChar(4);
                        adminList.Add(admin);
                    }
                }
                return adminList;
            }
        }
        public IEnumerable<AdminModel> GetByValue(string value)
        {
            var adminList = new List<AdminModel>();
            int adminId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string username = value;

            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                string sql = "SELECT * FROM Administrators WHERE ADMIN_ID = :ADMIN_ID or USERNAME like :USERNAME||'%' ORDER BY ADMIN_ID DESC";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();

                cmd.Parameters.Add(":ADMIN_ID", adminId);
                cmd.Parameters.Add(":USERNMAE", username);

                cmd.Prepare();

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var admin = new AdminModel();
                        admin.Id = reader.GetInt32(0);
                        admin.FirstName = reader.GetString(1);
                        admin.LastName = reader.GetString(1);
                        admin.Username = reader.GetString(2);
                        admin.Email = reader.GetString(3);
                        admin.PhoneNumber = reader.GetString(4);
                        admin.AccountStatus = reader.GetChar(4);
                        admin.IsRoot = reader.GetChar(4);
                        adminList.Add(admin);
                    }
                    reader.Close();
                    con.Close();
                }
                return adminList;
            }
        }
    }
}
