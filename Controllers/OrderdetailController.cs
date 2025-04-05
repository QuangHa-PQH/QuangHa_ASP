/*using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetAllOrderdetail()
        {
            var Orderdetail = _context.Orderdetail.ToList();
            return Ok(Orderdetail);
        }

        // GET: api/OrderDetail/{id}
        [HttpGet("{id}")]
        public IActionResult GetOrderDetailById(int id)
        {
            var detail = _context.Orderdetail.Find(id);
            if (detail == null)
                return NotFound();

            return Ok(detail);
        }

        // POST: api/OrderDetail
        [HttpPost]
        public IActionResult CreateOrderDetail([FromBody] Orderdetail detail)
        {
            if (detail == null)
                return BadRequest();

            _context.Orderdetail.Add(detail);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetOrderDetailById), new { id = detail.Id }, detail);
        }

        // PUT: api/OrderDetail/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateOrderDetail(int id, [FromBody] Orderdetail detail)
        {
            var existing = _context.Orderdetail.Find(id);
            if (existing == null)
                return NotFound();

            existing.Order_id = detail.Order_id;
            existing.Product_id = detail.Product_id;
            existing.Quantity = detail.Quantity;
            existing.Price = detail.Price;
            existing.Updated_at = DateTime.Now;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/OrderDetail/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteOrderDetail(int id)
        {
            var detail = _context.Orderdetail.Find(id);
            if (detail == null)
                return NotFound();

            _context.Orderdetail.Remove(detail);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
*/