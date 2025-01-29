using Abstractions.Models;

namespace Abstractions.Interfaces.BW
{
    public interface IProductsxCategoriesBW
    {
        Task<IEnumerable<ProductsCategories>> Get();
        Task<ProductsCategories> Get(Guid IdProduct);
        Task<Guid> Add(ProductsCategories productsCategories);
        Task<Guid> Update(ProductsCategories productsCategories);
        Task<Guid> Delete(Guid Id);
    }
}
