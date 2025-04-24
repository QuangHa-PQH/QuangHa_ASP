using Microsoft.AspNetCore.Mvc;
using Phamquangha_2122110195_1.Data;
using Phamquangha_2122110195_1.Model;
using Microsoft.EntityFrameworkCore;

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
            try
            {
                var products = _context.Products.ToList();
                return Ok(new { data = products });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi server: {ex.Message}");
            }
        }

        // GET: api/Product/{id} (Lấy sản phẩm theo ID)
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                var product = _context.Products.Find(id);
                if (product == null)
                    return NotFound("Sản phẩm không tồn tại.");

                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi server: {ex.Message}");
            }
        }

        // POST: api/Product (Thêm sản phẩm mới)
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            if (product == null)
                return BadRequest("Dữ liệu sản phẩm không hợp lệ.");

            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
            }
            catch (DbUpdateException dbEx)
            {
                return StatusCode(500, $"Lỗi khi lưu dữ liệu: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi server: {ex.Message}");
            }
        }

        // PUT: api/Product/{id} (Cập nhật sản phẩm)
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            if (product == null)
                return BadRequest("Dữ liệu sản phẩm không hợp lệ.");

            try
            {
                var existingProduct = _context.Products.Find(id);
                if (existingProduct == null)
                    return NotFound("Sản phẩm không tồn tại.");

                existingProduct.Name = product.Name;
                existingProduct.Slug = product.Slug;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.Quantity = product.Quantity;
                existingProduct.Category_id = product.Category_id;
                existingProduct.Image = product.Image;
                existingProduct.Brand_id = product.Brand_id;
                existingProduct.Updated_at = DateTime.Now;

                _context.SaveChanges();
                return NoContent();
            }
            catch (DbUpdateException dbEx)
            {
                return StatusCode(500, $"Lỗi khi cập nhật dữ liệu: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi server: {ex.Message}");
            }
        }

        // DELETE: api/Product/{id} (Xóa sản phẩm)
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                var product = _context.Products.Find(id);
                if (product == null)
                    return NotFound("Sản phẩm không tồn tại.");

                _context.Products.Remove(product);
                _context.SaveChanges();
                return NoContent();
            }
            catch (DbUpdateException dbEx)
            {
                return StatusCode(500, $"Lỗi khi xóa dữ liệu: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi server: {ex.Message}");
            }
        }

        // GET: api/Product/category/{categoryId} (Lấy sản phẩm theo danh mục)
        [HttpGet("category/{categoryId}")]
        public IActionResult GetProductsByCategory(int categoryId)
        {
            try
            {
                var products = _context.Products
                    .Where(p => p.Category_id == categoryId)
                    .ToList();

                if (products == null || products.Count == 0)
                    return NotFound("Không có sản phẩm nào trong danh mục này.");

                return Ok(new { data = products });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi server: {ex.Message}");
            }
        }

    }
}
