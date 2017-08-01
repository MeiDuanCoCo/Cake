using System.Reflection;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Cake.Domain;

namespace Cake.WebUI
{
    public class AutofacConfig : Services.AutofacConfig
    {
        public override void Initialize(ContainerBuilder builder)
        {
            builder.Register(c => new CakeContext("name=CakeContext")).InstancePerLifetimeScope();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();
        }
    }
}