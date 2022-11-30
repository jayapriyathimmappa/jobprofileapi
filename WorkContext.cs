using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace jprofile.Models;

public partial class WorkContext : DbContext
{
    public WorkContext()
    {
    }

    public WorkContext(DbContextOptions<WorkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<JobProfile> JobProfiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    
}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JobProfile>(entity =>
        {
            entity.HasKey(e => e.CandidateId).HasName("PK__job_prof__39B05050E7DE8B95");

            entity.ToTable("job_profiles");

            entity.Property(e => e.CandidateId).HasColumnName("candidate_Id");
            entity.Property(e => e.CandidateName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("candidate_name");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.Experience)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("experience");
            entity.Property(e => e.ProfileAbout)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("profile_about");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
