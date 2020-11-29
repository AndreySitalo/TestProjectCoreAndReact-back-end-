using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Orders.DB.Entity
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
