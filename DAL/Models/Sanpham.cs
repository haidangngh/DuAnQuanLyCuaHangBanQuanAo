using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Hoadonchitiets = new HashSet<Hoadonchitiet>();
        }

        public string MaSanPham { get; set; } = null!;
        public string TenSanPham { get; set; } = null!;
        public double GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string MaThuongHieu { get; set; } = null!;

        public virtual Thuonghieu MaThuongHieuNavigation { get; set; } = null!;
        public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; }
    }
}
