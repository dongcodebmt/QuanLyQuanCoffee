namespace QuanLyQuanCaffe.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongThuc")]
    public partial class CongThuc
    {
        [Key]
        public int ma { get; set; }

        public int maMon { get; set; }

        public int maNguyenLieu { get; set; }

        public double chiPhi { get; set; }

        public virtual MonAn MonAn { get; set; }

        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}
