namespace Phamquangha_2122110195_1.Model
{
    public class Orderdetail
    {
        public int Id { get; set; }
        public int Order_id { get; set; }
        public int Product_id { get; set; }
        public decimal Quantity { get; set; }
        public float Price { get; set; }
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;
    }
}
