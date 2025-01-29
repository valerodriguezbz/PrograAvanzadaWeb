using Abstractions.Interfaces.DA;
using Abstractions.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace DA
{
    public class InventoriesDA : IInventoriesDA
    {
        private IDapperRepositoryDA _dapperRepository;
        private SqlConnection _sqlConnection;

        public InventoriesDA(IDapperRepositoryDA dapperRepository)
        {
            _dapperRepository = dapperRepository;
            _sqlConnection = _dapperRepository.GetDapperRepository();
        }

        public async Task<Guid> Add(InventoriesRequest inventories)
        {
            string sql = @"Add_Inventories";
            var result = await _sqlConnection.ExecuteScalarAsync<Guid>(sql,
                new
                {
                    IdProduct = inventories.IdProduct,
                    IdSupplier = inventories.IdSupplier,
                    Stock = inventories.Stock,
                    Created_At = inventories.Created_at,
                    this_id_user_create = inventories.this_id_user_create
                });
            return result;
        }

        public async Task<Guid> Delete(int Id)
        {
            string sql = @"Delete_Inventories";
            var consultResultTemp = await Get(Id);
            if (consultResultTemp == null)
                return Guid.Empty;
            var result = await _sqlConnection.ExecuteScalarAsync<Guid>(sql, new { Id = Id });
            return result;
        }

        public async Task<IEnumerable<Inventories>> Get()
        {
            string sql = @"Get_Inventories";
            var result = await _sqlConnection.QueryAsync<Inventories>(sql);
            return result;
        }

        public async Task<Inventories> Get(int Id)
        {
            string sql = @"Get_Inventory";
            var result = await _sqlConnection.QueryAsync<Inventories>(sql, new { Id = Id });
            if (result.FirstOrDefault() == null)
                return null;
            return result.FirstOrDefault();
        }

        public async Task<Guid> Update(Inventories inventories)
        {
            string sql = @"Update_Inventories";
            var resultTemp = await Get(inventories.Id);
            if (resultTemp == null)
                return Guid.Empty;
            var result = await _sqlConnection.ExecuteScalarAsync<Guid>(sql,
                new
                {
                    Id = inventories.Id,
                    IdProduct = inventories.IdProduct,
                    IdSupplier = inventories.IdSupplier,
                    Stock = inventories.Stock,
                    Updated_at = inventories.Updated_at,
                    this_id_user_create = inventories.this_id_user_create
                });
            return result;
        }
    }
}
