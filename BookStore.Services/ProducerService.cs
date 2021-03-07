using MovieStore.Entities;
using MovieStore.Repository.interfaces;
using MovieStore.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public class ProducerService : IProducerService
    {
        private readonly IProducerRepository _producerRepository;

        public ProducerService(IProducerRepository producerRepository)
        {
            _producerRepository = producerRepository;
        }

        public void Add(Producer producer)
        {
            _producerRepository.AddProducer(producer);
        }

        public void Delete(int producerId)
        {
            _producerRepository.DeleteProducer(producerId);
        }

        public void Edit(Producer producer)
        {
            _producerRepository.EditProducer(producer);
        }

        public IEnumerable<Producer> GetAllProducers()
        {
            var result = _producerRepository.GetAllProducers();
            return result;
        }

        public Producer GetProducerById(int id)
        {
            var result = _producerRepository.GetProducerById(id);
            return result;
        }
    }
}
