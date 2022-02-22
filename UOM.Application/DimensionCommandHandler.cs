using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frameowork.Application;
using UOM.Domain.Model.Dimensions;

namespace UOM.Application
{
    public class DimensionCommandHandler : ICommandHandler<CreateDimensionCommand>
    {
        private readonly IDimensionRepository _repository;
        public DimensionCommandHandler(IDimensionRepository repository)
        {
            _repository = repository;
        }

        public void Handler(CreateDimensionCommand command)
        {
            var dimension = new Dimension(command.Name);
            _repository.Add(dimension);
        }
    }
}
