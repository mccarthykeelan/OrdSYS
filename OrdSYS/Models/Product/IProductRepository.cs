using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS.Models.Product
{
    public interface IProductRepository
    {
        void Add(ProductModel petModel);
        void Edit(ProductModel petModel);
        void Delete(int id);
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(string value);//Searches
    }
}
