using MovieStore.Repository.interfaces;
using MovieStore.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public class WishListService : IWishListService
    {
        private readonly IWishListRepository _wishListRepository;

        public WishListService(IWishListRepository wishListRepository)
        {
            _wishListRepository = wishListRepository;
        }
    }
}
