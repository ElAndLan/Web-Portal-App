using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webportalapp.Infrastructure.Persistence.PostgreSQL;

namespace webportalapp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDB : ControllerBase
    {
        private readonly AppSQLContext _context;

        public TestDB(AppSQLContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _context.Users.ToListAsync();

            return Ok(result);
        }
    }
}
