namespace QuanLyQuanCaffe.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhapNN")]
    public partial class PhieuNhapNN
    {
        [Key]
        public int ma { get; set; }

        public DateTime ngayNhap { get; set; }

        public int maNguyenLieu { get; set; }

        public double soLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal giaDauVao { get; set; }

        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}
