using System.ComponentModel.DataAnnotations;

namespace Phamquangha_2122110195_1.Model
{
    public class Cart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set;}
        public int CartId { get; set;} = 0;
        public string Image {  get; set; }

    }
}
