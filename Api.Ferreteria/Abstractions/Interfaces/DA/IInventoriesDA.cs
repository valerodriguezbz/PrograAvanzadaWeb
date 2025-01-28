using Abstractions.Models;

namespace Abstractions.Interfaces.DA
{
    public interface IInventoriesDA
    {
        Task<IEnumerable<Inventories>> Get();
        Task<Inventories> Get(Guid Id);
        Task<Guid> Add(InventoriesRequest inventories);
        Task<Guid> Update(Inventories inventories);
        Task<Guid> Delete(Guid Id);
    }
}
