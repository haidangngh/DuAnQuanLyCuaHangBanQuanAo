using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Hoadonchitiet
    {
        public string MaHoaDonChiTiet { get; set; } = null!;
        public string MaHoaDon { get; set; } = null!;
        public string MaSanPham { get; set; } = null!;
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public string TrangThai { get; set; } = null!;
        public string GhiChu { get; set; } = null!;

        public virtual Hoadon MaHoaDonNavigation { get; set; } = null!;
        public virtual Sanpham MaSanPhamNavigation { get; set; } = null!;
    }
}
