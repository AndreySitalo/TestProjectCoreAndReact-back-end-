using Orders.Core.Interfaces;
using System;

namespace Orders.Core
{
    public class DataManager
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly ICitiesRepository _citiesRepository;

        public DataManager(IOrdersRepository ordersRepository, ICitiesRepository citiesRepository)
        {
            _ordersRepository = ordersRepository;
            _citiesRepository = citiesRepository;
        }
        public IOrdersRepository Orders { get { return _ordersRepository; } }
        public ICitiesRepository Cities { get { return _citiesRepository; } }
    }
}
