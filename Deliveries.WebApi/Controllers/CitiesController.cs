using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deliveries.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orders.Core;
using Orders.Presentation;

namespace Orders.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitiesController : ControllerBase
    {

        private readonly ILogger<OrdersController> _logger;
        private DataManager _dataManager;
        private ServicesManager _servicesManager;

        public CitiesController(ILogger<OrdersController> logger, DataManager dataManager)
        {
            _logger = logger;
            _dataManager = dataManager;
            _servicesManager = new ServicesManager(dataManager);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_servicesManager.Cities.GetCityList());
        }

    }
}
