using MovieStore.Entities;
using MovieStore.Repository.interfaces;
using MovieStore.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public class ProductionService : IProductionService
    {
        private readonly IProductionRepository _productionRepository;

        public ProductionService(IProductionRepository productionRepository)
        {
            _productionRepository = productionRepository;
        }

        public void Add(Production production)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productionId)
        {
            throw new NotImplementedException();
        }

        public void Edit(Production production)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Production> GetAllProductions()
        {
            throw new NotImplementedException();
        }

        public Production GetProductionById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
