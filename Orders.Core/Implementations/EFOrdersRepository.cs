using Microsoft.EntityFrameworkCore;
using Orders.Core.Interfaces;
using Orders.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orders.Core.Implementations
{
    public class EFOrdersRepository : IOrdersRepository
    {
        private EFDBContext _context;
        public EFOrdersRepository(EFDBContext context) 
        {
            _context = context;
        }
        public void DeleteOrder(Order order)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders
                .Include(x=>x.PersonFrom)
                .ThenInclude(c=>c.City)
                .Include(x=>x.PersonTo)
                .ThenInclude(c => c.City)
                .AsNoTracking();
        }

        public Order CreateOrder(Order order)
        {
            if (order.Id == 0)
                _context.Orders.Add(order);
            else
                _context.Entry(order).State = EntityState.Modified;
            _context.SaveChanges();

            return order;
        }
    }
}
