namespace ProductsAPI.Models
{
    public class UpdateProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public bool Availability { get; set; }
    }
}
