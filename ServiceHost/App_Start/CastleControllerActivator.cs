using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using Castle.Windsor;

namespace ServiceHost
{
    public class CastleControllerActivator : IHttpControllerActivator
    {
        private readonly IWindsorContainer _container;
        public CastleControllerActivator(IWindsorContainer container)
        {
            _container = container;
        }


        public IHttpController Create(HttpRequestMessage request, 
            HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            if (_container.Kernel.HasComponent(controllerType))
            {
                var controller = (IHttpController)_container.Resolve(controllerType);
                request.RegisterForDispose(controller as IDisposable);
                return controller;
            }
            return null;
        }
    }
}
