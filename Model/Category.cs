﻿namespace Phamquangha_2122110195_1.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set;} = DateTime.Now;
    }
}
