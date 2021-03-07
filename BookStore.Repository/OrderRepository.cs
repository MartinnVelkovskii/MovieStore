using MovieStore.Data;
using MovieStore.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }
    }
}
