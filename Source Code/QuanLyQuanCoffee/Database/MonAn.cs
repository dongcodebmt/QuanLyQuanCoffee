namespace QuanLyQuanCaffe.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonAn")]
    public partial class MonAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonAn()
        {
            CongThuc = new HashSet<CongThuc>();
            CTHD = new HashSet<CTHD>();
        }

        [Key]
        public int ma { get; set; }

        [Required]
        [StringLength(255)]
        public string ten { get; set; }

        public int maLoaiMonAn { get; set; }

        [Column(TypeName = "money")]
        public decimal gia { get; set; }

        public int maDonVi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongThuc> CongThuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHD { get; set; }

        public virtual DonVi DonVi { get; set; }

        public virtual Kho Kho { get; set; }

        public virtual LoaiMonAn LoaiMonAn { get; set; }
    }
}
