namespace WebWarehouse.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Partner
    {
        public Partner()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
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

        [Required]
        public bool IsClient { get; set; }

        [Required]
        public bool IsProvider { get; set; }

        public virtual ICollection<Delivery> Deliveries { get; set; } = new HashSet<Delivery>();

        public virtual ICollection<Sale> Sales { get; set; } = new HashSet<Sale>();
    }
}
