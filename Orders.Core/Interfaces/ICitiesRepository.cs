using Orders.DB.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Core.Interfaces
{
    public interface ICitiesRepository
    {
        IEnumerable<City> GetAllCities();
        City GetCitiesById(int cityId);
    }
}
