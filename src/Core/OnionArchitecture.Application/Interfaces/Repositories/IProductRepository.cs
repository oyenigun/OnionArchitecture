using OnionArchitecture.Application.BaseModels;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Interfaces
{
    public interface IProductRepository
    {
        Task<ServiceResponse<List<Product>>> GetProductList();
        Task<ServiceResponse<int>> CreateProduct(Product product);
    }
}

