namespace FavoriteService.API.Dtos
{
    public class FavoriteProductDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
    }
}
