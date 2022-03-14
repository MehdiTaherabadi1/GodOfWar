using Frameowork.Core.EventHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain
{
    public class AggregateRoot<TKey> : Entity<TKey>
    {
        private readonly List<IEvent> _chanegs;
        private readonly IEventPublisher _eventPublisher;

        public AggregateRoot()
        {
            _chanegs = new List<IEvent>();
        }

        public AggregateRoot(IEventPublisher eventPublisher)
        {
            _eventPublisher = eventPublisher;
        }

        public void Publish(IEvent @event)
        {
            _chanegs.Add(@event);
            _eventPublisher.Publish(@event);
        }
    }
}
