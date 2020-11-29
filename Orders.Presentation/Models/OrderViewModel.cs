using Orders.DB.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Presentation.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int CityFromId { get; set; }
        public string AddressFrom { get; set; }
        public int CityToId { get; set; }
        public string AddressTo { get; set; }
        public double Weight { get; set; }
        public DateTime Date { get; set; }

    }
}
