using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Frameowork.Application;
using Frameowork.Core;
using UOM.Application;
using UOM.Query.Model.Models;
using UOM.Query.Model.Reposiotres;

namespace UOM.Interface.RestApi
{
    public class DimensionsController : ApiController, IGateway
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
