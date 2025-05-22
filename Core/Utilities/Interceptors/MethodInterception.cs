using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, Exception e) { }

        public override void Intercept(IInvocation invocation)
        {
            var isAsync = invocation.Method.ReturnType == typeof(Task) ||
                          (invocation.Method.ReturnType.IsGenericType && invocation.Method.ReturnType.GetGenericTypeDefinition() == typeof(Task<>));

            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
                if (isAsync)
                {
                    var task = (Task)invocation.ReturnValue;
                    task.ContinueWith(t =>
                    {
                        if (t.Exception != null)
                        {
                            isSuccess = false;
                            OnException(invocation, t.Exception);
                        }
                        else
                        {
                            OnAfter(invocation);
                        }
                    });
                }
                else
                {
                    OnAfter(invocation);
                }
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);
                throw;
            }
        }
    }

 
    
}

