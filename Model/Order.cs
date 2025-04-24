using System;
using System.Collections.Generic;

namespace Phamquangha_2122110195_1.Model
{
    public class Order
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }

        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = "Pending";

        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set; } = DateTime.Now;

        // Thêm User_id để liên kết với người dùng
        public int User_id { get; set; }

        // Navigation property
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public User User { get; set; }
    }
}
