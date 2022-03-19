using Frameowork.Application;
using ProductManagement.Application.Contracts;
using ProductManagement.Domain.Model.Product;

namespace ProductManagement.Application
{
    public class GenericProductCommandHandlers : ICommandHandler<CreateGenericProductCommand>
    {
        public void Handler(CreateGenericProductCommand command)
        {
            var constraints = ConstraintFactory.CreateFromDto(command.Constraints);
            var genericProduct = new GenericProduct(0, command.Name, constraints);

            //save generic product !
        }
    }
}
