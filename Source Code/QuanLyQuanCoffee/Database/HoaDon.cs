namespace QuanLyQuanCaffe.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            CTHD = new HashSet<CTHD>();
        }

        [Key]
        public int ma { get; set; }

        public DateTime ngayVao { get; set; }

        public DateTime? ngayRa { get; set; }

        public int maBan { get; set; }

        public int? maKhuyenMai { get; set; }

        public bool trangThai { get; set; }

        public virtual Ban Ban { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHD { get; set; }

        public virtual KhuyenMai KhuyenMai { get; set; }
    }
}
