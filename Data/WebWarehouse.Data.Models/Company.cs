namespace WebWarehouse.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Company
    {
        public Company()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MinLength(10)]
        public string ManagerFullName { get; set; }

        [Range(9, 9)]
        public int EIK { get; set; }

        public string VatNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string CountryId { get; set; }

        public virtual Country Country { get; set; }

        [Required]
        public string CityId { get; set; }

        public virtual City City { get; set; }

        public string Logo { get; set; }
    }
}
