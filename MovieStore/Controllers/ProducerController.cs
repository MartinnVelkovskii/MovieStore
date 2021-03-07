using Microsoft.AspNetCore.Mvc;
using MovieStore.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IProducerService _producerService;

        public ProducerController(IProducerService producerService)
        {
            _producerService = producerService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
