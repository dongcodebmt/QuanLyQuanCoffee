namespace QuanLyQuanCaffe.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinPhieuNhap")]
    public partial class ThongTinPhieuNhap
    {
        [Key]
        public int ma { get; set; }

        public int maNCC { get; set; }

        public int maMonAn { get; set; }

        public int maPhieuNhap { get; set; }

        public int soLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal giaDauVao { get; set; }

        [Column(TypeName = "money")]
        public decimal giaDauRa { get; set; }

        public virtual MonAn MonAn { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
