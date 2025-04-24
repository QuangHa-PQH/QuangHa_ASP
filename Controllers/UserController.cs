using Phamquangha_2122110195_1.Model;
using Phamquangha_2122110195_1.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BCrypt.Net;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Phamquangha_2122110195_1.DTO;
using Phamquangha_2122110195_1.Services;

namespace Phamquangha_2122110195_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly JwtService _jwtService;

        public UserController(AppDbContext context, JwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        // GET: api/User
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _context.Users.Select(u => new UserDTO
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email,
                Phone = u.Phone,
                Address = u.Address,
                Role = u.Role
            }).ToList();

            return Ok(users);
        }

        // GET: api/User/{id}
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
                return NotFound(new { message = "Người dùng không tìm thấy" });

            return Ok(new UserDTO
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Phone = user.Phone,
                Address = user.Address,
                Role = user.Role
            });
        }

        // PUT: api/User/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] UserDTO model)
        {
            var user = _context.Users.Find(id);
            if (user == null)
                return NotFound(new { message = "Người dùng không tìm thấy" });

            user.Name = model.Name ?? user.Name;
            user.Email = model.Email ?? user.Email;
            user.Phone = model.Phone ?? user.Phone;
            user.Address = model.Address ?? user.Address;
            user.Role = model.Role ?? user.Role;


            _context.Users.Update(user);
            _context.SaveChanges();

            return Ok(new { message = "Cập nhật thành công" });
        }

        // DELETE: api/User/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
                return NotFound(new { message = "Người dùng không tìm thấy" });

            _context.Users.Remove(user);
            _context.SaveChanges();

            return Ok(new { message = "Xóa người dùng thành công" });
        }

        private int GetUserIdFromToken()
        {
            var claim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            return claim != null ? int.Parse(claim.Value) : 0;
        }
    }
}
