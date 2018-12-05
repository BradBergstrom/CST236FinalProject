namespace CST324_TermProject_RideShare.Properties
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OIT_RideShare : DbContext
    {
        public OIT_RideShare()
            : base("name=OIT_RideShare")
        {
        }

        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Rider> Riders { get; set; }
        public virtual DbSet<RideRequest> RideRequests { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rider>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Rider)
                .WillCascadeOnDelete();

            modelBuilder.Entity<RideRequest>()
                .HasMany(e => e.Drivers)
                .WithOptional(e => e.RideRequest)
                .HasForeignKey(e => e.RideRequests)
                .WillCascadeOnDelete();

            modelBuilder.Entity<RideRequest>()
                .HasMany(e => e.Riders)
                .WithOptional(e => e.RideRequest1)
                .HasForeignKey(e => e.RideRequest)
                .WillCascadeOnDelete();
        }
    }
}
