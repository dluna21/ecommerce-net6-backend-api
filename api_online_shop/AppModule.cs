using api_online_shop.Service.Pruebas;
using Autofac;
using MediatR;
using Pro.Data.Core;
using System.Reflection;

namespace api_online_shop
{
    public class AppModule: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly).AsImplementedInterfaces();

            //builder.RegisterType<UnitOfWork>()
            //.As<IUnitOfWork>()
            //.WithParameter((c, p) => true, (c, p) => p.ResolveNamed<IDbContext>("context"))
            //.InstancePerLifetimeScope();

            builder.RegisterType<PruebaService>().As<IPruebaService>().InstancePerLifetimeScope();
             
        }

    }
}
