using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NvtLesson10EFDb.Models;

public partial class NvtK24cntt1lesson10EfdbContext : DbContext
{
    public NvtK24cntt1lesson10EfdbContext()
    {
    }

    public NvtK24cntt1lesson10EfdbContext(DbContextOptions<NvtK24cntt1lesson10EfdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NvtMember> NvtMembers { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS01;Database=NvtK24CNTT1Lesson10EFDb;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NvtMember>(entity =>
        {
            entity.ToTable("NvtMember");

            entity.Property(e => e.NvtEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NvtFullName).HasMaxLength(50);
            entity.Property(e => e.NvtPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NvtPhone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NvtUseName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
