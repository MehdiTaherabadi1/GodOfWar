using System;
using System.Collections.Generic;
using System.Data;
using FluentAssertions;
using ProductManagement.Domain.Models.Products.ProductConstraint;
using Xunit;
using Constraint = ProductManagement.Domain.Models.Constraint.Constraint;

namespace ProductManagement.Domain.Test.Unit.Models.Product.ProductConstraint
{
    public class SelectiveConstraintTests
    {
        [Fact]
        public void Constructor_should_create_selective_constraint()
        {
            //TODO : refactor this test
            var fuelType = new Constraint() { Id = 1, Title = "FuelType" };
            var pet = new Options("Petrolium", 1);
            var gas = new Options("Gasoline", 2);
            var options = new List<Options>() { pet, gas };

            var constraint = new SelectiveConstraint(fuelType, options);
            constraint.ConstraintId.Should().Be(fuelType.Id);
            constraint.Options.Should().BeEquivalentTo(options);
        }

        [Fact]
        public void Constructor_should_throw_if_options_have_duplicate_value()
        {
            var fuelType = new Constraint() { Id = 1, Title = "FuelType" };
            var pet = new Options("Petrolium", 1);
            var gas = new Options("Gasoline", 1);
            var options = new List<Options>() { pet, gas };

            Action Constructor = ()=> new SelectiveConstraint(fuelType, options);
            Constructor.Should().Throw<Exception>();
        }
    }
}
