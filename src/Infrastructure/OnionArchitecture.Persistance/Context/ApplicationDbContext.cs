using System;
using OnionArchitecture.Application.BaseModels;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Persistance.Context
{
    public class ApplicationDbContext //Dummy Db Context
    {
        private static List<Product> inMemoryProductList = new List<Product>()
        {
            new Product() { Id = 1, Name = "Product1", Price = 10, Quantity = 100 },
            new Product() { Id = 2, Name = "Product2", Price = 20, Quantity = 200 }
        };


        public async Task<ServiceResponse<int>> Add(Product item)
        {
            inMemoryProductList.Add(item);
            return new ServiceResponse<int>(inMemoryProductList.Count) { IsSuccess = true }; ;

        }

        public async Task<ServiceResponse<List<Product>>> GetList()
        {
            return new ServiceResponse<List<Product>>(inMemoryProductList) { IsSuccess = true };
        }
    }
}

