using Abstractions.Models;

namespace Abstractions.Interfaces.DA
{
    public interface ICategoriesBW
    {
        Task<IEnumerable<Categories>> Get();
        Task<Categories> Get(Guid Id);
        Task<Guid> Add(CategoriesRequest categories);
        Task<Guid> Update(Categories categories);
        Task<Guid> Delete(Guid Id);
    }
}
