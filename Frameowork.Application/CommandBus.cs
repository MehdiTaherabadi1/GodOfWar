using System;
using Frameowork.Core;

namespace Frameowork.Application
{
    public class CommandBus : ICommandBus
    {
        private readonly IServiceLocator _serviceLocator;

        public CommandBus(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public void Dispatch<T>(T command)
        {
            ICommandHandler<T> handler = _serviceLocator.GetInstance<ICommandHandler<T>>();

            try
            {
                handler.Handler(command);
            }
            finally
            {
                _serviceLocator.Release(handler);
            }
        }
    }
}