using Autofac;
using Microsoft.Extensions.Configuration;
//using Pro.Helper.Auditoria;
//using Pro.Helper.Mensajeria;
using System;
using System.Reflection;

namespace CB.Core.ApiHost
{
    public class ProxyModule : Autofac.Module
    {
        public static IConfiguration Configuration;
        public static AppConfig AppConfig;
        protected override void Load(ContainerBuilder builder)
        {
            //Proxy Local
            //builder.RegisterAssemblyTypes(Assembly.Load(new AssemblyName("CB.Core.Aplicacion")));
                //.Where(type => type.Name.EndsWith("Proxy", StringComparison.Ordinal))
                //.AsSelf();

            //builder.RegisterType<AuditoriaProxy>().As<IAuditoriaService>().WithParameter("baseUrl", AppConfig.Urls.URL_AUDITORIA_API);
            //builder.RegisterType<CorreoProxy>().As<ICorreoProxy>().WithParameter("baseUrl", AppConfig.Urls.URL_MENSAJERIA_API);
            //builder.RegisterType<NotificacionProxy>().As<INotificacionProxy>().WithParameter("baseUrl", AppConfig.Urls.URL_MENSAJERIA_API);
            //builder.RegisterType<BuzonElectronicoProxy>().As<IBuzonElectronicoProxy>().WithParameter("baseUrl", AppConfig.Urls.URL_MENSAJERIA_API);

            base.Load(builder);
        }
    }
}

