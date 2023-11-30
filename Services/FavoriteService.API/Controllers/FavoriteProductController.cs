using FavoriteService.API.Dtos;
using FavoriteService.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FavoriteService.API.Controllers
{
    [ApiController]
    [Route("api/favorites")]
    public class FavoriteProductController
    {
        private readonly IFavoriteProductRepository _favoriteProductRepository;
        protected ResponseDto _response;

        public FavoriteProductController(IFavoriteProductRepository favoriteProductRepository)
        {
            _favoriteProductRepository = favoriteProductRepository;
            this._response = new ResponseDto();
        }

        [HttpGet("{userId}")]
        public async Task<object> GetFavoritesByUserId(string userId)
        {
            try
            {
                var favorites = await _favoriteProductRepository.GetFavoritesByUserId(userId);
                _response.Result = favorites;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]
        public async Task<object> AddToFavorites(FavoriteProductDto favoriteProductDto)
        {
            try
            {
                var favorite = await _favoriteProductRepository.AddToFavorites(favoriteProductDto.UserId, favoriteProductDto.Product);
                if (favorite == null)
                {
                    _response.IsSuccess = false;
                    _response.DisplayMessage = "Product already exists in favorites";
                } else
                {
                    _response.Result = favorite;
                }
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpDelete("{userId}/{productId}")]
        public async Task<object> RemoveFromFavorites(string userId, int productId)
        {
            try
            {
                var favorite = await _favoriteProductRepository.RemoveFromFavorites(userId, productId);
                _response.Result = favorite;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
