namespace WebWarehouse.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Measure
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(10)]
        public string Name { get; set; }
    }
}
