namespace WebWarehouse.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using WebWarehouse.Data.Common.Models;

    public class Country : BaseDeletableModel<int>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
