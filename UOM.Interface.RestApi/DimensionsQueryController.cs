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
    public class DimensionsQueryController : ApiController, IGateway
    {
        private readonly IDimensionQueryRepository _dimensionQueryRepository;
        public DimensionsQueryController(IDimensionQueryRepository dimensionQueryRepository)
        {
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
    }
}
