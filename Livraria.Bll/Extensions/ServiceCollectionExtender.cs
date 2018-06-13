using Livraria.Bll.Interfaces;
using Livraria.Dal;
using Livraria.Dal.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.Bll.Extensions
{
    public static class ServiceCollectionExtender
    {
        public static void AddLivraria(this IServiceCollection services)
        {
            services.AddScoped<ILivroDal, LivroDal>();
            services.AddScoped<ILivroBll, LivroBll>();
        }
    }
}
