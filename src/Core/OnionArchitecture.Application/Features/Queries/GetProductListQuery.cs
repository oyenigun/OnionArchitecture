using System;
using MediatR;
using OnionArchitecture.Application.BaseModels;
using OnionArchitecture.Application.Interfaces;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Features.Queries
{
    public class GetProductListQuery : IRequest<ServiceResponse<List<Product>>>
    {

        public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, ServiceResponse<List<Product>>>
        {
            private readonly IProductRepository _dbContext;

            public GetProductListQueryHandler(IProductRepository dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<ServiceResponse<List<Product>>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
            {
                return await _dbContext.GetProductList();
            }
        }
    }
}

