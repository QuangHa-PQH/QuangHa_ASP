using Phamquangha_2122110195_1.Model;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    public int Id { get; set; }  // Khóa chính

    public string Name { get; set; }
    public string Slug { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    // Foreign Keys
    public int Category_id { get; set; }
    public int Brand_id { get; set; }

    public string Image { get; set; }
    public DateTime Created_at { get; set; } = DateTime.Now;
    public DateTime Updated_at { get; set; } = DateTime.Now;

    // Navigation
    [ForeignKey("Category_id")]
    public Category? Category { get; set; }  // Liên kết với Category

    [ForeignKey("Brand_id")]
    public Brand? Brand { get; set; }  // Liên kết với Brand
}
