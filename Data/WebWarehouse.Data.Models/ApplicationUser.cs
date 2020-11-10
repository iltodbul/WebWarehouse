// ReSharper disable VirtualMemberCallInConstructor

using System.ComponentModel.DataAnnotations;

namespace WebWarehouse.Data.Models
{
    using System;
    using System.Collections.Generic;

    using WebWarehouse.Data.Common.Models;

    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
        }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        // Added for me
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string CountryId { get; set; }

        public virtual Country Country { get; set; }

        [Required]
        public string CityId { get; set; }

        public virtual City City { get; set; }

        public ICollection<Delivery> Deliveries { get; set; } = new HashSet<Delivery>();

        public ICollection<Sale> Sales { get; set; } = new HashSet<Sale>();

        public ICollection<Transfer> Transfers { get; set; } = new HashSet<Transfer>();
    }
}
