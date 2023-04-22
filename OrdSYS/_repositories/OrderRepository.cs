using Oracle.ManagedDataAccess.Client;
using OrdSYS.Models.Order;
using OrdSYS.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS._repositories
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository(String connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(OrderModel orderModel)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            using (OracleCommand command = new OracleCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO ORDERS VALUES (:ORDER_ID, :CUSTOMER_ID, :DATE, :STATUS, :TOTAL)";
                command.Parameters.Add(":ORDER_ID", orderModel.CustomerId);
                command.Parameters.Add(":CUSTOMER_ID", orderModel.CustomerId);
                command.Parameters.Add(":DATE", orderModel.Date);
                command.Parameters.Add(":STATUS", orderModel.Status);
                command.Parameters.Add(":TOTAL", orderModel.Total);
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
                command.CommandText = "DELETE FROM ORDERS WHERE ORDER_ID = :ID";
                command.Parameters.Add(":ID", id);
                command.ExecuteNonQuery();
            }
        }
        public void Edit(OrderModel orderModel)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            using (OracleCommand command = new OracleCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE ORDERS VALUES (:CUSTOMER_ID, :DATE, :STATUS, :TOTAL) WHERE ORDER_ID = :ORDER_ID";
                command.Parameters.Add(":CUSTOMER_ID", orderModel.CustomerId);
                command.Parameters.Add(":DATE", orderModel.Date);
                command.Parameters.Add(":STATUS", orderModel.Status);
                command.Parameters.Add(":TOTAL", orderModel.Total);
                command.Parameters.Add(":ORDER_ID", orderModel.CustomerId);
                command.ExecuteNonQuery();

            }
        }

        public IEnumerable<OrderModel> GetAll()
        {
            var orderList = new List<OrderModel>();

            using (OracleConnection con = new OracleConnection(_connectionString))
            using (OracleCommand cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM ORDERS ORDER BY ORDER_ID DESC";
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var order = new OrderModel();
                        order.Id = reader.GetInt32(0);
                        order.CustomerId = reader.GetInt32(1);
                        order.Date = reader.GetDateTime(2);
                        order.Status = Char.Parse(reader.GetString(3));

                        orderList.Add(order);
                    }
                }
                return orderList;
            }
        }
        public IEnumerable<OrderModel> GetByValue(string value)
        {
            var orderList = new List<OrderModel>();
            int orderId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;

            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                string sql = "SELECT * FROM ORDERS WHERE ORDER_ID = :ORDER_ID ORDER BY PRODUCT_ID DESC";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();

                cmd.Parameters.Add(":ORDER_ID", orderId);

                cmd.Prepare();

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var order = new OrderModel();
                        order.Id = reader.GetInt32(0);
                        order.CustomerId = reader.GetInt32(0);
                        order.Date = reader.GetDateTime(2);
                        order.Status = Char.Parse(reader.GetString(3));
                        order.Total = reader.GetChar(4);
                        orderList.Add(order);
                    }
                    reader.Close();
                    con.Close();
                }
                return orderList;
            }
        }
    }
}
