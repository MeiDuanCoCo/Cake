using System;

namespace SSO.Services
{
    /// <summary>
    ///     返回当前上下文中的对象
    /// </summary>
    /// <remarks>
    ///     一般情况下，获取与此对象同一LifecycleScope中的对象。
    ///     在web的情况下，总是返回web request相关的对象。
    /// </remarks>
    public interface IocFactory
    {
        T Get<T>() where T : class;

        T Get<T>(string serviceName) where T : class;

        T Get<T>(object serviceKey) where T : class;

        object Get(Type type);

        object Get(Type type, string serviceName);

        object Get(Type type, object serviceKey);
    }
}