namespace WebBanQuanAo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
            ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
        }

        [Key]
        public int IdSanPham { get; set; }

        public string TenSanPham { get; set; }

        public decimal? DonGia { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public string MoTa { get; set; }

        public int? LuotXem { get; set; }

        public int? IdLoaiSanPham { get; set; }

        public decimal? GiaKhuyenMai { get; set; }

        public string HinhAnh { get; set; }

        public string HinhAnh1 { get; set; }

        public string HinhAnh2 { get; set; }

        public bool? DaXoa { get; set; }

        public int? Moi { get; set; }

        public int? IdMLSP { get; set; }

        public int? SoLuongTon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }

        public virtual MaLoaiSanPham MaLoaiSanPham { get; set; }
    }
}
