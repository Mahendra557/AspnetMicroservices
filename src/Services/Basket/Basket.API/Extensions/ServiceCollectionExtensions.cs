using Basket.API.Respositories;
using System.Runtime.CompilerServices;

namespace Basket.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        
        public static void AddServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration.GetValue<string>("CacheSettings:ConnectionString");
            });

            services.AddScoped<IBasketRepository, BasketRepository>();
        }
    }
}
