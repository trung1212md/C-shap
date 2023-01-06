using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace luyen_tap_thi_1.Models
{
    public partial class QLBANHANGContext : DbContext
    {
        public QLBANHANGContext()
        {
        }

        public QLBANHANGContext(DbContextOptions<QLBANHANGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSanPham1> LoaiSanPham1s { get; set; }
        public virtual DbSet<Loaisanpham> Loaisanphams { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<SanPham2> SanPham2s { get; set; }
        public virtual DbSet<Sanpham> Sanphams { get; set; }
        public virtual DbSet<Sanpham1> Sanpham1s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=HoangCongTrung\\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK__HoaDon__2725A6E013A24245");

                entity.ToTable("HoaDon");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaHD")
                    .IsFixedLength(true);

                entity.Property(e => e.MaKh)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaKH")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayLap).HasColumnType("date");

                entity.Property(e => e.NguoiLap)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__HoaDon__MaKH__5629CD9C");

                entity.HasOne(d => d.NguoiLapNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.NguoiLap)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__HoaDon__NguoiLap__571DF1D5");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.MaHd, e.MaSp })
                    .HasName("PK__HoaDonCh__F557F661D15F7DAC");

                entity.ToTable("HoaDonChiTiet");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaHD")
                    .IsFixedLength(true);

                entity.Property(e => e.MaSp)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaHd)
                    .HasConstraintName("FK__HoaDonChiT__MaHD__5FB337D6");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaSp)
                    .HasConstraintName("FK__HoaDonChiT__MaSP__60A75C0F");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1E919A9A78");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaKH")
                    .IsFixedLength(true);

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.SoDt)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SoDT");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<LoaiSanPham1>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__LoaiSanP__730A5759F1977F0A");

                entity.ToTable("LoaiSanPham1");

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Loaisanpham>(entity =>
            {
                entity.HasKey(e => e.Maloai)
                    .HasName("PK__LOAISANP__2F633F23E4FD3B30");

                entity.ToTable("LOAISANPHAM");

                entity.Property(e => e.Maloai)
                    .HasMaxLength(10)
                    .HasColumnName("MALOAI");

                entity.Property(e => e.Tenloai)
                    .HasMaxLength(10)
                    .HasColumnName("TENLOAI");
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.TenDangNhap)
                    .HasName("PK__NguoiDun__55F68FC17AA97A73");

                entity.ToTable("NguoiDung");

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SanPham2>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__SanPham2__2725081C2B123275");

                entity.ToTable("SanPham2");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength(true);

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenSp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.SanPham2s)
                    .HasForeignKey(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__SanPham2__MaLoai__5CD6CB2B");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.Masp)
                    .HasName("PK__SANPHAM__60228A326851253C");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.Masp)
                    .HasMaxLength(10)
                    .HasColumnName("MASP");

                entity.Property(e => e.Dongia).HasColumnName("DONGIA");

                entity.Property(e => e.Maloai)
                    .HasMaxLength(10)
                    .HasColumnName("MALOAI");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tensanpham)
                    .HasMaxLength(10)
                    .HasColumnName("TENSANPHAM");

                entity.HasOne(d => d.MaloaiNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.Maloai)
                    .HasConstraintName("FK__SANPHAM__MALOAI__4BAC3F29");
            });

            modelBuilder.Entity<Sanpham1>(entity =>
            {
                entity.HasKey(e => e.Masp)
                    .HasName("PK__SANPHAM1__60228A32B5EC9292");

                entity.ToTable("SANPHAM1");

                entity.Property(e => e.Masp)
                    .HasMaxLength(20)
                    .HasColumnName("MASP");

                entity.Property(e => e.Dongia).HasColumnName("DONGIA");

                entity.Property(e => e.Maloai)
                    .HasMaxLength(10)
                    .HasColumnName("MALOAI");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tensanpham)
                    .HasMaxLength(20)
                    .HasColumnName("TENSANPHAM");

                entity.HasOne(d => d.MaloaiNavigation)
                    .WithMany(p => p.Sanpham1s)
                    .HasForeignKey(d => d.Maloai)
                    .HasConstraintName("FK__SANPHAM1__MALOAI__4F7CD00D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
