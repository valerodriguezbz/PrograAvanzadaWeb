using Abstractions.Models;

namespace Abstractions.Interfaces.DA
{
    public interface IServicesBW
    {
        Task<IEnumerable<Services>> Get();
        Task<Services> Get(Guid Id);
        Task<Guid> Add(ServicesRequest services);
        Task<Guid> Update(Services services);
        Task<Guid> Delete(Guid Id);
    }
}
