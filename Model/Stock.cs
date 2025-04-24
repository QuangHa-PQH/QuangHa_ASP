namespace Phamquangha_2122110195_1.Model
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }          // Mã sản phẩm
        public int Quantity { get; set; }           // Số lượng tồn kho
        public DateTime LastUpdated { get; set; } = DateTime.Now;

        // (Tuỳ chọn) Thêm navigation nếu bạn có entity Product
        // public Product Product { get; set; }
    }
}
