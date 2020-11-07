using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebWarehouse.Data.Models
{
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

        public bool IsClient { get; set; }

        public bool IsProvider { get; set; }
    }
}
