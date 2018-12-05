namespace CST324_TermProject_RideShare.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RideRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RideRequest()
        {
            Drivers = new HashSet<Driver>();
            Riders = new HashSet<Rider>();
        }

        public int RideRequestID { get; set; }

        [Column("CreditCard#")]
        public int? CreditCard_ { get; set; }

        [Required]
        [StringLength(255)]
        public string Destination { get; set; }

        public TimeSpan? Rider_Desired_Time { get; set; }

        public TimeSpan? Driver_ETA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Driver> Drivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rider> Riders { get; set; }
    }
}
