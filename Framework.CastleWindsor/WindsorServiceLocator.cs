using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Frameowork.Core;

namespace Framework.CastleWindsor
{
    public class WindsorServiceLocator : IServiceLocator
    {
        private readonly IWindsorContainer _container;

        public WindsorServiceLocator(IWindsorContainer container)
        {
            _container = container;
        }

        public T GetInstance<T>()
        {
            return _container.Resolve<T>();
        }

        public void Release(object obj)
        {
            _container.Release(obj);
        }
    }
}
