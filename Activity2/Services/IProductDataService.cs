using Activity2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Services
{
    interface IProductDataService
    {
        // create a skeleton or outline of what other classes would implement
        List<ProductModel> GetAllProducts();
        List<ProductModel> SearchProducts(string search);
        ProductModel GetProductById(int id);
        int Insert(ProductModel product);
        int Delete(ProductModel product);
        int Update(ProductModel product);
    }
}
