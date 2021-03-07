using MovieStore.Data;
using MovieStore.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Repository
{
    public class WishListRepository : IWishListRepository
    {
        private readonly DataContext _context;

        public WishListRepository(DataContext context)
        {
            _context = context;
        }
    }
}
