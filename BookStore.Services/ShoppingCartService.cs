using MovieStore.Repository.interfaces;
using MovieStore.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IMovieRepository _movieRepository;

        public ShoppingCartService(
            IShoppingCartRepository shoppingCartRepository,
            IMovieRepository movieRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _movieRepository = movieRepository;
        }
    }
}
