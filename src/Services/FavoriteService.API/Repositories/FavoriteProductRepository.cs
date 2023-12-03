using AutoMapper;
using FavoriteService.API.Dtos;
using FavoriteService.API.Context;
using FavoriteService.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FavoriteService.API.Repositories
{
    public class FavoriteProductRepository : IFavoriteProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public FavoriteProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<FavoriteProductDto> AddToFavorites(string userId, ProductDto product)
        {
            Product productFromDb = _db.Products.Where(x => x.ProductId == product.ProductId).FirstOrDefault();

            if (productFromDb == null)
            {
                _db.Products.Add(_mapper.Map<Product>(product));
                _db.SaveChanges();
            }

            FavoriteProduct favoriteProduct = new FavoriteProduct();
            Product p = _mapper.Map<Product>(product);

            favoriteProduct.ProductId = product.ProductId;
            favoriteProduct.UserId = userId;
            favoriteProduct.Product = null;

            FavoriteProduct favoriteProductFromDb = _db.FavoriteProducts
                .Where(fp => fp.UserId == userId && fp.ProductId == product.ProductId)
                .FirstOrDefault();

            if (favoriteProductFromDb != null) return null; 

            _db.FavoriteProducts.Add(favoriteProduct);
            _db.SaveChanges();

            return _mapper.Map<FavoriteProductDto>(favoriteProduct);
        }

        public async Task<List<ProductDto>> GetFavoritesByUserId(string userId)
        {

            List<FavoriteProduct> favoriteProducts = _db.FavoriteProducts
                .Where(fp => fp.UserId == userId)
                .Include(fp => fp.Product)  // Assuming you have a navigation property named Product in FavoriteProduct
                .ToList();

            List<ProductDto> favoriteProductDtos = _mapper.Map<List<ProductDto>>(favoriteProducts.Select(fp => fp.Product));

            return favoriteProductDtos;
        }

        public async Task<bool> RemoveFromFavorites(string userId, int productId)
        {
            FavoriteProduct favoriteProduct = _db.FavoriteProducts
                .FirstOrDefault(fp => fp.UserId == userId && fp.ProductId == productId);

            if (favoriteProduct != null)
            {
                _db.FavoriteProducts.Remove(favoriteProduct);
                _db.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<bool> RemoveAllFavorites(string userId)
        {
            List<FavoriteProduct> favoriteProducts = _db.FavoriteProducts
                .Where(fp => fp.UserId == userId)
                .ToList();

            if (favoriteProducts != null)
            {
                _db.FavoriteProducts.RemoveRange(favoriteProducts);
                _db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
