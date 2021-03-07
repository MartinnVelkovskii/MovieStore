using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services.interfaces
{
    public interface IProducerService
    {
        void Add(Producer producer);
        void Edit(Producer producer);
        void Delete(int producerId);

        Producer GetProducerById(int id);
        IEnumerable<Producer> GetAllProducers();
    }
}
