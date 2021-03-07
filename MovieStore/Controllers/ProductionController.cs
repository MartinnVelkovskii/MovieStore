using Microsoft.AspNetCore.Mvc;
using MovieStore.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Controllers
{
    public class ProductionController : Controller
    {
        private readonly IProductionService _productionService;

        public ProductionController(IProductionService productionService)
        {
            _productionService = productionService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
