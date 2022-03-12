using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UOM.Query.Model.Models;

namespace UOM.Query.Model.Reposiotres
{
    public interface IDimensionQueryRepository
    {
        Task<List<DimensionQuery>> GetAll();
        Task<List<DimensionQuery>> GetById(Guid id);
    }
}