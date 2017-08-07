using Autofac;
using Cake.Services.Link;
using SSO.Services;

namespace Cake.Services
{
    /// <summary>
    ///     Autofac注入
    /// </summary>
    public class AutofacConfig : Module
    {
        protected sealed override void Load(ContainerBuilder builder)
        {
            SetupIocFactory(builder);
            SetupControls(builder);
            Initialize(builder);
            base.Load(builder);
        }

        protected virtual void SetupIocFactory(ContainerBuilder builder)
        {
            builder.RegisterType<AutofacFactory>().As<IocFactory>().InstancePerLifetimeScope();
        }

        protected virtual void SetupControls(ContainerBuilder builder)
        {
            builder.RegisterType<QuickLinkService>().As<IQuickLinkService>();
        }

        public virtual void Initialize(ContainerBuilder builder)
        {
        }
    }
}