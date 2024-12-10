using Microsoft.Extensions.DependencyInjection;
using HepsiAPI.Application.Interfaces.AutoMapper;


namespace HepsiAPI.Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}
