﻿using Castle.DynamicProxy;

namespace UOM.Config.Castle
{
    public class PermissionInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();
        }
    }
}
