using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        public string MaNhanVien { get; set; } = null!;
        public string TenNhanVien { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public string SoDienThoai { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public DateTime NamSinh { get; set; }
        public string TrangThai { get; set; } = null!;
        public DateTime NgayVaoLam { get; set; }
        public string MaTaiKhoan { get; set; } = null!;

        public virtual Taikhoan MaTaiKhoanNavigation { get; set; } = null!;
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
