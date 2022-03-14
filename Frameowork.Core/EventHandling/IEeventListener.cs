using System;

namespace Frameowork.Core.EventHandling
{
    public interface IEventListener
    {
        void Subscribe<T>(IEventHandler<T> eventHandler) where T : IEvent;
        void Subscribe<T>(Action<T> action) where T : IEvent;
    }
}
