using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UMS_DAL.Models;

public partial class UniversityMsContext : DbContext
{
    public UniversityMsContext()
    {
    }

    public UniversityMsContext(DbContextOptions<UniversityMsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Building> Buildings { get; set; }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<Floor> Floors { get; set; }

    public virtual DbSet<Major> Majors { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-S8HUE7C\\SQLEXPRESS01;Database=UniversityMS;Trusted_Connection=True; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Building>(entity =>
        {
            entity.ToTable("Building");

            entity.Property(e => e.BuildingId).HasColumnName("Building_ID");
            entity.Property(e => e.BuildingName)
                .HasMaxLength(50)
                .HasColumnName("Building_Name");
        });

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.HasKey(e => e.FacultyId).HasName("PK_Fa");

            entity.ToTable("Faculty");

            entity.Property(e => e.FacultyId).HasColumnName("Faculty_ID");
            entity.Property(e => e.FacultyName)
                .HasMaxLength(50)
                .HasColumnName("Faculty_Name");
            entity.Property(e => e.FaultyDeanName)
                .HasMaxLength(50)
                .HasColumnName("Faulty_DeanName");
        });

        modelBuilder.Entity<Floor>(entity =>
        {
            entity.ToTable("Floor");

            entity.Property(e => e.FloorId).HasColumnName("Floor_ID");
            entity.Property(e => e.BuildingId).HasColumnName("Building_ID");
            entity.Property(e => e.FloorName)
                .HasMaxLength(50)
                .HasColumnName("Floor_Name");

            entity.HasOne(d => d.Building).WithMany(p => p.Floors)
                .HasForeignKey(d => d.BuildingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Floor_Building");
        });

        modelBuilder.Entity<Major>(entity =>
        {
            entity.ToTable("Major");

            entity.Property(e => e.MajorId).HasColumnName("Major_ID");
            entity.Property(e => e.FacultyId).HasColumnName("Faculty_ID");
            entity.Property(e => e.MajorName)
                .HasMaxLength(50)
                .HasColumnName("Major_Name");

            entity.HasOne(d => d.Faculty).WithMany(p => p.Majors)
                .HasForeignKey(d => d.FacultyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Major_Faculty");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.RoleId).HasColumnName("Role_ID");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("Role_Name");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.ToTable("Room");

            entity.Property(e => e.RoomId).HasColumnName("Room_ID");
            entity.Property(e => e.FloorId).HasColumnName("Floor_ID");
            entity.Property(e => e.RoomCapacity).HasColumnName("Room_Capacity");
            entity.Property(e => e.RoomName)
                .HasMaxLength(50)
                .HasColumnName("Room_Name");

            entity.HasOne(d => d.Floor).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.FloorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Room_Floor");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.Password).HasColumnName("PASSWORD");
            entity.Property(e => e.RoleId).HasColumnName("Role_ID");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("USERNAME");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
