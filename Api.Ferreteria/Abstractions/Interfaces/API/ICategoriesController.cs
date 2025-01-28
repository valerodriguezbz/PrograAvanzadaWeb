using Abstractions.Models;
using Microsoft.AspNetCore.Mvc;

namespace Abstractions.Interfaces.API
{
    public interface ICategoriesController
    {
        Task<IActionResult> Get();
        Task<IActionResult> Get([FromRoute] Guid Id);
        Task<IActionResult> Add([FromBody] CategoriesRequest categories);
        Task<IActionResult> Update([FromBody] Categories categories);
        Task<IActionResult> Delete([FromRoute] Guid Id);
    }
}
