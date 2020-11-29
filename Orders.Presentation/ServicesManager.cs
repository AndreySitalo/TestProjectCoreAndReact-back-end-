using Orders.Core;
using Orders.Presentation.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Presentation
{
    public class ServicesManager
    {
        DataManager _dataManager;
        private OrdersService _ordersServise;
        private CitiesService _citiesServise;

        public ServicesManager(DataManager dataManager) 
        {
            _dataManager = dataManager;
            _ordersServise = new OrdersService(dataManager);
            _citiesServise = new CitiesService(dataManager);
        }

        public OrdersService Orders { get { return _ordersServise; } }
        public CitiesService Cities { get { return _citiesServise; } }

    }
}
