using AutoMapper;
using OnionArchitecture.Application.Features.Commands;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, CreateProductCommand>().ReverseMap();
        }
    }
}

