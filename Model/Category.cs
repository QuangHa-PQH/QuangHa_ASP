namespace Phamquangha_2122110195_1.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; } = 0;
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
