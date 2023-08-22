using Autofac;
using Autofac.Extensions.DependencyInjection;
using CB.Core.ApiHost;
using CB.Persistencia.Context;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetService<IConfiguration>();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    //builder.RegisterModule(new ProxyModule());
    
    BootstrapperContainer.Configuration = configuration;
    BootstrapperContainer.Register(builder);
    builder.RegisterModule(new ContextDbModule());
});

//builder.Services.AddDbContext<OnlineShopContext>(o => o.UseNpgsql(builder.Configuration.GetConnectionString("DbOnlineShopContext")));
 
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOptions();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

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
