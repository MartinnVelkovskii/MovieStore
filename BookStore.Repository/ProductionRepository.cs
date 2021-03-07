using MovieStore.Data;
using MovieStore.Entities;
using MovieStore.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStore.Repository
{
    public class ProductionRepository : IProductionRepository
    {
        private readonly DataContext _context;

        public ProductionRepository(DataContext context)
        {
            _context = context;
        }

        public void AddProduction(Production production)
        {
            _context.Productions.Add(production);
            _context.SaveChanges();
        }

        public void DeleteProduction(int productionId)
        {
            Production production = GetProductionById(productionId);
            _context.Productions.Remove(production);
            _context.SaveChanges();
        }

        public void EditProduction(Production production)
        {
            _context.Productions.Update(production);
            _context.Update(production);
        }

        public IEnumerable<Production> GetAllProductions()
        {
            var result = _context.Productions.AsEnumerable();
            return result;
        }

        public Production GetProductionById(int id)
        {
            var result = _context.Productions.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
