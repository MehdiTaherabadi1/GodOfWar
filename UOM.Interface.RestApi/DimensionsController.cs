using Frameowork.Core;
using System;
using System.Web.Http;
using UOM.Application;
using UOM.Interface.Facade.Contracts;

namespace UOM.Interface.RestApi
{
    public class DimensionsController : ApiController, IGateway
    {
        private IDimensionFacade _dimensionFacade;

        public DimensionsController(IDimensionFacade dimensionFacade)
        {
            _dimensionFacade = dimensionFacade;
        }

        public Guid Post(CreateDimensionCommand dto)
        {
            var result = _dimensionFacade.Create(dto);
            return result;
        }
    }
}
