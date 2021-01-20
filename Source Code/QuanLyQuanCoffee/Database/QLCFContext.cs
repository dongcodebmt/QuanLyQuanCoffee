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

        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<DonVi> DonVis { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<LoaiMonAn> LoaiMonAns { get; set; }
        public virtual DbSet<MonAn> MonAns { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<PhanQuen> PhanQuens { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThongTinPhieuNhap> ThongTinPhieuNhaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.Ban)
                .HasForeignKey(e => e.maBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonVi>()
                .HasMany(e => e.MonAns)
                .WithRequired(e => e.DonVi)
                .HasForeignKey(e => e.maDonVi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.HoaDon)
                .HasForeignKey(e => e.maHoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhuyenMai>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.KhuyenMai)
                .HasForeignKey(e => e.maKhuyenMai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiMonAn>()
                .HasMany(e => e.MonAns)
                .WithRequired(e => e.LoaiMonAn)
                .HasForeignKey(e => e.maLoaiMonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAn>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.MonAn)
                .HasForeignKey(e => e.maMonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAn>()
                .HasMany(e => e.ThongTinPhieuNhaps)
                .WithRequired(e => e.MonAn)
                .HasForeignKey(e => e.maMonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.ThongTinPhieuNhaps)
                .WithRequired(e => e.NhaCungCap)
                .HasForeignKey(e => e.maNCC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhanQuen>()
                .HasMany(e => e.TaiKhoans)
                .WithMany(e => e.PhanQuens)
                .Map(m => m.ToTable("QuyenTaiKhoan").MapLeftKey("maPhanQuyen").MapRightKey("maTaiKhoan"));

            modelBuilder.Entity<PhieuNhap>()
                .HasMany(e => e.ThongTinPhieuNhaps)
                .WithRequired(e => e.PhieuNhap)
                .HasForeignKey(e => e.maPhieuNhap)
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
