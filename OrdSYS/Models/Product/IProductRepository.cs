﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OrdSYS.Models.Product
{
    public interface IProductRepository
    {
        void Add(ProductModel productModel);
        void Edit(ProductModel productModel);
        void Delete(int id);
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(string value);//Searches
    }
}
