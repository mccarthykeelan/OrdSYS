using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS
{
    class OrderModel
    {
        private int order_id;
        private int user_id;
        private int shipment_id;
        private int product_id;
        private DateTime order_date;
        private int quantity;
        private decimal order_total;

        public OrderModel(int order_id, int user_id, int shipment_id, int product_id, DateTime order_date, int quantity, decimal order_total)
        {
            this.order_id = order_id;
            this.user_id = user_id;
            this.shipment_id = shipment_id;
            this.product_id = product_id;
            this.order_date = order_date;
            this.quantity = quantity;
            this.order_total = order_total;
        }

        public int Order_id { get => order_id; set => order_id = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public int Shipment_id { get => shipment_id; set => shipment_id = value; }
        public int Product_id { get => product_id; set => product_id = value; }
        public DateTime Order_date { get => order_date; set => order_date = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal Order_total { get => order_total; set => order_total = value; }
    }
}
