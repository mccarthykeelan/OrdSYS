using OrdSYS.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS.Models.Admin
{
    public interface IAdminRepository
    {
        void Add(AdminModel adminModel);
        void Edit(AdminModel adminModel);
        void Delete(int id);
        IEnumerable<AdminModel> GetAll();
        IEnumerable<AdminModel> GetByValue(string value);//Searches
    }
}
