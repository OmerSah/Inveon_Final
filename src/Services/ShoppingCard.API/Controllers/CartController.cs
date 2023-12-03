﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCard.API.Dtos;
using ShoppingCard.API.RabbitMQ;
using ShoppingCard.API.Repositories;

namespace ShoppingCard.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/cart")]
    public class CartController
    {
        private readonly ICartRepository _cartRepository;
        private readonly ICouponRepository _couponRepository;
        // private readonly IMessageBus _messageBus;
        protected ResponseDto _response;
        private readonly IRabbitMQCartMessageSender _rabbitMQCartMessageSender;
        // IMessageBus messageBus,
        public CartController(ICartRepository cartRepository,
            ICouponRepository couponRepository, IRabbitMQCartMessageSender rabbitMQCartMessageSender)
        {
            _cartRepository = cartRepository;
            _couponRepository = couponRepository;
            _rabbitMQCartMessageSender = rabbitMQCartMessageSender;
            //_messageBus = messageBus;
            this._response = new ResponseDto();
        }

        [HttpGet("GetCart/{userId}")]
        public async Task<object> GetCart(string userId)
        {
            try
            {
                CartDto cartDto = await _cartRepository.GetCartByUserId(userId);
                _response.Result = cartDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }



        [HttpPost]
        [Authorize]
        public async Task<object> Post([FromBody] CartDto cartDto)
        {
            try
            {
                if (cartDto.CartHeader.CouponCode == null)
                {
                    cartDto.CartHeader.CouponCode = ""; //
                }
                CartDto model = await _cartRepository.CreateUpdateCart(cartDto);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost("UpdateCart")]
        public async Task<object> UpdateCart(CartDto cartDto)
        {
            try
            {
                CartDto cartDt = await _cartRepository.CreateUpdateCart(cartDto);
                _response.Result = cartDt;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost("UpdateDetails")]
        public async Task<object> UpdateDetails([FromBody] CartDetailsDto cartDetailsDto)
        {
            try
            {
                bool isSuccess = await _cartRepository.UpdateCartDetails(cartDetailsDto);
                _response.IsSuccess = isSuccess;
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost("RemoveCart")]
        public async Task<object> RemoveCart([FromBody] int cartId)
        {
            try
            {
                bool isSuccess = await _cartRepository.RemoveFromCart(cartId);
                if (!isSuccess)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "Failed to remove from cart" };
                    return _response;
                }
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost("ClearCart")]
        public async Task<object> ClearCart([FromBody] string userId)
        {
            try
            {
                bool isSuccess = await _cartRepository.ClearCart(userId);
                if (!isSuccess)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "Failed to clear cart" };
                    return _response;
                }
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost("ApplyCoupon")]
        public async Task<object> ApplyCoupon([FromBody] CartDto cartDto)
        {
            try
            {
                CouponDto coupon = await _couponRepository.GetCoupon(cartDto.CartHeader.CouponCode);

                if (coupon == null)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages = new List<string>() { "Coupon is null" };
                    return _response;
                }

                bool isSuccess = await _cartRepository.ApplyCoupon(cartDto.CartHeader.UserId,
                    cartDto.CartHeader.CouponCode);
                
                _response.Result = isSuccess ? cartDto.CartHeader.CouponCode: false;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost("RemoveCoupon")]
        public async Task<object> RemoveCoupon([FromBody] string userId)
        {
            try
            {
                bool isSuccess = await _cartRepository.RemoveCoupon(userId);
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }




        [HttpPost("Checkout2")]
        public async Task<object> Checkout2(CartDto cartDto)
        {
            try
            {


                if (!string.IsNullOrEmpty(cartDto.CartHeader.CouponCode))
                {
                    CouponDto coupon = await _couponRepository.GetCoupon(cartDto.CartHeader.CouponCode);

                }

                await _cartRepository.ClearCart(cartDto.CartHeader.UserId);
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
