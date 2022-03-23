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
            CreateDimensionCommand command = new CreateDimensionCommand { Name = time };
            var repository = Substitute.For<IDimensionRepository>();
            var dimensionCommandHandler = new DimensionCommandHandler(repository, new EventAggregator());
            var expectedDimension = new Dimension(time, new EventAggregator());

            dimensionCommandHandler.Handler(command);

            repository.Received(1).
                Add(Verify.That<Dimension>(a => a.Should().
                    BeEquivalentTo(expectedDimension, b =>
                      b.Excluding(g => g.Id).ComparingByMembers<Dimension>())));
        }
    }
}
