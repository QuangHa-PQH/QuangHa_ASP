using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phamquangha_2122110195_1.Data;
using Phamquangha_2122110195_1.Model;
using System;
using System.Linq;

namespace Phamquangha_2122110195_1.Controllers
{
    [Authorize] // Đảm bảo yêu cầu token để truy cập vào các hành động này
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Order (Lấy danh sách đơn hàng)
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var username = User.Identity?.Name; // Lấy tên người dùng từ token
            var user = _context.Users.FirstOrDefault(u => u.Name == username);

            if (user == null)
                return Unauthorized("User không tồn tại.");

            var orders = _context.Orders
                .Where(o => o.User_id == user.Id)
                .Include(o => o.OrderDetails) // Bao gồm các chi tiết đơn hàng
                .ToList();
            return Ok(orders);
        }

        // GET: api/Order/{id} (Lấy đơn hàng theo ID)
        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            var username = User.Identity?.Name; // Lấy tên người dùng từ token
            var user = _context.Users.FirstOrDefault(u => u.Name == username);

            if (user == null)
                return Unauthorized("User không tồn tại.");

            var order = _context.Orders
                .Include(o => o.OrderDetails) // Bao gồm các chi tiết đơn hàng
                .FirstOrDefault(o => o.Id == id);

            if (order == null)
                return NotFound();

            // Kiểm tra nếu đơn hàng không thuộc về người dùng hiện tại, trả về Forbidden
            if (order.User_id != user.Id)
                return Forbid("Bạn không có quyền truy cập đơn hàng này.");

            return Ok(order);
        }

        // POST: api/Order (Thêm đơn hàng mới)
        [HttpPost]
        public IActionResult CreateOrder([FromBody] Order order)
        {
            if (order == null)
                return BadRequest();

            var username = User.Identity?.Name;
            var user = _context.Users.FirstOrDefault(u => u.Name == username);

            if (user == null)
                return Unauthorized("User không tồn tại.");

            order.User_id = user.Id; // Gán User_id của đơn hàng là ID của người dùng hiện tại
            _context.Orders.Add(order);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
        }

        // PUT: api/Order/{id} (Cập nhật đơn hàng)
        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id, [FromBody] Order order)
        {
            var username = User.Identity?.Name;
            var user = _context.Users.FirstOrDefault(u => u.Name == username);

            if (user == null)
                return Unauthorized();

            var existingOrder = _context.Orders.Find(id);
            if (existingOrder == null)
                return NotFound();

            // Kiểm tra quyền chỉnh sửa: người dùng chỉ có thể sửa đơn hàng của chính họ
            if (existingOrder.User_id != user.Id)
                return Forbid("Bạn không có quyền sửa đơn hàng này.");

            // Cập nhật thông tin đơn hàng
            existingOrder.CustomerName = order.CustomerName;
            existingOrder.CustomerEmail = order.CustomerEmail;
            existingOrder.CustomerPhone = order.CustomerPhone;
            existingOrder.CustomerAddress = order.CustomerAddress;
            existingOrder.TotalPrice = order.TotalPrice;
            existingOrder.Status = order.Status;
            existingOrder.Updated_at = DateTime.Now;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/Order/{id} (Xóa đơn hàng)
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var username = User.Identity?.Name;
            var user = _context.Users.FirstOrDefault(u => u.Name == username);

            if (user == null)
                return Unauthorized();

            var order = _context.Orders.Find(id);
            if (order == null)
                return NotFound();

            // Kiểm tra quyền xóa: người dùng chỉ có thể xóa đơn hàng của chính họ
            if (order.User_id != user.Id)
                return Forbid("Bạn không có quyền xóa đơn hàng này.");

            _context.Orders.Remove(order);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
