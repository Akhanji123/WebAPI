using UMS_BLL.Services.AuthSER;
using UMS_BLL.Services.FacultySER;
using UMS_BLL.Services.MajorSER;
using UMS_BLL.Services.RoleSER;
using UMS_BLL.Services.UserSER;
using UMS_DAL.Repository.Faculties;
using UMS_DAL.Repository.Majors;
using UMS_DAL.Repository.Roles;
using UMS_DAL.Repository.Users;
using UMS_WEBAPI_NEW.Extensions;
using UMS_WEBAPI_NEW.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRepositories();
builder.Services.addDb(builder.Configuration);
builder.Services.AutoMappingConfig();
builder.Services.FilterExtension();
builder.Services.AddServices();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

