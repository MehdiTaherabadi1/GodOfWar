using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Frameowork.Application;
using UOM.Application;

namespace UOM.Interface.RestApi
{
    public class DimensionsController : ApiController
    {
        private readonly ICommandBus _commandBus;
        public DimensionsController(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }

        public void Post(CreateDimensionCommand dto)
        {
            _commandBus.Dispatch(dto);    
        }
    }
}
