using Abstractions.Models;
using Microsoft.AspNetCore.Mvc;

namespace Abstractions.Interfaces.API
{
    public interface IInventoriesController
    {
        Task<IActionResult> Get();
        Task<IActionResult> Get([FromRoute] Guid Id);
        Task<IActionResult> Add([FromBody] InventoriesRequest inventories);
        Task<IActionResult> Update([FromBody] Inventories inventories);
        Task<IActionResult> Delete([FromRoute] Guid Id);
    }
}
