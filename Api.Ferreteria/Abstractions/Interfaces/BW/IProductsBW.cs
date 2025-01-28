using Abstractions.Models;

namespace Abstractions.Interfaces.BW
{
    public interface IProductsController
    {
        Task<IEnumerable<Products>> Get();
        Task<Products> Get(Guid Id);
        Task<Guid> Add(ProductsRequest products);
        Task<Guid> Update(Products products);
        Task<Guid> Delete(Guid Id);
    }
}
