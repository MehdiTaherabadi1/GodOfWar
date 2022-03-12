using Framework.Domain;

namespace ProductManagement.Domain.Models.Products
{
    public abstract class Product : AggregateRoot<long>
    {
        public string Name { get; private set; }
        public long? ParentProductId { get; set; }

        protected Product(string name) : this(name, null)
        {

        }

        protected Product(string name, GenericProduct parentProduct)
        {
            Name = name;
            if (parentProduct != null) ParentProductId = parentProduct.ParentProductId;
        }

        public void AddConstraint(ProductConstraint.ProductConstraint productConstraint)
        {

        }
    }
}