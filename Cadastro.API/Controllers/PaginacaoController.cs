using Cadastro.DATA.Context;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaginacaoController : ControllerBase
    {

        private readonly ContextDb _context;

        public PaginacaoController(ContextDb context)
        {
            _context = context;
        }

        // [HttpGet("page/{page?}")]
        // public async Task<IActionResult> GetSourcePaginated(int? page)
        // {
        //     page ??= 1;
        //     if (page <= 0) page = 1;

        //     var result = await _context
        //        .Source
        //        .AsNoTracking()
        //        .OrderBy(c => c.Id)
        //        .ToPaginatedRestAsync(page.Value, 10);
        //     return Ok(result);
    }
}
