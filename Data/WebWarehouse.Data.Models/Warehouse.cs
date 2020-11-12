namespace WebWarehouse.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using WebWarehouse.Data.Common.Models;

    public class Warehouse : BaseDeletableModel<string>
    {
        public Warehouse()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }

        [Required]
        public string CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; } = new HashSet<ApplicationUser>();

        public virtual ICollection<Partner> Partners { get; set; } = new HashSet<Partner>();

        public virtual ICollection<Good> Goods { get; set; } = new HashSet<Good>();

        public virtual ICollection<Sale> Sales { get; set; } = new HashSet<Sale>();

        public virtual ICollection<Delivery> Deliveries { get; set; } = new HashSet<Delivery>();

        [InverseProperty(nameof(Transfer.InWarehouse))]
        public virtual ICollection<Transfer> InTransfers { get; set; } = new HashSet<Transfer>();

        [InverseProperty(nameof(Transfer.OutWarehouse))]
        public virtual ICollection<Transfer> OutTransfers { get; set; } = new HashSet<Transfer>();
    }
}
