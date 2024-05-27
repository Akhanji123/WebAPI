using UMS_DAL.Models;
using Microsoft.EntityFrameworkCore;
namespace UMS_WEBAPI_NEW.Extensions
{
    public static class StarupExtensions
    {
/*        public static void addDb(WebApplicationBuilder builder)
        {
            var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<UniversityMsContext>(options =>
                options.UseSqlServer(ConnectionString)
                );
            
        }*/

        public static IServiceCollection addDb(this IServiceCollection service, ConfigurationManager config)
        {
            var ConnectionString = config.GetConnectionString("DefaultConnection");
            service.AddDbContext<UniversityMsContext>(options =>
                options.UseSqlServer(ConnectionString)
                );

            return service;
        }

    } 
}
