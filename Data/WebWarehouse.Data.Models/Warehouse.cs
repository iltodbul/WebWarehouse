using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebWarehouse.Data.Models
{
    public class Warehouse
    {
        public int Id { get; set; }

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

        public ICollection<Good> Goods { get; set; }

        public ICollection<Sale> Sales { get; set; }

        public ICollection<Delivery> Deliveries { get; set; }

        public ICollection<Transfer> Transfers { get; set; }
    }
}
