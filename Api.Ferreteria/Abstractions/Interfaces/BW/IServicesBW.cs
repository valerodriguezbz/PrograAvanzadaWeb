using Abstractions.Models;

namespace Abstractions.Interfaces.BW
{
    public interface IServicesBW
    {
        Task<IEnumerable<Services>> Get();
        Task<Services> Get(int Id);
        Task<Guid> Add(ServicesRequest services);
        Task<Guid> Update(Services services);
        Task<Guid> Delete(int Id);
    }
}
