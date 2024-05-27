using UMS_BLL.Services.AuthSER;
using UMS_BLL.Services.FacultySER;
using UMS_BLL.Services.MajorSER;
using UMS_BLL.Services.RoleSER;
using UMS_BLL.Services.UserSER;
using UMS_DAL.Repository.Faculties;
using UMS_DAL.Repository.Majors;
using UMS_DAL.Repository.Roles;
using UMS_DAL.Repository.Users;

namespace UMS_WEBAPI_NEW.Extensions
{
    public static class AppRepository
    {
        public static IServiceCollection AddRepositories(this IServiceCollection service )
        {
            service.AddScoped<IFacultyRepository,FacultyRepository>();
            service.AddScoped<IMajorRepository,MajorRepository>();
            service.AddScoped<IUserRepository,UserRepository>();
            service.AddScoped<IRoleRepository,RoleRepository>();
            return service;
        }

        public static IServiceCollection AddServices(this IServiceCollection service)
        {
            service.AddScoped<IFacultyService, FacultyService>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IRoleServices, RoleServices>();
            service.AddScoped<IAuthService, AuthService>();
            service.AddScoped<IMajorServices, MajorServices>();
            return service;

        }

    }
}
