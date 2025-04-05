using Microsoft.AspNetCore.Mvc;
using Phamquangha_2122110195_1.Data;
using Phamquangha_2122110195_1.Model;

namespace Phamquangha_2122110195_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Product (Lấy danh sách sản phẩm)
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        // GET: api/Product/{id} (Lấy sản phẩm theo ID)
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        // POST: api/Product (Thêm sản phẩm mới)
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            if (product == null)
                return BadRequest();

            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        // PUT: api/Product/{id} (Cập nhật sản phẩm)
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            var existingProduct = _context.Products.Find(id);
            if (existingProduct == null)
                return NotFound();

            existingProduct.Name = product.Name;
            existingProduct.Slug = product.Slug;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.Quantity = product.Quantity;
            existingProduct.Category_id = product.Category_id;
            existingProduct.Image = product.Image;
            existingProduct.Updated_at = DateTime.Now;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/Product/{id} (Xóa sản phẩm)
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
                return NotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
