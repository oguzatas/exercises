using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

//public static IHostBuilder CreateHostBuilder(string[] args) => in earlier versions (.net 5 and before uses this and startup.cs)
//    Host.CreateDefaultBuilder(args)
//    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
//    .ConfigureDefaults(WebApplicationBuilder =>
//    {
//        WebApplicationBuilder.UseStartup<Startup>
//    })

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBusinessModule());
});



// Add services to the container.

/* Autofac,Ninject,CastleWindsor,StructureMap, LightInject, DryInject ==> 
 IoC Container, AOP hizmeti sunabilen yapýlar */
//postsharp
//AOP => 
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<IProductService, ProductManager>();
//builder.Services.AddSingleton<IProductDal, EfProductDal>();


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
