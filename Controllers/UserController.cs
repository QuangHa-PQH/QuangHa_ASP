using Microsoft.AspNetCore.Mvc;
using Phamquangha_2122110195_1.Data;
using Phamquangha_2122110195_1.Model;

namespace Phamquangha_2122110195_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/User (Lấy danh sách user)
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        // GET: api/User/{id} (Lấy user theo ID)
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        // POST: api/User (Thêm user mới)
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (user == null)
                return BadRequest();

            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        // PUT: api/User/{id} (Cập nhật user)
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User user)
        {
            var existingUser = _context.Users.Find(id);
            if (existingUser == null)
                return NotFound();

            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            existingUser.Password = user.Password;
            existingUser.Phone = user.Phone;
            existingUser.Address = user.Address;
            existingUser.Role = user.Role;
            existingUser.Updated_at = DateTime.Now;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/User/{id} (Xóa user)
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
                return NotFound();

            _context.Users.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
