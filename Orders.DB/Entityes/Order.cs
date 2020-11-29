using System;
using System.ComponentModel.DataAnnotations;

namespace Orders.DB
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Number { get; set; }
        
        [Required]
        public double Weight { get; set; }

        public Person PersonFrom { get; set; }
        
        public Person PersonTo { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
