namespace CST324_TermProject_RideShare.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Required]
        [StringLength(255)]
        public string Location { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Admin { get; set; }

        public int? RiderID { get; set; }

        public int? DriverID { get; set; }

        public virtual Driver Driver { get; set; }

        public virtual Rider Rider { get; set; }
    }
}
