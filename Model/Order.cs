namespace Phamquangha_2122110195_1.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int User_id { get; set; }
        public  string Note { get; set; }
        public string Shipping_address { get; set; }
        public decimal Total_amount { get; set; }
        public DateTime Orderdate { get; set; }
        public string Status { get; set; }
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;
    }
}
