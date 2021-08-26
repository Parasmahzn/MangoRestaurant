using Mango.Services.ShoppingCartApi.Model.Dto;
using Mango.Services.ShoppingCartApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.ShoppingCartApi.Controllers
{
    [ApiController]
    [Route("api/cart")]
    public class CartController : Controller
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        protected ResponseDto _response;
        public CartController(IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            this._response = new ResponseDto();
        }
        [HttpGet("GetCart/{userId}")]
        public async Task<object> GetCart(string userId)
        {
            try
            {
                CartDto cartDto = await _shoppingCartRepository.GetCartByUserId(userId);
                _response.Result = cartDto;
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorsMessages = new List<string>() {
                 ex.ToString()
                };
            }
            return _response;
        }

        [HttpPost("AddCart")]
        public async Task<object> AddCart(CartDto cartDto)
        {
            try
            {
                CartDto cartDt = await _shoppingCartRepository.CreateUpdateCart(cartDto);
                _response.Result = cartDt;
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorsMessages = new List<string>() {
                 ex.ToString()
                };
            }
            return _response;
        }

        [HttpPost("UpdateCart")]
        public async Task<object> UpdateCart([FromBody] CartDto cartDto)
        {
            try
            {
                CartDto cartDt = await _shoppingCartRepository.CreateUpdateCart(cartDto);
                _response.Result = cartDt;
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorsMessages = new List<string>() {
                 ex.ToString()
                };
            }
            return _response;
        }

        [HttpPost("RemoveCart")]
        public async Task<object> RemoveCart([FromBody] int cartId)
        {
            try
            {
                bool isSuccess = await _shoppingCartRepository.RemoveFromCart(cartId);
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorsMessages = new List<string>() {
                 ex.ToString()
                };
            }
            return _response;
        }

        [HttpPost("ClearCart")]
        public async Task<object> ClearCart([FromBody] string userId)
        {
            try
            {
                bool isSuccess = await _shoppingCartRepository.ClearCart(userId);
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorsMessages = new List<string>() {
                 ex.ToString()
                };
            }
            return _response;
        }

    }
}
