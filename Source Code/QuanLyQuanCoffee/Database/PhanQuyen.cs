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
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maTaiKhoan { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maPhanQuyen { get; set; }

        public virtual Quyen Quyen { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
