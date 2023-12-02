namespace OrderService.API.Messages
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Img { get; set; }
    }
}
