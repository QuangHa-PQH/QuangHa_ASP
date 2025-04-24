using System;

namespace Phamquangha_2122110195_1.Model
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }         // Tiêu đề bài viết
        public string Slug { get; set; }          // Đường dẫn SEO
        public string Summary { get; set; }       // Tóm tắt ngắn
        public string Thumbnail { get; set; }     // Ảnh đại diện
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;
    }
}
