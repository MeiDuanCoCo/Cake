using System;
using Autofac;
using Autofac.Core;
using SSO.Services;

namespace Cake.Services
{
    /// <summary>
    ///     Autofac工厂
    /// </summary>
    public class AutofacFactory : IocFactory
    {
        private static IContainer _gContext;

        public AutofacFactory(ILifetimeScope container)
        {
            if (container == null)
                throw new ArgumentNullException("container");
            Container = container;
        }

        public ILifetimeScope Container { get; protected set; }

        public T Get<T>() where T : class
        {
            return Container.Resolve<T>();
        }

        public T Get<T>(string serviceName) where T : class
        {
            return Container.ResolveNamed<T>(serviceName);
        }

        public object Get(Type type)
        {
            return Container.Resolve(type);
        }

        public object Get(Type type, string serviceName)
        {
            return Container.ResolveNamed(serviceName, type);
        }

        public object Get(Type type, object serviceKey)
        {
            return Container.ResolveKeyed(serviceKey, type);
        }

        public T Get<T>(object serviceKey) where T : class
        {
            return Container.ResolveKeyed<T>(serviceKey);
        }

        public static IContainer Boot(params IModule[] modules)
        {
            var cb = new ContainerBuilder();
            foreach (var module in modules)
                cb.RegisterModule(module);
            _gContext = cb.Build();
            return _gContext;
        }
    }
}