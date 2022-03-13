using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameowork.Core.EventHandling
{
    public interface IEventAggregator
    {
        void Publish<T>(T @event) where T : IEvent;
        void Subscribe<T>(IEventHandler<T> eventHandler) where T : IEvent;
    }
}
