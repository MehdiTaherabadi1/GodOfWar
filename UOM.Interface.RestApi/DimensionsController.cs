using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Frameowork.Application;
using UOM.Application;
using UOM.Query.Model.Models;
using UOM.Query.Model.Reposiotres;

namespace UOM.Interface.RestApi
{
    public class DimensionsController : ApiController
    {
        private readonly ICommandBus _commandBus;
        private readonly IDimensionQueryRepository _dimensionQueryRepository;
        public DimensionsController(ICommandBus commandBus, IDimensionQueryRepository dimensionQueryRepository)
        {
            _commandBus = commandBus;
            _dimensionQueryRepository = dimensionQueryRepository;
        }

        public async Task<List<DimensionQuery>> Get()
        {
            //TODO : use DTO instand Of Query Models
            return await _dimensionQueryRepository.GetAll();
        }

        public async Task<List<DimensionQuery>> Get(Guid id)
        {
            return await _dimensionQueryRepository.GetById(id);
        }

        public void Post(CreateDimensionCommand dto)
        {
            _commandBus.Dispatch(dto);
        }
    }
}
