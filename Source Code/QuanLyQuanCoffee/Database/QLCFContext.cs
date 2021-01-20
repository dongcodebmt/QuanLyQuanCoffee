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
        public virtual DbSet<CTHD> CTHD { get; set; }
        public virtual DbSet<DonVi> DonVi { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMai { get; set; }
        public virtual DbSet<LoaiMonAn> LoaiMonAn { get; set; }
        public virtual DbSet<MonAn> MonAn { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhap { get; set; }
        public virtual DbSet<Quyen> Quyen { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<ThongTinPhieuNhap> ThongTinPhieuNhap { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyen { get; set; }

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

            modelBuilder.Entity<KhuyenMai>()
                .HasMany(e => e.HoaDon)
                .WithRequired(e => e.KhuyenMai)
                .HasForeignKey(e => e.maKhuyenMai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiMonAn>()
                .HasMany(e => e.MonAn)
                .WithRequired(e => e.LoaiMonAn)
                .HasForeignKey(e => e.maLoaiMonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAn>()
                .Property(e => e.gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MonAn>()
                .HasMany(e => e.CTHD)
                .WithRequired(e => e.MonAn)
                .HasForeignKey(e => e.maMonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAn>()
                .HasMany(e => e.ThongTinPhieuNhap)
                .WithRequired(e => e.MonAn)
                .HasForeignKey(e => e.maMonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.ThongTinPhieuNhap)
                .WithRequired(e => e.NhaCungCap)
                .HasForeignKey(e => e.maNCC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhap>()
                .HasMany(e => e.ThongTinPhieuNhap)
                .WithRequired(e => e.PhieuNhap)
                .HasForeignKey(e => e.maPhieuNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quyen>()
                .HasMany(e => e.PhanQuyen)
                .WithRequired(e => e.Quyen)
                .HasForeignKey(e => e.maPhanQuyen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.PhanQuyen)
                .WithRequired(e => e.TaiKhoan)
                .HasForeignKey(e => e.maTaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThongTinPhieuNhap>()
                .Property(e => e.giaDauVao)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThongTinPhieuNhap>()
                .Property(e => e.giaDauRa)
                .HasPrecision(19, 4);
        }
    }
}
