using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductManagement.Domain.Models.Products;
using Xunit;

namespace ProductManagement.Domain.Test.Unit.Models.Product
{
    [TestClass]
    public class ProductTest
    {
        private class DummyProduct : Domain.Models.Products.Product
        {
            public string Name { get; private set; }
            public GenericProduct GenericProduct { get; private set; }

            public DummyProduct(string name) : base(name)
            {
                Name = name;
            }

            public DummyProduct(string name, GenericProduct genericProduct) : base(name, genericProduct)
            {
                Name = name;
                GenericProduct = genericProduct;
            }
        }

        [Fact]
        public void Constructor_should_create_root_product()
        {
            string name = "Nectar";

            var product = new DummyProduct(name);

            product.Should().Be(name);
            product.ParentProductId.Should().BeNull();
        }

        [Fact]
        public void Constructor_should_create_child_product()
        {
            var nctarName = "Nectar";
            var orangeNectarName = "Orange Nectar";

            var nectar = new GenericProduct(nctarName);
            var product = new DummyProduct(orangeNectarName, nectar);

            nectar.Name.Should().Be(orangeNectarName);
            product.ParentProductId.Should().Be(nectar.Id); //TODO :it has no Id
        }
    }
}
