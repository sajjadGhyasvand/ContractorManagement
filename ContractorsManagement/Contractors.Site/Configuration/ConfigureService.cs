using DomainLayer.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;

namespace Contractors.Site.Configuration
{
    public static class ConfigureService
    {
        public static IServiceCollection AddWebServiceCollection(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            //Identity Service
            services.AddIdentity<ApplicationUsers, ApplicationRoles>().AddEntityFrameworkStores<ApplicationDBContext>().AddDefaultTokenProviders();

            return services;
        }
    }
}
