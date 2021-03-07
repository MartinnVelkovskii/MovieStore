using Microsoft.AspNetCore.Mvc;
using MovieStore.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
