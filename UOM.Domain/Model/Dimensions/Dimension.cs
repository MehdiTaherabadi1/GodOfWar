using System;
using Frameowork.Core.EventHandling;
using Framework.Domain;
using UOM.Domain.Contracts;

namespace UOM.Domain.Model.Dimensions
{
    public class Dimension : AggregateRoot<Guid>
    {
        public string Name { get; private set; }
        protected Dimension() { } //For ORM Only
        public Dimension(string name,IEventPublisher eventPublisher):base(eventPublisher)
        {
            Id = Guid.NewGuid();
            Publish(new DimensionCreated(Id, name));
            Name = name;
        }
    }
}
