using OrdSYS.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS.Models.Customer
{
    public interface ICustomerRepository
    {
        void Add(CustomerModel customerModel);
        void Edit(CustomerModel customerModel);
        void Delete(int id);
        IEnumerable<CustomerModel> GetAll();
        IEnumerable<CustomerModel> GetByValue(string value);//Searches
    }
}
