using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using FishDemo.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FishDemo.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet <CustomerModel> Customers{ get; set; }
        public DbSet <RideModel> Rides{ get; set; }
        public DbSet <AdmModel> Adms{ get; set; }
        public DbSet <SchedulerModel> Schedulers{ get; set; }
        public DbSet <DriverModel> Drivers{ get; set; }
       
        public object CustomerViewModel { get; internal set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          *//*  // Configure Student & StudentAddress entity
            modelBuilder.Entity<CustomerModel>()
                        .HasOptional(s => s.ride) // Mark Address property optional in Student entity
                        .WithRequired(ad => ad.Customer); // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student*//*
        }*/

    }
    
}