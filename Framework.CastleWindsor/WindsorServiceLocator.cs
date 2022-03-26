using Castle.Windsor;
using Frameowork.Core;
using System.Linq;

namespace Framework.CastleWindsor
{
    public class WindsorServiceLocator : IServiceLocator
    {
        private IWindsorContainer _container;
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
