using Autofac;
using Microsoft.Extensions.Configuration;

namespace CB.Core.ApiHost
{
    public static class BootstrapperContainer
    {
        public static IConfiguration Configuration;
        public static AppConfig AppConfig;

        public static void Register(ContainerBuilder builder)
        {
            var ac = new AppConfig();
            Configuration.GetSection("AppConfig").Bind(ac);

            builder.Register(c => ac);

            //Variables
            //var appConfig = new AppConfig();
            //Configuration.GetSection("AppConfig").Bind(appConfig);
            //builder.Register(c => appConfig);

            //Proxy
            //ProxyModule.AppConfig = ac;
            //ProxyModule.Configuration = Configuration;
            //builder.RegisterModule(new ProxyModule());

            //Context
            ContextDbModule.Configuration = Configuration;
            builder.RegisterModule(new ContextDbModule());

            //Log
            //LogModule.Configuration = Configuration;
            //builder.RegisterModule(new LogModule());
            

        }
    }
}
