using AutoMapper;
using MediatR;
using OnionArchitecture.Application.BaseModels;
using OnionArchitecture.Application.Interfaces;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Features.Commands
{
    public class CreateProductCommand : IRequest<ServiceResponse<int>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<int>>
        {
            private readonly IProductRepository _dbContext;
            private readonly IMapper _mapper;

            public CreateProductCommandHandler(IProductRepository dbContext, IMapper mapper)
            {
                _dbContext = dbContext;
                _mapper = mapper;
            }

            public async Task<ServiceResponse<int>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                Product product = _mapper.Map<Product>(request);
                return await _dbContext.CreateProduct(product);
            }
        }
    }
}

