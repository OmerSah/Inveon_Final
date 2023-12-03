using FavoriteService.API.Dtos;

namespace FavoriteService.API.Repositories
{
    public interface IFavoriteProductRepository
    {
        Task<List<ProductDto>> GetFavoritesByUserId(string userId);        
        Task<bool> RemoveFromFavorites(string userId, int productId);
        Task<FavoriteProductDto> AddToFavorites(string userId, ProductDto product);
        Task<bool> RemoveAllFavorites(string userId);
    }
}
