using Orders.Core;
using Orders.DB;
using Orders.DB.Entity;
using Orders.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orders.Presentation.Services
{
    public class OrdersService
    {
        private DataManager _dataManager;

        public OrdersService(DataManager dataManager) 
        {
            _dataManager = dataManager;
        }

        public List<OrderViewModel> GetOrdersList() 
        {
            var orders = _dataManager.Orders.GetAllOrders();
            List<OrderViewModel> orderViewModel=new List<OrderViewModel>();
            foreach (var order in orders)
            {
                orderViewModel.Add(GetOrderDBToViewModel(order));
            }
            return orderViewModel;
        }

        public OrderViewModel GetOrderDBToViewModel(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                Number = order.Number,
                AddressFrom = order.PersonFrom.Address,
                CityFromId = order.PersonFrom.City.Id,
                AddressTo = order.PersonTo.Address,
                CityToId = order.PersonTo.City.Id,
                Date = order.Date,
                Weight = order.Weight,
            };
        }
        

        public Order GetOrderViewModelToDB(OrderViewModel orderViewModel)
        {
            return new Order
            {
                Id= orderViewModel.Id,
                Number = GenerateNumberOrder(),
                PersonFrom=new Person() {Address=orderViewModel.AddressFrom,City=  _dataManager.Cities.GetCitiesById(orderViewModel.CityFromId) },
                PersonTo = new Person() { Address = orderViewModel.AddressTo, City= _dataManager.Cities.GetCitiesById(orderViewModel.CityToId) },
                Weight = orderViewModel.Weight,
                Date = orderViewModel.Date
            };
        }
        public string GenerateNumberOrder()
        {
            return Guid.NewGuid().ToString().Split('-').First();
        }

        public OrderViewModel SaveOrderViewModelToDB(OrderViewModel orderViewModel)
        {
            Order order = GetOrderViewModelToDB(orderViewModel);
            _dataManager.Orders.CreateOrder(order);

            return GetOrderDBToViewModel(order);
        }
    }
}
