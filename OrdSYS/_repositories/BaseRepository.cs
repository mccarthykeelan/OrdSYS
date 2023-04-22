using Oracle.ManagedDataAccess.Client;
using OrdSYS.Models.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS._repositories
{
    public abstract class BaseRepository
    {
        protected string _connectionString;

        internal int GetNextId(string tableName)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            using (OracleCommand command = new OracleCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT MAX(ID) FROM " + tableName;
                int id = Convert.ToInt32(command.ExecuteScalar());
                return id + 1;
            }
        }
    }
}
