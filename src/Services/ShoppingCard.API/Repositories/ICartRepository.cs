﻿using ShoppingCard.API.Dtos;

namespace ShoppingCard.API.Repositories
{
    public interface ICartRepository
    {
        Task<CartDto> GetCartByUserId(string userId);

        CartDto GetCartByUserIdNonAsync(string userId);
        Task<CartDto> CreateUpdateCart(CartDto cartDto);
        Task<bool> UpdateCartDetails(CartDetailsDto cartDetailsDto);
        Task<bool> RemoveFromCart(int cartDetailsId);
        Task<bool> ApplyCoupon(string userId, string couponCode);
        Task<bool> RemoveCoupon(string userId);
        Task<bool> ClearCart(string userId);
    }
}
