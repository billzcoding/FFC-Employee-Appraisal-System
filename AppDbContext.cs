using Microsoft.EntityFrameworkCore;
using AppraisalAppV1.Models;

namespace AppraisalAppV1.Data
{
    public class AppraisalContext : DbContext
    {
        public AppraisalContext(DbContextOptions<AppraisalContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Appraisal> Appraisals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AppraisalAssignment> AppraisalAssignments { get; set; }
        public DbSet<ApprovalStatus> ApprovalStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appraisal>()
                .HasOne(a => a.Submitter)
                .WithMany()
                .HasForeignKey(a => a.SubmitterId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Appraisal>()
                .HasOne(a => a.Employee)
                .WithMany()
                .HasForeignKey(a => a.AppraiseeNumber)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Employee)
                .WithMany()
                .HasForeignKey(u => u.AppraiseeNumber)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}