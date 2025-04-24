using Phamquangha_2122110195_1.Model;

public class OrderDetail
{
    public int Id { get; set; }

    public int OrderId { get; set; }
    public int ProductId { get; set; }

    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public DateTime Created_at { get; set; } = DateTime.Now;
    public DateTime Updated_at { get; set; } = DateTime.Now;

    // Navigation
    public Order Order { get; set; }
    public Product Product { get; set; }
}
