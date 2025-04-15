using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        private int _duration;
        private ICacheService _cacheService;

        public CacheAspect(int duration = 60)
        {
            _duration = duration;
            _cacheService = ServiceTool.ServiceProvider.GetService<ICacheService>();
        }

        public override void Intercept(IInvocation invocation)
        {
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");
            var arguments = invocation.Arguments.ToList();
            var key = $"{methodName}({string.Join(",", arguments.Select(a => a?.ToString() ?? "<Null>"))})";

            var returnType = invocation.Method.ReturnType;

            // Dinamik olarak sonucu cache'ten getir
            var methodResult = _cacheService.GetOrAdd(key, () =>
            {
                invocation.Proceed(); // metodu çalıştır
                return invocation.ReturnValue;
            }, TimeSpan.FromMinutes(_duration));

            invocation.ReturnValue = methodResult;
        }
    }
}