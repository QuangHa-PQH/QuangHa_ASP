using Microsoft.AspNetCore.Mvc;
using Phamquangha_2122110195_1.Data;
using Phamquangha_2122110195_1.Model;

namespace Phamquangha_2122110195_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrderDetailController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/OrderDetail
        [HttpGet]
        public IActionResult GetAllOrderDetail()
        {
            var orderDetails = _context.OrderDetail.ToList();
            return Ok(orderDetails);
        }

        // GET: api/OrderDetail/{id}
        [HttpGet("{id}")]
        public IActionResult GetOrderDetailById(int id)
        {
            var detail = _context.OrderDetail.Find(id);
            if (detail == null)
                return NotFound();

            return Ok(detail);
        }

        // POST: api/OrderDetail
        [HttpPost]
        public IActionResult CreateOrderDetail([FromBody] OrderDetail detail)
        {
            if (detail == null)
                return BadRequest();

            _context.OrderDetail.Add(detail);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetOrderDetailById), new { id = detail.Id }, detail);
        }

        // PUT: api/OrderDetail/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateOrderDetail(int id, [FromBody] OrderDetail detail)
        {
            var existing = _context.OrderDetail.Find(id);
            if (existing == null)
                return NotFound();

            existing.OrderId = detail.OrderId;  // Cập nhật với tên mới
            existing.ProductId = detail.ProductId;  // Cập nhật với tên mới
            existing.Quantity = detail.Quantity;
            existing.UnitPrice = detail.UnitPrice;  // Cập nhật với tên mới
            existing.Updated_at = DateTime.Now;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/OrderDetail/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteOrderDetail(int id)
        {
            var detail = _context.OrderDetail.Find(id);
            if (detail == null)
                return NotFound();

            _context.OrderDetail.Remove(detail);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
