using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.ShoppingCartApi.Controllers
{
    [Route("api/shoppingcart")]
    public class ShoppingCartApi : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
