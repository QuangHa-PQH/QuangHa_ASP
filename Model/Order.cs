﻿namespace Phamquangha_2122110195_1.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; } = 0;
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductOrderId { get; set;} = 0;
    }
}
