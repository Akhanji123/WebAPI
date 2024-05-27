using UMS_WEBAPI_NEW.Filters;

namespace UMS_WEBAPI_NEW.Extensions
{
    public static class GlobalExceptionFilterExtension
    {
        public static IServiceCollection FilterExtension(this IServiceCollection service)
        {
            service.AddControllers(options =>
            {
                options.Filters.Add(new GlobalExceptionFilter());
            });
            return service;
        }

    }
}
