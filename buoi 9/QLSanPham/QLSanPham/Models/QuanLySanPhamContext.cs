using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QLSanPham.Models;

public partial class QuanLySanPhamContext : DbContext
{
    public QuanLySanPhamContext()
    {
    }

    public QuanLySanPhamContext(DbContextOptions<QuanLySanPhamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Loai> Loais { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=HoangCongTrung\\SQLEXPRESS;Initial Catalog=SANPHAM;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Loai>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK__Loai__3213C8B7172A28CC");

            entity.ToTable("Loai");

            entity.Property(e => e.Ma).HasColumnName("ma");
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK__SanPham__3213C8B7122D3A10");

            entity.ToTable("SanPham");

            entity.Property(e => e.Ma).HasColumnName("ma");
            entity.Property(e => e.DonGia)
                .HasColumnType("money")
                .HasColumnName("donGia");
            entity.Property(e => e.MaLoai).HasColumnName("maLoai");
            entity.Property(e => e.SoLuong).HasColumnName("soLuong");
            entity.Property(e => e.Ten)
                .HasMaxLength(255)
                .HasColumnName("ten");

            entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaLoai)
                .HasConstraintName("FK__SanPham__maLoai__38996AB5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
