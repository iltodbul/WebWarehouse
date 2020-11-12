namespace WebWarehouse.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using WebWarehouse.Data.Common.Models;

    public class Partner : BaseDeletableModel<string>
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

        public int EIK { get; set; }

        public string VatNumber { get; set; }

        [Required]
        public string Address { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }

        public string Logo { get; set; }

        public bool IsClient { get; set; }

        public bool IsProvider { get; set; }

        public virtual ICollection<Delivery> Deliveries { get; set; } = new HashSet<Delivery>();

        public virtual ICollection<Sale> Sales { get; set; } = new HashSet<Sale>();
    }
}
