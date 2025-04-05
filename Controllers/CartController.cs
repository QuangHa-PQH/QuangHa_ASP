/*using Microsoft.AspNetCore.Mvc;
using Phamquangha_2122110195_1.Data;
using Phamquangha_2122110195_1.Model;

namespace Phamquangha_2122110195_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Cart (Lấy danh sách giỏ hàng)
        [HttpGet]
        public IActionResult GetAllCarts()
        {
            var carts = _context.Carts.ToList();
            return Ok(carts);
        }

        // GET: api/Cart/{id} (Lấy giỏ hàng theo ID)
        [HttpGet("{id}")]
        public IActionResult GetCartById(int id)
        {
            var cart = _context.Carts.Find(id);
            if (cart == null)
                return NotFound();

            return Ok(cart);
        }

        // POST: api/Cart (Thêm sản phẩm vào giỏ hàng)
        [HttpPost]
        public IActionResult AddToCart([FromBody] Cart cart)
        {
            if (cart == null)
                return BadRequest();

            _context.Carts.Add(cart);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCartById), new { id = cart.Id }, cart);
        }

        // PUT: api/Cart/{id} (Cập nhật số lượng sản phẩm trong giỏ hàng)
        [HttpPut("{id}")]
        public IActionResult UpdateCart(int id, [FromBody] Cart cart)
        {
            var existingCart = _context.Carts.Find(id);
            if (existingCart == null)
                return NotFound();

            existingCart.User_id = cart.User_id;
            existingCart.Product_id = cart.Product_id;
            existingCart.Quantity = cart.Quantity;
            existingCart.Updated_at = DateTime.Now;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/Cart/{id} (Xóa sản phẩm khỏi giỏ hàng)
        [HttpDelete("{id}")]
        public IActionResult RemoveFromCart(int id)
        {
            var cart = _context.Carts.Find(id);
            if (cart == null)
                return NotFound();

            _context.Carts.Remove(cart);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
*/