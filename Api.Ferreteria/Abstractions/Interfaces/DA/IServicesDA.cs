using Abstractions.Models;

namespace Abstractions.Interfaces.DA
{
    public interface IServicesDA
    {
        Task<IEnumerable<Services>> Get();
        Task<Services> Get(int Id);
        Task<Guid> Add(ServicesRequest services);
        Task<Guid> Update(Services services);
        Task<Guid> Delete(int Id);
    }
}
