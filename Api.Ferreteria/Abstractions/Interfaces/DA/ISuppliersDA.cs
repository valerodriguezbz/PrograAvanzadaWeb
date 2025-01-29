using Abstractions.Models;

namespace Abstractions.Interfaces.DA
{
    public interface ISuppliersDA
    {
        Task<IEnumerable<CartsxProducts>> Get();
        Task<CartsxProducts> Get(Guid Id);
        Task<Guid> Add(SuppliersRequest suppliers);
        Task<Guid> Update(CartsxProducts suppliers);
        Task<Guid> Delete(Guid Id);
    }
}
