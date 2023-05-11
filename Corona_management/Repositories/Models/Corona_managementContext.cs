using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Repositories.Models
{
    public partial class Corona_managementContext : DbContext
    {
        public Corona_managementContext()
        {
        }

        public Corona_managementContext(DbContextOptions<Corona_managementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CovidDetail> CovidDetails { get; set; } = null!;
        public virtual DbSet<PersonalDetail> PersonalDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\מטלת בית\\Corona_management\\DB\\Corona_management.mdf\";Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Hebrew_CI_AS");

            modelBuilder.Entity<CovidDetail>(entity =>
            {
                entity.ToTable("covid_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdNumber).HasColumnName("id_number");

                entity.Property(e => e.PositiveResultDate)
                    .HasColumnType("date")
                    .HasColumnName("positive_result_date");

                entity.Property(e => e.RecoveryDate)
                    .HasColumnType("date")
                    .HasColumnName("recovery_date");

                entity.Property(e => e.VaccineDate1)
                    .HasColumnType("date")
                    .HasColumnName("vaccine_date1");

                entity.Property(e => e.VaccineDate2)
                    .HasColumnType("date")
                    .HasColumnName("vaccine_date2");

                entity.Property(e => e.VaccineDate3)
                    .HasColumnType("date")
                    .HasColumnName("vaccine_date3");

                entity.Property(e => e.VaccineDate4)
                    .HasColumnType("date")
                    .HasColumnName("vaccine_date4");

                entity.Property(e => e.VaccineManufacturer1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vaccine_manufacturer1");

                entity.Property(e => e.VaccineManufacturer2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vaccine_manufacturer2");

                entity.Property(e => e.VaccineManufacturer3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vaccine_manufacturer3");

                entity.Property(e => e.VaccineManufacturer4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vaccine_manufacturer4");

                entity.HasOne(d => d.IdNumberNavigation)
                    .WithMany(p => p.CovidDetails)
                    .HasForeignKey(d => d.IdNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__covid_det__id_nu__38996AB5");
            });

            modelBuilder.Entity<PersonalDetail>(entity =>
            {
                entity.HasKey(e => e.IdNumber)
                    .HasName("PK__personal__D58CDE104A98E6E5");

                entity.ToTable("personal_details");

                entity.Property(e => e.IdNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("id_number");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mobile_number");

                entity.Property(e => e.NumberStreet).HasColumnName("number_street");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Street)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("street");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
