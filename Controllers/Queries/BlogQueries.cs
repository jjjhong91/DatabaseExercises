using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DatabaseExercises.Models;
using Microsoft.Data.SqlClient;

namespace DatabaseExercises.Controllers.Queries
{
    public class BlogQueries
    {
        private string _connectionString = string.Empty;

        public BlogQueries(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<Blog>> GetBlogsAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                 connection.Open();
                 return await connection.QueryAsync<Blog>("select * from [BlogDb].dbo.[Blogs]");
            }
        }
    }
}