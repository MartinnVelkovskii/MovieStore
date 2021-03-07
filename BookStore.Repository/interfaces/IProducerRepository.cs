using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Repository.interfaces
{
    public interface IProducerRepository
    {
        void AddProducer(Producer producer);
        void EditProducer(Producer producer);
        void DeleteProducer(int producerId);

        Producer GetProducerById(int id);
        IEnumerable<Producer> GetAllProducers();
    }
}
