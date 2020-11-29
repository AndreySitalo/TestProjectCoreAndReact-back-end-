using Orders.Core.Interfaces;
using Orders.DB;
using Orders.DB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orders.Core.Implementations
{
    public class EFCitiesRepository : ICitiesRepository
    {
        private readonly EFDBContext _context;
        public EFCitiesRepository(EFDBContext context)
        {
            _context = context;
        }
        public IEnumerable<City> GetAllCities()
        {
            return _context.Cities;
        }

        public City GetCitiesById(int cityId)
        {
            return _context.Cities.FirstOrDefault(x => x.Id == cityId);
        }
    }
}
