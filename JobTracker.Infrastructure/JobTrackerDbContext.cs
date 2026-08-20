using Microsoft.EntityFrameworkCore;
using JobTracker.Domain;

namespace JobTracker.Infrastructure;

/// <summary>
/// Database context for JobTracker application.
/// </summary>
public class JobTrackerDbContext : DbContext
{
    public JobTrackerDbContext(DbContextOptions<JobTrackerDbContext> options)
        : base(options)
    {
    }

    public DbSet<JobApplication> JobApplications { get; set; } = null!;
    public DbSet<JobApplicationStatusHistory> JobApplicationStatusHistory { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure JobApplication entity
        modelBuilder.Entity<JobApplication>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Company).HasMaxLength(200);
            entity.Property(e => e.JobTitle).HasMaxLength(200);
            entity.Property(e => e.Location).HasMaxLength(200);
            entity.Property(e => e.SourceLink).HasMaxLength(500);
            entity.Property(e => e.SalaryRange).HasMaxLength(100);
            entity.Property(e => e.NextAction).HasMaxLength(500);
            entity.Property(e => e.Notes).HasMaxLength(1000);
            entity.Property(e => e.JobDescription).HasMaxLength(4000);
            entity.Property(e => e.CreatedAt).IsRequired();
            entity.Property(e => e.UpdatedAt).IsRequired();

            // Configure enums
            entity.Property(e => e.Source).HasConversion<string>();
            entity.Property(e => e.Status).HasConversion<string>();
        });

        // Configure JobApplicationStatusHistory entity
        modelBuilder.Entity<JobApplicationStatusHistory>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.JobApplicationId).IsRequired();
            entity.Property(e => e.PreviousStatus).HasConversion<string>();
            entity.Property(e => e.NewStatus).HasConversion<string>();
            entity.Property(e => e.ChangedAt).IsRequired();

            // Index for faster lookups by job application
            entity.HasIndex(e => e.JobApplicationId);
        });
    }
}