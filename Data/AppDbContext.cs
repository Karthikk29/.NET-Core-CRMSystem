using CRMSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CRMSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Deal> Deals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Lead>()
                .HasOne(l => l.AssignedToUser)
                .WithMany()
                .HasForeignKey(l => l.AssignedToUserId)
                .OnDelete(DeleteBehavior.SetNull);

        
            modelBuilder.Entity<Contact>()
                .HasOne(c => c.Lead)
                .WithOne()
                .HasForeignKey<Contact>(c => c.LeadId)
                .OnDelete(DeleteBehavior.Cascade);

           
            modelBuilder.Entity<Contact>()
                .HasOne(c => c.Company)
                .WithMany(co => co.Contacts)
                .HasForeignKey(c => c.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            
            modelBuilder.Entity<Deal>()
                .HasOne(d => d.AssignedToUser)
                .WithMany()
                .HasForeignKey(d => d.AssignedToUserId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
