namespace WebWarehouse.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class City
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
