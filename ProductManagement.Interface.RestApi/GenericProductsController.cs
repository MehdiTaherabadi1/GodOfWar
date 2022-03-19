using Frameowork.Application;
using Frameowork.Core;
using ProductManagement.Application.Contracts;
using System.Collections.Generic;
using System.Web.Http;

namespace ProductManagement.Interface.RestApi
{
    public class GenericProductsController : ApiController, IGateway
    {
        private ICommandBus _bus;
        public GenericProductsController(ICommandBus bus)
        {
            _bus = bus;
        }

        public void Post(CreateGenericProductCommand command)
        {
            //TODO: use a model binder here and remove this hard-coded command initialization!
            command = new CreateGenericProductCommand()
            {
                Name = "X",
                Constraints = new List<ProductConstraintDto>()
                {
                    new NumericRangeConstraintDto()
                    {
                        ConstraintId = 1, Max = 10, Min = 1
                    },
                    new StringProductConstraintDto()
                    {
                        ConstraintId = 2, MaxLength = 255
                    }
                }
            };

            _bus.Dispatch(command);
        }
    }
}
