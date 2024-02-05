using Common1.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Service1.Interfaces;
using Service1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service1
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepository();
            services.AddScoped(typeof(IService<CategoryDto>), typeof(CategoryService));
            services.AddAutoMapper(typeof(MapperProfile));

            services.AddScoped(typeof(IService<UserDto>), typeof(UserService));

            services.AddScoped(typeof(IService<ItemDto>), typeof(ItemService));
            return services;
        }
    }
}
