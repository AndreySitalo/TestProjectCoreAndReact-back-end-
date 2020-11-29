using Orders.Core;
using Orders.DB.Entity;
using Orders.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Presentation.Services
{
   public  class CitiesService
    {
        private DataManager _dataManager;

        public CitiesService(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IEnumerable<CityViewModel> GetCityList()
        {
            var cities = _dataManager.Cities.GetAllCities();
            List<CityViewModel> cityViewModelList = new List<CityViewModel>();
            foreach (var city in cities)
            {
                cityViewModelList.Add(new CityViewModel() {City = new City (){Id=city.Id, Name=city.Name} });
            }
            return cityViewModelList;
        }
    }
}
