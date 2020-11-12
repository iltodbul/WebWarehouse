namespace WebWarehouse.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using WebWarehouse.Data.Common.Models;

    public class Company : BaseDeletableModel<string>
    {
        public Company()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ManagerFullName { get; set; }

        public int EIK { get; set; }

        public string VatNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        [Required]
        public int CityId { get; set; }

        public virtual City City { get; set; }

        public string Logo { get; set; }
    }
}
