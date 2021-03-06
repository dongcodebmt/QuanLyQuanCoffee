namespace QuanLyQuanCaffe.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhap")]
    public partial class PhieuNhap
    {
        [Key]
        public int ma { get; set; }

        public DateTime ngayNhap { get; set; }

        public int maKho { get; set; }

        public int soLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal giaDauVao { get; set; }

        public virtual Kho Kho { get; set; }
    }
}
