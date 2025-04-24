using Microsoft.AspNetCore.Mvc;
using Phamquangha_2122110195_1.Model;
using Microsoft.EntityFrameworkCore;
using Phamquangha_2122110195_1.Data;

namespace Phamquangha_2122110195_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostDetailController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PostDetailController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PostDetail/5
        [HttpGet("{postId}")]
        public async Task<ActionResult<PostDetail>> GetDetail(int postId)
        {
            var detail = await _context.PostDetails.FirstOrDefaultAsync(p => p.PostId == postId);
            if (detail == null) return NotFound();
            return detail;
        }

        // POST: api/PostDetail
        [HttpPost]
        public async Task<ActionResult<PostDetail>> CreateDetail(PostDetail detail)
        {
            _context.PostDetails.Add(detail);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetDetail), new { postId = detail.PostId }, detail);
        }

        // PUT: api/PostDetail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDetail(int id, PostDetail detail)
        {
            if (id != detail.Id) return BadRequest();
            _context.Entry(detail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.PostDetails.Any(e => e.Id == id)) return NotFound();
                throw;
            }

            return NoContent();
        }

        // DELETE: api/PostDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetail(int id)
        {
            var detail = await _context.PostDetails.FindAsync(id);
            if (detail == null) return NotFound();

            _context.PostDetails.Remove(detail);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
