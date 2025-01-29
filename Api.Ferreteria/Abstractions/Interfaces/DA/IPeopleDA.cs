using Abstractions.Models;

namespace Abstractions.Interfaces.DA
{
    public interface IPeopleDA
    {
        Task<IEnumerable<People>> Get();
        Task<People> Get(int Id);
        Task<Guid> Add(PeopleRequest people);
        Task<Guid> Update(People people);
        Task<Guid> Delete(int Id);
    }
}
