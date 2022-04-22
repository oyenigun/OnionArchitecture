
using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace OnionArchitecture.Application
{
    public static class DepencencyInjection
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddMediatR(assembly);
            services.AddAutoMapper(assembly);
        }
    }
}

