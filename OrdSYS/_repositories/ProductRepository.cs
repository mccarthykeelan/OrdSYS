using Oracle.ManagedDataAccess.Client;
using OrdSYS.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS._repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(String connectionString) 
        { 
            _connectionString = connectionString;
        }

        public void Add(ProductModel productModel)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            using (OracleCommand command = new OracleCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO PRODUCTS VALUES (:ID, :NAME, :PRICE, :QTY, :STATUS)";
                command.Parameters.Add(":ID", productModel.Id);
                command.Parameters.Add(":NAME", productModel.Name);
                command.Parameters.Add(":PRICE", productModel.Price);
                command.Parameters.Add(":QTY", productModel.Stock);
                command.Parameters.Add(":STATUS", productModel.Status);
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
                command.CommandText = "DELETE FROM PRODUCTS WHERE PRODUCT_ID = :ID";
                command.Parameters.Add(":ID", id);
                command.ExecuteNonQuery();
            }
        }
        public void Edit(ProductModel productModel)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            using (OracleCommand command = new OracleCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO PRODUCTS VALUES (:ID, :NAME, :PRICE, :QTY, :STATUS)";
                command.Parameters.Add(":ID", productModel.Id);
                command.Parameters.Add(":NAME", productModel.Name);
                command.Parameters.Add(":PRICE", productModel.Price);
                command.Parameters.Add(":QTY", productModel.Stock);
                command.Parameters.Add(":STATUS", productModel.Status);
                command.ExecuteNonQuery();

            }
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
    }
}
