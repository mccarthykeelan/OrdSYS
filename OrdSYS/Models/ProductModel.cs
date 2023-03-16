using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS
{
    class ProductModel
    {
        private int product_id;
        private String name;
        private int quantity;
        private decimal price;
        private DateTime reg_date;
        private String status;
        private String description;

        public ProductModel(int product_id, string name, int quantity, decimal price, DateTime reg_date, string status, string description)
        {
            this.product_id = product_id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.reg_date = reg_date;
            this.status = status;
            this.description = description;
        }

        public int Product_id { get => product_id; set => product_id = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal Price { get => price; set => price = value; }
        public DateTime Reg_date { get => reg_date; set => reg_date = value; }
        public string Status { get => status; set => status = value; }
        public string Description { get => description; set => description = value; }
    }
}
