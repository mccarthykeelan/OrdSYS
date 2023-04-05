using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS.Models
{
    public interface IOrderRepository
    {
        void Add(OrderModel orderModel);
        void Edit(OrderModel orderModel);
        void Delete(int id);
        IEnumerable<OrderModel> GetAll();
        IEnumerable<OrderModel> GetByValue();//Searches
    }
}
