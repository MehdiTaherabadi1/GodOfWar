using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOM.Query.Model.Models;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace UOM.Query.Model.Reposiotres
{
    public class DimensionQueryRepository : IDimensionQueryRepository
    {
        private readonly IDbConnection _dbConnection;

        public DimensionQueryRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<DimensionQuery>> GetAll()
        {
            var result = await _dbConnection.QueryAsync<DimensionQuery>("Select * From Dimensions");
            return result.ToList();
        }

        public async Task<DimensionQuery> GetById(Guid id)
        {
            var result = await _dbConnection.QueryFirstOrDefaultAsync<DimensionQuery>("select * from Dimensions where id=@Id", new { Id = id });
            return result;
        }
    }
}
