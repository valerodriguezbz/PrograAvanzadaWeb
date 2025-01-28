using Abstractions.Models;

namespace Abstractions.Interfaces.DA
{
    public interface IPeopleDA
    {
        Task<IEnumerable<People>> Get();
        Task<People> Get(Guid Id);
        Task<Guid> Add(PeopleRequest people);
        Task<Guid> Update(People people);
        Task<Guid> Delete(Guid Id);
    }
}
