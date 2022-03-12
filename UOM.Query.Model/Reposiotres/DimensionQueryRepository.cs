using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOM.Query.Model.Models;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace UOM.Query.Model.Reposiotres
{
    public class DimensionQueryRepository : IDimensionQueryRepository
    {
        public async Task<List<DimensionQuery>> GetAll()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var result = await sqlConnection.QueryAsync<DimensionQuery>("Select * From Dimensions");
                return result.ToList();
            }
        }

        public async Task<DimensionQuery> GetById(Guid id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var query = string.Format("select * from Dimensionswhere id = {0}", id);
                return await sqlConnection.QueryFirstOrDefaultAsync<DimensionQuery>(query);
            }
        }
    }
}
