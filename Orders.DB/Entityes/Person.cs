using Orders.DB.Entity;
using System.ComponentModel.DataAnnotations;

namespace Orders.DB
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public City City { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
