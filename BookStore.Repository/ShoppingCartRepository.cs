using MovieStore.Data;
using MovieStore.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Repository
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly DataContext _context;

        public ShoppingCartRepository(DataContext context)
        {
            _context = context;
        }
    }
}
