using Frameowork.Application;
using Frameowork.Core.EventHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOM.Application;
using UOM.Domain.Contracts;
using UOM.Interface.Facade.Contracts;

namespace UOM.Interface.Facade
{
    public class DimensionFacade : IDimensionFacade
    {
        private readonly ICommandBus _commandBus;
        private readonly IEventListener _eventListener;

        public DimensionFacade(ICommandBus commandBus, IEventListener eventListener)
        {
            _commandBus = commandBus;
            _eventListener = eventListener;
        }

        public Guid Create(CreateDimensionCommand command)
        {
            Guid id = Guid.Empty;
            _eventListener.Subscribe<DimensionCreated>(a =>
            {
                id = a.Id;
            });
            _commandBus.Dispatch(command);
            return id;
        }
    }
}
