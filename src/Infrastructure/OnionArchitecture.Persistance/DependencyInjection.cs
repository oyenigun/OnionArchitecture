using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Application.Interfaces;
using OnionArchitecture.Persistance.Repositories;

namespace OnionArchitecture.Persistance
{
	public static class DependencyInjection
	{
        public static void AddPersistanceLayer(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}

