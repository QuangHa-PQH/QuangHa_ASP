using Microsoft.EntityFrameworkCore;
using Phamquangha_2122110195_1.Model;

namespace Phamquangha_2122110195_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostDetail> PostDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Thiết lập khóa ngoại từ OrderDetail → Order
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Cascade); // Xóa Order sẽ xóa chi tiết

            // Thiết lập khóa ngoại từ OrderDetail → Product
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany() // Không cần navigation ngược ở Product
                .HasForeignKey(od => od.ProductId)
                .OnDelete(DeleteBehavior.Restrict); // Không cho xóa product nếu có trong đơn

            // Product → Category
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.Category_id)
                .OnDelete(DeleteBehavior.Restrict);

            // Product → Brand
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Brand)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.Brand_id)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
