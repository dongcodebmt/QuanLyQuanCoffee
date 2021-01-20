namespace QuanLyQuanCaffe.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaCungCap()
        {
            ThongTinPhieuNhaps = new HashSet<ThongTinPhieuNhap>();
        }

        [Key]
        public int ma { get; set; }

        [Required]
        [StringLength(255)]
        public string ten { get; set; }

        [Required]
        [StringLength(255)]
        public string diaChi { get; set; }

        [Required]
        [StringLength(255)]
        public string SDT { get; set; }

        [Required]
        [StringLength(255)]
        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinPhieuNhap> ThongTinPhieuNhaps { get; set; }
    }
}
