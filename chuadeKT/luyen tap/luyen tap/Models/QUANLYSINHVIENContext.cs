using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace luyen_tap.Models
{
    public partial class QUANLYSINHVIENContext : DbContext
    {
        public QUANLYSINHVIENContext()
        {
        }

        public QUANLYSINHVIENContext(DbContextOptions<QUANLYSINHVIENContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblTaiLieu> TblTaiLieus { get; set; }
        public virtual DbSet<TblTheLoai1> TblTheLoai1s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=HoangCongTrung\\SQLEXPRESS;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblTaiLieu>(entity =>
            {
                entity.HasKey(e => e.MaTaiLieu)
                    .HasName("PK__tblTaiLi__FD18A657205CC188");

                entity.ToTable("tblTaiLieu");

                entity.Property(e => e.MaTaiLieu).HasMaxLength(30);

                entity.Property(e => e.MaTheLoai).HasMaxLength(30);

                entity.Property(e => e.TacGia).HasMaxLength(30);

                entity.Property(e => e.TenTaiLieu).HasMaxLength(30);

                entity.HasOne(d => d.MaTheLoaiNavigation)
                    .WithMany(p => p.TblTaiLieus)
                    .HasForeignKey(d => d.MaTheLoai)
                    .HasConstraintName("FK__tblTaiLie__MaThe__6A30C649");
            });

            modelBuilder.Entity<TblTheLoai1>(entity =>
            {
                entity.HasKey(e => e.MaTheLoai)
                    .HasName("PK__tblTheLo__D73FF34A740C8877");

                entity.ToTable("tblTheLoai1");

                entity.Property(e => e.MaTheLoai).HasMaxLength(30);

                entity.Property(e => e.TenTheLoai).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
