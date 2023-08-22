using Autofac;
using MediatR;
using MediatR.Pipeline;
 
using CB.Core.Aplicacion;
using Pro.Data.Core;
using System;
using System.Reflection;
using CB.Core.Aplicacion.Service.Pruebas;
using CB.Persistencia.Context;
using CB.Persistencia;
using CB.Core.Aplicacion.Service.Pruebas.Querys;

namespace CB.Core.ApiHost
{
    public class ContextDbModule : Autofac.Module
    {
        public static Microsoft.Extensions.Configuration.IConfiguration Configuration;

        protected override void Load(ContainerBuilder builder)
        {

            //builder.RegisterInstance(ProEngine).As<IEngine>().SingleInstance();

    
            string connectionString = Configuration.GetSection("ConnectionStrings:DbOnlineShopContext").Value;
            var ac = new AppConfig();
            Configuration.GetSection("AppConfig").Bind(ac);
    
            builder.RegisterAssemblyTypes(Assembly.Load(new AssemblyName("CB.Core.Aplicacion")))
                .Where(t => t.Name.EndsWith("Query", StringComparison.Ordinal) && t.GetTypeInfo().IsClass)
                .AsImplementedInterfaces();

            
            //builder.RegisterAssemblyTypes(Assembly.Load(new AssemblyName("Pro.CB.Core.Aplicacion")))
            //    .Where(t => t.Name.EndsWith("Command", StringComparison.Ordinal) && t.GetTypeInfo().IsClass)
            //    .AsImplementedInterfaces();

            //-> Validacion
            //builder.RegisterAssemblyTypes(Assembly.Load(new AssemblyName("Pro.CB.Core.Aplicacion")))
            //    .Where(t => t.Name.EndsWith("Validator", StringComparison.Ordinal) && t.GetTypeInfo().IsClass)
            //    .AsSelf();

            //builder.RegisterType<PluginService>().As<IPluginService>().InstancePerLifetimeScope();

            //builder.RegisterType<MemoryCacheManager>()
            //    .As<ILocker>()
            //    .As<IStaticCacheManager>()
            //    .SingleInstance();


            builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly).AsImplementedInterfaces();

            builder.RegisterType<OnlineShopContext>().Named<IDbContext>("context")
                .WithParameter("connstr", connectionString).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>()
                .As<IUnitOfWork>()
                .WithParameter((c, p) => true, (c, p) => p.ResolveNamed<IDbContext>("context"))
                .InstancePerLifetimeScope()
                ;

            var mediatrOpenTypes = new[]
            {
                typeof(IRequestHandler<,>),
                typeof(IRequestExceptionHandler<,,>),
                typeof(IRequestExceptionAction<,>),
                typeof(INotificationHandler<>),
            };

            foreach (var mediatrOpenType in mediatrOpenTypes)
            {
                builder
                    .RegisterAssemblyTypes(typeof(PruebaQuery).GetTypeInfo().Assembly)
                    .AsClosedTypesOf(mediatrOpenType)
                    // when having a single class implementing several handler types
                    // this call will cause a handler to be called twice
                    // in general you should try to avoid having a class implementing for instance `IRequestHandler<,>` and `INotificationHandler<>`
                    // the other option would be to remove this call
                    // see also https://github.com/jbogard/MediatR/issues/462
                    .AsImplementedInterfaces();
            }

            builder.RegisterType<PruebaService>().As<IPruebaService>().InstancePerLifetimeScope();

            //builder.RegisterGeneric(typeof(PluginManager<>)).As(typeof(IPluginManager<>)).InstancePerLifetimeScope();

        }

    }
}
