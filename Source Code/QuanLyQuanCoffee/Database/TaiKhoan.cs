namespace QuanLyQuanCaffe.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            PhanQuens = new HashSet<PhanQuen>();
        }

        [Key]
        public int ma { get; set; }

        [Required]
        [StringLength(255)]
        public string tenDangNhap { get; set; }

        [Required]
        [StringLength(255)]
        public string tenHienThi { get; set; }

        [Required]
        [StringLength(255)]
        public string matKhau { get; set; }

        public int trangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanQuen> PhanQuens { get; set; }
    }
}
