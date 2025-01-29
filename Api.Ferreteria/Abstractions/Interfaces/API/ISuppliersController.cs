using Abstractions.Models;
using Microsoft.AspNetCore.Mvc;

namespace Abstractions.Interfaces.API
{
    public interface ISuppliersController
    {
        Task<IActionResult> Get();
        Task<IActionResult> Get([FromRoute] Guid Id);
        Task<IActionResult> Add([FromBody] SuppliersRequest suppliers);
        Task<IActionResult> Update([FromBody] CartsxProducts suppliers);
        Task<IActionResult> Delete([FromRoute] Guid Id);
    }
}
