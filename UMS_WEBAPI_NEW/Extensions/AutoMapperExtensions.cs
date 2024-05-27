using UMS_BLL.Mapping;

namespace UMS_WEBAPI_NEW.Extensions
{
    public static class AutoMapperExtensions
    {
        public static IServiceCollection AutoMappingConfig(this IServiceCollection service) 
        {
               service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }, typeof(Program));

            return service;
        }
    }
}
