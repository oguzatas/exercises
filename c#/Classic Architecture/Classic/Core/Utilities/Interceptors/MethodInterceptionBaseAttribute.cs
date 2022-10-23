using Castle.DynamicProxy;
using IInterceptor = Castle.DynamicProxy.IInterceptor;

//One of the most important parts of the project. Top level programming example. Study It. Work On It.
namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
