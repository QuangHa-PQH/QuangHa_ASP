using System.ComponentModel.DataAnnotations;

namespace Phamquangha_2122110195_1.Model
{
    public class Cart
    {
        public int Id { get; set; }
        public int User_id { get; set; }
        public int Product_id { get; set; }
        public int Quantity { get; set; }
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;

    }
}
