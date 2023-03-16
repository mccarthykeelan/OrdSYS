using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS
{
    class ShipmentModel
    {
        private int shipment_id;
        private DateTime shipment_date;
        private Boolean dispatched;

        public ShipmentModel(int shipment_id, DateTime shipment_date, bool dispatched)
        {
            this.shipment_id = shipment_id;
            this.shipment_date = shipment_date;
            this.dispatched = dispatched;
        }

        public int Shipment_id { get => shipment_id; set => shipment_id = value; }
        public DateTime Shipment_date { get => shipment_date; set => shipment_date = value; }
        public bool Dispatched { get => dispatched; set => dispatched = value; }
    }
}
