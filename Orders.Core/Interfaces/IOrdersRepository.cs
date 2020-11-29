using Orders.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Core.Interfaces
{
    public interface IOrdersRepository
    {
        IEnumerable<Order> GetAllOrders();
        Order CreateOrder(Order order);
        void DeleteOrder(Order order);
    }
}
