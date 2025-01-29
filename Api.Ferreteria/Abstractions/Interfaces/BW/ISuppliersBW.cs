using Abstractions.Models;

namespace Abstractions.Interfaces.BW
{
    public interface ISuppliersController
    {
        Task<IEnumerable<CartsxProducts>> Get();
        Task<CartsxProducts> Get(Guid Id);
        Task<Guid> Add(SuppliersRequest suppliers);
        Task<Guid> Update(CartsxProducts suppliers);
        Task<Guid> Delete(Guid Id);
    }
}
