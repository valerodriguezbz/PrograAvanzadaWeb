using Abstractions.Models;

namespace Abstractions.Interfaces.BW
{
    public interface ICartsController
    {
        Task<IEnumerable<Carts>> Get();
        Task<Carts> Get(Guid Id);
        Task<Guid> Add(Carts carts);
        Task<Guid> Update(Carts carts);
        Task<Guid> Delete(Guid Id);
    }
}
