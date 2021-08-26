using Mango.Services.ShoppingCartApi.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.ShoppingCartApi.Repository
{
    public interface IShoppingCartRepository
    {
        Task<CartDto> GetCartByUserId(string UserId);
        Task<CartDto> CreateUpdateCart(CartDto cartDto);

        Task<bool> RemoveFromCart(int cartDetailsId);
        Task<bool> ClearCart(string UserId); 
    }
}
