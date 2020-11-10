using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebWarehouse.Data.Models
{
    public class Warehouse
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

        [Required]
        public string CountryId { get; set; }

        public virtual Country Country { get; set; }

        [Required]
        public string CityId { get; set; }

        public virtual City City { get; set; }

        [Required]
        public string CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public ICollection<ApplicationUser> Users { get; set; } = new HashSet<ApplicationUser>();

        public ICollection<Partner> Partners { get; set; } = new HashSet<Partner>();

        public ICollection<Good> Goods { get; set; } = new HashSet<Good>();

        public ICollection<Sale> Sales { get; set; } = new HashSet<Sale>();

        public ICollection<Delivery> Deliveries { get; set; } = new HashSet<Delivery>();

        public ICollection<Transfer> Transfers { get; set; } = new HashSet<Transfer>();
    }
}
