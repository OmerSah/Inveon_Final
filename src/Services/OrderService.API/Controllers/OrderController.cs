using Microsoft.AspNetCore.Mvc;
using OrderService.API.Repositories;
using OrderService.API.Dtos;
using OrderService.API.Models;
using Microsoft.AspNetCore.Authorization;

namespace OrderService.API.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController
    {
        private readonly IOrderRepository _orderRepository;
        protected ResponseDto _response;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
            this._response = new ResponseDto();
        }

        [HttpGet("{userId}")]
        [Authorize]
        public async Task<object> GetOrdersByUserId(string userId)
        {
            try
            {
                List<OrderHeader> orderHeaders = await _orderRepository.GetAllOrders(userId);
                _response.Result = orderHeaders;
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
