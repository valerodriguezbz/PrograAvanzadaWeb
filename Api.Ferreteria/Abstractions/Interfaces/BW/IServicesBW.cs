using Abstractions.Models;

namespace Abstractions.Interfaces.BW
{
    public interface IServicesController
    {
        Task<IEnumerable<Services>> Get();
        Task<Services> Get(Guid Id);
        Task<Guid> Add(ServicesRequest services);
        Task<Guid> Update(Services services);
        Task<Guid> Delete(Guid Id);
    }
}
