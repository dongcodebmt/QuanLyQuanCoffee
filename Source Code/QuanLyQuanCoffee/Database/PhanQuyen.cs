namespace QuanLyQuanCaffe.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanQuyen")]
    public partial class PhanQuyen
    {
        [Key]
        public int ma { get; set; }

        public int maTaiKhoan { get; set; }

        public int maPhanQuyen { get; set; }

        public virtual Quyen Quyen { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
