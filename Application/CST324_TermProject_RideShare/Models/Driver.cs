namespace CST324_TermProject_RideShare.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Driver")]
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            Users = new HashSet<User>();
        }

        [Required]
        [StringLength(55)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(8)]
        public string LicensePlate { get; set; }

        [Required]
        [StringLength(255)]
        public string VehicleType { get; set; }

        public int DriverID { get; set; }

        public int? RideRequests { get; set; }

        public virtual RideRequest RideRequest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
