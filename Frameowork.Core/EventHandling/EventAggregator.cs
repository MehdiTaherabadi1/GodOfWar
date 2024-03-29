﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameowork.Core.EventHandling
{
    public class EventAggregator : IEventPublisher, IEventListener
    {
        private List<object> _subscribers = new List<object>();
        public void Publish<T>(T @event) where T : IEvent
        {
            var targetHandler = _subscribers.OfType<IEventHandler<T>>().ToList();
            targetHandler.ForEach(handler =>
            {
                handler.Handle(@event);
            });
        }

        public void Subscribe<T>(IEventHandler<T> eventHandler) where T : IEvent
        {
            _subscribers.Add(eventHandler);
        }

        public void Subscribe<T>(Action<T> action) where T : IEvent
        {
            _subscribers.Add(new ActionHandler<T>(action));
        }
    }
}
