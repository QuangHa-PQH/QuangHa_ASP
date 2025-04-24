using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phamquangha_2122110195_1.Data;
using Phamquangha_2122110195_1.Model;

namespace Phamquangha_2122110195_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BrandController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Brand
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetBrands()
        {
            // Chỉ lấy các trường cần thiết và không kèm theo các sản phẩm
            var brands = await _context.Brands
                .Select(b => new
                {
                    b.Id,
                    b.Name,
                    b.Slug,
                    b.Description,
                    b.Image
                })
                .ToListAsync();

            return Ok(brands);
        }

        // GET: api/Brand/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetBrand(int id)
        {
            var brand = await _context.Brands
                .Where(b => b.Id == id)
                .Select(b => new
                {
                    b.Id,
                    b.Name,
                    b.Slug,
                    b.Description,
                    b.Image
                })
                .FirstOrDefaultAsync();

            if (brand == null)
                return NotFound();

            return Ok(brand);
        }

        // POST: api/Brand
        [HttpPost]
        public async Task<ActionResult> CreateBrand(Brand brand)
        {
            // Kiểm tra tính hợp lệ của dữ liệu
            if (brand == null)
                return BadRequest("Dữ liệu thương hiệu không hợp lệ.");

            // Thêm thương hiệu vào cơ sở dữ liệu
            _context.Brands.Add(brand);
            await _context.SaveChangesAsync();

            // Trả về dữ liệu thương hiệu vừa tạo mà không kèm các sản phẩm
            var createdBrand = await _context.Brands
                .Where(b => b.Id == brand.Id)
                .Select(b => new
                {
                    b.Id,
                    b.Name,
                    b.Slug,
                    b.Description,
                    b.Image
                })
                .FirstOrDefaultAsync();

            return CreatedAtAction(nameof(GetBrand), new { id = createdBrand.Id }, createdBrand);
        }

        // PUT: api/Brand/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBrand(int id, Brand brand)
        {
            // Kiểm tra nếu ID không trùng khớp
            if (id != brand.Id)
                return BadRequest("ID không hợp lệ.");

            // Cập nhật thông tin thương hiệu
            _context.Entry(brand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Brands.Any(e => e.Id == id))
                    return NotFound();
                throw;
            }

            return NoContent();
        }

        // DELETE: api/Brand/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            var brand = await _context.Brands.FindAsync(id);
            if (brand == null)
                return NotFound();

            // Xóa thương hiệu
            _context.Brands.Remove(brand);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
