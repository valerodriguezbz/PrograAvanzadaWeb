using System.ComponentModel;
using Abstractions.Interfaces.DA;
using Abstractions.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace DA
{
    public class ServicesDA : IServicesDA
    {
        private IDapperRepositoryDA _dapperRepository;
        private SqlConnection _sqlConnection;

        public ServicesDA(IDapperRepositoryDA dapperRepository)
        {
            _dapperRepository = dapperRepository;
            _sqlConnection = _dapperRepository.GetDapperRepository();
        }

        public async Task<Guid> Add(ServicesRequest services)
        {
            string sql = @"Add_Services";
            var result = await _sqlConnection.ExecuteScalarAsync<Guid>(sql,
                new
                {
                    Name = services.Name,
                    Description = services.Description,
                    Schedule = services.Schedule,
                    Price = services.Price,
                    Photo = services.Photo,
                    this_id_user_create = services.this_id_user_create
                });
            return result;
        }

        public async Task<Guid> Delete(int Id)
        {
            string sql = @"Delete_Services";
            var consultResultTemp = await Get(Id);
            if (consultResultTemp == null)
                return Guid.Empty;
            var result = await _sqlConnection.ExecuteScalarAsync<Guid>(sql, new { Id = Id });
            return result;
        }

        public async Task<IEnumerable<Services>> Get()
        {
            string sql = @"Get_Services";
            var result = await _sqlConnection.QueryAsync<Services>(sql);
            return result;
        }

        public async Task<Services> Get(int Id)
        {
            string sql = @"Get_Service";
            var result = await _sqlConnection.QueryAsync<Services>(sql, new { Id = Id });
            if (result.FirstOrDefault() == null)
                return null;
            return result.FirstOrDefault();
        }

        public async Task<Guid> Update(Services services)
        {
            string sql = @"Update_Services";
            var resultTemp = await Get(services.Id);
            if (resultTemp == null)
                return Guid.Empty;
            var result = await _sqlConnection.ExecuteScalarAsync<Guid>(sql,
                new
                {
                    Id = services.Id,
                    Name = services.Name,
                    Description = services.Description,
                    Schedule = services.Schedule,
                    Price = services.Price,
                    Photo = services.Photo,
                    this_id_user_create = services.this_id_user_create
                });
            return result;
        }
    }
}
