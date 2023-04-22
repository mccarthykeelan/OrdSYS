using Oracle.ManagedDataAccess.Client;
using OrdSYS.Models.Log;
using OrdSYS.Models.Product;
using System;
using System.Collections.Generic;

namespace OrdSYS._repositories
{
    public class LogRepository : BaseRepository, ILogRepository
    {
        public LogRepository(String connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();

            using (OracleConnection con = new OracleConnection(_connectionString))
            using (OracleCommand cmd = con.CreateCommand())
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM PRODUCTS ORDER BY PRODUCT_ID DESC";
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel();
                        product.Id = reader.GetInt32(0);
                        product.Name = reader.GetString(1);
                        product.Description = reader.GetString(2);
                        product.Price = reader.GetDecimal(3);
                        product.Stock = reader.GetInt32(4);
                        product.Status = Char.Parse(reader.GetString(5));

                        productList.Add(product);
                    }
                }
                return productList;
            }
        }
        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productName = value;

            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                string sql = "SELECT * FROM PRODUCTS WHERE PRODUCT_ID = :PRODUCT_ID or PRODUCT_NAME like :PRODUCT_NAME||'%' ORDER BY PRODUCT_ID DESC";
                OracleCommand cmd = new OracleCommand(sql, con);
                con.Open();

                cmd.Parameters.Add(":PRODUCT_ID", productId);
                cmd.Parameters.Add(":PRODUCT_NAME", productName);

                cmd.Prepare();

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductModel();
                        product.Id = reader.GetInt32(0);
                        product.Name = reader.GetString(1);
                        product.Price = reader.GetDecimal(2);
                        product.Stock = reader.GetInt32(3);
                        product.Status = reader.GetChar(4);
                        productList.Add(product);
                    }
                    reader.Close();
                    con.Close();
                }
                return productList;
            }
        }

        IEnumerable<LogModel> ILogRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<LogModel> ILogRepository.GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
