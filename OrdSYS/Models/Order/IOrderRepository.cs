using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS.Models.Order
{
    public interface IOrderRepository
    {
        void Add(OrderModel petModel);
        void Edit(OrderModel petModel);
        void Delete(int id);
        IEnumerable<OrderModel> GetAll();
        IEnumerable<OrderModel> GetByValue(string value);//Searches
    }
}
