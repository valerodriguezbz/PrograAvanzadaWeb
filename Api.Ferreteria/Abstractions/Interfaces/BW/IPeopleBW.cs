using Abstractions.Models;

namespace Abstractions.Interfaces.BW
{
    public interface IPeopleController
    {
        Task<IEnumerable<People>> Get();
        Task<People> Get(Guid Id);
        Task<Guid> Add(PeopleRequest people);
        Task<Guid> Update(People people);
        Task<Guid> Delete(Guid Id);
    }
}
