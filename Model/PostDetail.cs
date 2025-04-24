using System;

namespace Phamquangha_2122110195_1.Model
{
    public class PostDetail
    {
        public int Id { get; set; }
        public int PostId { get; set; }           // Liên kết đến Post
        public string Content { get; set; }       // Nội dung HTML đầy đủ
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;

        // Navigation property (nếu dùng Entity Framework)
        public Post Post { get; set; }
    }
}
