
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orders.Core;
using Orders.Presentation;
using Orders.Presentation.Models;

namespace Deliveries.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {


        private readonly ILogger<OrdersController> _logger;
        private DataManager _dataManager;
        private ServicesManager _servicesManager;

        public OrdersController(ILogger<OrdersController> logger,DataManager dataManager)
        {
            _logger = logger;
            _dataManager = dataManager;
            _servicesManager = new ServicesManager(dataManager);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_servicesManager.Orders.GetOrdersList());
        }

        [HttpPost]
        public IActionResult SaveOrder(OrderViewModel model)
        {
            return Ok(_servicesManager.Orders.SaveOrderViewModelToDB(model));
        }
    }
}
