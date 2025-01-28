using Microsoft.Data.SqlClient;

namespace Abstractions.Interfaces.DA
{
    public interface IDapperRepositoryBW
    {
        SqlConnection GetDapperRepository();
    }
}
