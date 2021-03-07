using MovieStore.Data;
using MovieStore.Entities;
using MovieStore.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStore.Repository
{
    public class ProducerRepository : IProducerRepository
    {
        private readonly DataContext _context;

        public ProducerRepository(DataContext context)
        {
            _context = context;
        }

        public void AddProducer(Producer producer)
        {
            _context.Producers.Add(producer);
            _context.SaveChanges();
        }

        public void DeleteProducer(int producerId)
        {
            Producer producer = GetProducerById(producerId);
            _context.Producers.Remove(producer);
            _context.SaveChanges();
        }

        public void EditProducer(Producer producer)
        {
            _context.Producers.Update(producer);
            _context.SaveChanges();
        }

        public IEnumerable<Producer> GetAllProducers()
        {
            var result = _context.Producers.AsEnumerable();
            return result;
        }

        public Producer GetProducerById(int id)
        {
            var result = _context.Producers.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
