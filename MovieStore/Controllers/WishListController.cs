﻿using Microsoft.AspNetCore.Mvc;
using MovieStore.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Controllers
{
    public class WishListController : Controller
    {
        private readonly IWishListService _wishListService;

        public WishListController(IWishListService wishListService)
        {
            _wishListService = wishListService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
