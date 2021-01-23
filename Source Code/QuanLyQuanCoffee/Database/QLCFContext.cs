using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyQuanCaffe.Database
{
    public partial class QLCFContext : DbContext
    {
        public QLCFContext()
            : base("name=QLCFContext")
        {
        }

        public virtual DbSet<Ban> Ban { get; set; }
        public virtual DbSet<CongThuc> CongThuc { get; set; }
        public virtual DbSet<CTHD> CTHD { get; set; }
        public virtual DbSet<DonVi> DonVi { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<Kho> Kho { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMai { get; set; }
        public virtual DbSet<LoaiMonAn> LoaiMonAn { get; set; }
        public virtual DbSet<MonAn> MonAn { get; set; }
        public virtual DbSet<NguyenLieu> NguyenLieu { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyen { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhap { get; set; }
        public virtual DbSet<PhieuNhapNN> PhieuNhapNN { get; set; }
        public virtual DbSet<Quyen> Quyen { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .HasMany(e => e.HoaDon)
                .WithRequired(e => e.Ban)
                .HasForeignKey(e => e.maBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonVi>()
                .HasMany(e => e.MonAn)
                .WithRequired(e => e.DonVi)
                .HasForeignKey(e => e.maDonVi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CTHD)
                .WithRequired(e => e.HoaDon)
                .HasForeignKey(e => e.maHoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kho>()
                .HasMany(e => e.PhieuNhap)
                .WithRequired(e => e.Kho)
                .HasForeignKey(e => e.maKho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhuyenMai>()
                .HasMany(e => e.HoaDon)
                .WithOptional(e => e.KhuyenMai)
                .HasForeignKey(e => e.maKhuyenMai);

            modelBuilder.Entity<LoaiMonAn>()
                .HasMany(e => e.MonAn)
                .WithRequired(e => e.LoaiMonAn)
                .HasForeignKey(e => e.maLoaiMonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAn>()
                .Property(e => e.gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MonAn>()
                .HasMany(e => e.CongThuc)
                .WithRequired(e => e.MonAn)
                .HasForeignKey(e => e.maMon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAn>()
                .HasMany(e => e.CTHD)
                .WithRequired(e => e.MonAn)
                .HasForeignKey(e => e.maMonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAn>()
                .HasOptional(e => e.Kho)
                .WithRequired(e => e.MonAn);

            modelBuilder.Entity<NguyenLieu>()
                .HasMany(e => e.CongThuc)
                .WithRequired(e => e.NguyenLieu)
                .HasForeignKey(e => e.maNguyenLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguyenLieu>()
                .HasMany(e => e.PhieuNhapNN)
                .WithRequired(e => e.NguyenLieu)
                .HasForeignKey(e => e.maNguyenLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.giaDauVao)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PhieuNhapNN>()
                .Property(e => e.giaDauVao)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Quyen>()
                .HasMany(e => e.PhanQuyen)
                .WithRequired(e => e.Quyen)
                .HasForeignKey(e => e.maPhanQuyen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.HoaDon)
                .WithRequired(e => e.TaiKhoan)
                .HasForeignKey(e => e.maNhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.PhanQuyen)
                .WithRequired(e => e.TaiKhoan)
                .HasForeignKey(e => e.maTaiKhoan)
                .WillCascadeOnDelete(false);
        }
    }
}
