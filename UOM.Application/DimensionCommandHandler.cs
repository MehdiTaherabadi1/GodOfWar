using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frameowork.Application;
using Frameowork.Core.EventHandling;
using UOM.Domain.Model.Dimensions;

namespace UOM.Application
{
    public class DimensionCommandHandler : ICommandHandler<CreateDimensionCommand>
    {
        private readonly IDimensionRepository _repository;
        private readonly IEventPublisher _eventPublisher;
        public DimensionCommandHandler(IDimensionRepository repository, IEventPublisher eventPublisher)
        {
            _repository = repository;
            _eventPublisher = eventPublisher;
        }

        public void Handler(CreateDimensionCommand command)
        {
            var dimension = new Dimension(command.Name, _eventPublisher);
            _repository.Add(dimension);
        }
    }
}
