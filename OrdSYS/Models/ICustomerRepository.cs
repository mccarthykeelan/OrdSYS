using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS.Models
{
    public interface ICustomerRepository
    {
        void Add(CustomerModel customerModel);
        void Edit(CustomerModel customerModel);
        void Delete(int id);
        IEnumerable<CustomerModel> GetAll();
        IEnumerable<CustomerModel> GetByValue();//Searches
    }
}
