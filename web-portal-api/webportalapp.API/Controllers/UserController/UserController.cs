using webportalapp.API.Dtos.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webportalapp.Domain.Entities;
using webportalapp.Infrastructure.Persistence.PostgreSQL;
using webportalapp.API.Mappers;

namespace webportalapp.API.Controllers.UserController
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppSQLContext _context;
        public UserController(AppSQLContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _context.Users.ToList()
                .Select(s => s.ToUserDto());

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute] long id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user.ToUserDto());
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            if (user == null) {
                return NotFound();
            }

            return Ok();
        }
    }
}
