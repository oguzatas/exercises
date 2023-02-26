using Castle.DynamicProxy;
using Core.Aspects.Autofac.Performance;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using IInterceptor = Castle.DynamicProxy.IInterceptor;

//One of the most important parts of the project. Top level programming example. Study It. Work On It.
namespace Core.Utilities.Interceptors
{
    // add aspects here if you want to use them on all methods 
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);
            //   classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger))); code for logging.
            //   classAttributes.Add(new PerformanceAspect(typeof(PerformanceAspect)));
            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}
