using System;
using FluentAssertions;
using Frameowork.Core.EventHandling;
using NSubstitute;
using UOM.Domain.Model.Dimensions;
using Xunit;

namespace UOM.Application.Tests.Unit
{
    public class DimensionCommandHandlerTests
    {
        [Fact]
        public void HandlerCreate_should_add_dimension_to_repository()
        {
            const string time = "Time";
            var dto = new CreateDimensionCommand { Name = time };
            var repository = Substitute.For<IDimensionRepository>();
            var service = new DimensionCommandHandler(repository,new EventAggregator());
            var expectedDimension = new Dimension(time,new EventAggregator());

            service.Handler(dto);

            repository.Received(1).Add(expectedDimension);
        }
    }
}
