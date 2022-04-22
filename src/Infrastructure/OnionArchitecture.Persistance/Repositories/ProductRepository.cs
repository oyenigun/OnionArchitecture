using System;
using OnionArchitecture.Application.BaseModels;
using OnionArchitecture.Application.Interfaces;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Persistance.Context;

namespace OnionArchitecture.Persistance.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository()
        {
            _dbContext = new ApplicationDbContext();
        }


        public Task<ServiceResponse<int>> CreateProduct(Product product)
        {
            return _dbContext.Add(product);
        }

        public Task<ServiceResponse<List<Product>>> GetProductList()
        {
            return _dbContext.GetList();
        }
    }
}

