using Bussiness.Auth;
using Bussiness.GenericService;
using Bussiness.Services;
using Bussiness.Services.AuthServices;
using Core.Interfaces.Bussiness.Auth;
using Core.Interfaces.Bussiness.GenericService;
using Core.Interfaces.Bussiness.Services;
using Core.Interfaces.Bussiness.Services.AuthServices;
using Core.Interfaces.Data.IUnitOfWork;
using Core.Interfaces.Data.Repository;
using Data.EfCore.Context;
using Data.EfCore.Repositories;
using Data.EfCore.UnitOfWork;
using WebApi.JwtGenerator;
using WebApi.JwtGenerator.Interface;
using WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ColorManagerContext>();
builder.Services.AddScoped<IJwtGenerator, JwtGenerator>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IColorRepository, ColorRepository>();
builder.Services.AddScoped<IPalatteRepository, PalatteRepository>();
builder.Services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IColorService, ColorService>();
builder.Services.AddScoped<IPalatteService, PalatteService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

//app.UseAuthorization();
app.UseRouting();
app.UseMiddleware<AuthMiddleware>();
//app.MapControllerRoute(
//     name: "default",
//        pattern: "{controller=Home}/{action=Index}/{id?}");
//);
//app.MapControllerRoute(
//    name: "areas",
//    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
//);
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
});

app.Run();
