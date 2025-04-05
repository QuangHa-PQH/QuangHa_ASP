/*using Microsoft.AspNetCore.Mvc;
using Phamquangha_2122110195_1.Data;
using Phamquangha_2122110195_1.Model;

namespace Phamquangha_2122110195_1.Controllers
{
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
            var orders = _context.Orders.ToList();
            return Ok(orders);
        }

        // GET: api/Order/{id} (Lấy đơn hàng theo ID)
        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            var order = _context.Orders.Find(id);
            if (order == null)
                return NotFound();

            return Ok(order);
        }

        // POST: api/Order (Thêm đơn hàng mới)
        [HttpPost]
        public IActionResult CreateOrder([FromBody] Order order)
        {
            if (order == null)
                return BadRequest();

            _context.Orders.Add(order);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
        }

        // PUT: api/Order/{id} (Cập nhật đơn hàng)
        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id, [FromBody] Order order)
        {
            var existingOrder = _context.Orders.Find(id);
            if (existingOrder == null)
                return NotFound();

            existingOrder.User_id = order.User_id;
            existingOrder.Note = order.Note;
            existingOrder.Shipping_address = order.Shipping_address;
            existingOrder.Total_amount = order.Total_amount;
            existingOrder.Orderdate = order.Orderdate;
            existingOrder.Status = order.Status;
            existingOrder.Updated_at = DateTime.Now;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/Order/{id} (Xóa đơn hàng)
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var order = _context.Orders.Find(id);
            if (order == null)
                return NotFound();

            _context.Orders.Remove(order);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
*/