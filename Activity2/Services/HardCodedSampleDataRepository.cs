using Activity2.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Services
{
    public class HardCodedSampleDataRepository : IProductDataService
    {
        static List<ProductModel> productsList = new List<ProductModel>();
        public int Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            if (productsList.Count == 0) 
            {
                productsList.Add(new ProductModel { Id = 1, Name = "Tomatoes", Price = 12.23m, Description = "Red cherry sweet tomatoes" });
                productsList.Add(new ProductModel { Id = 2, Name = "Mangoes", Price = 23.00m, Description = "Colorfoul mangoes" });
                productsList.Add(new ProductModel { Id = 3, Name = "Grapes", Price = 1.89m, Description = "Green grapes" });
                productsList.Add(new ProductModel { Id = 4, Name = "Strawberry", Price = 5.90m, Description = "Strawberries from Italy" });
                productsList.Add(new ProductModel { Id = 5, Name = "Apples", Price = 54.00m, Description = "South African Apples" });

                for (int i = 0; i < 30; i++)
                {
                    productsList.Add(new Faker<ProductModel>().RuleFor(p => p.Id, i + 6)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(30))
                        .RuleFor(p => p.Description, f => f.Rant.Review()));
                }
            }
            

 

            return productsList;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string search)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
