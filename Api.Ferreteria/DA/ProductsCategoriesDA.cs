using Abstractions.Interfaces.DA;
using Abstractions.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace DA
{
    public class ProductsCategoriesDA : IProductsCategoriesDA
    {
        private IDapperRepositoryDA _dapperRepository;
        private SqlConnection _sqlConnection;

        public ProductsCategoriesDA(IDapperRepositoryDA dapperRepository)
        {
            _dapperRepository = dapperRepository;
            _sqlConnection = _dapperRepository.GetDapperRepository();
        }

        public async Task<Guid> Add(ProductsCategories productsCategories)
        {
            string sql = @"Add_ProductsCategories";
            var result = await _sqlConnection.ExecuteScalarAsync<Guid>(sql,
                new
                {
                    IdProduct = productsCategories.IdProduct,
                    IdCategory = productsCategories.IdCategory,
                    Name = productsCategories.Name
                });
            return result;
        }

        public async Task<Guid> Delete(Guid Id)
        {
            string sql = @"Delete_ProductsCategories";
            var consultResultTemp = await Get(Id);
            if (consultResultTemp == null)
                return Guid.Empty;
            var result = await _sqlConnection.ExecuteScalarAsync<Guid>(sql, new { Id = Id });
            return result;
        }

        public async Task<IEnumerable<ProductsCategories>> Get()
        {
            string sql = @"Get_Suppliers";
            var result = await _sqlConnection.QueryAsync<ProductsCategories>(sql);
            return result;
        }

        public Task<ProductsCategories> Get(Guid IdProduct)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Update(ProductsCategories productsCategories)
        {
            throw new NotImplementedException();
        }
    }
}
