using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHATLIEU",
                columns: table => new
                {
                    MaChatLieu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Ten = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHATLIEU__453995BC216B4E29", x => x.MaChatLieu);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    SoDienThoai = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    HoVaTen = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KHACHHAN__0389B7BC9834F37F", x => x.SoDienThoai);
                });

            migrationBuilder.CreateTable(
                name: "KHUYENMAI",
                columns: table => new
                {
                    MaKhuyenMai = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime", nullable: false),
                    KieuKhuyenMai = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MucGiam = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KHUYENMA__6F56B3BD44B9118C", x => x.MaKhuyenMai);
                });

            migrationBuilder.CreateTable(
                name: "KICHTHUOC",
                columns: table => new
                {
                    MaKichThuoc = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Ten = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KICHTHUO__22BFD664F4B2D17F", x => x.MaKichThuoc);
                });

            migrationBuilder.CreateTable(
                name: "MAUSAC",
                columns: table => new
                {
                    MaMauSac = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Ten = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TrangThai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MAUSAC__B9A9116213278034", x => x.MaMauSac);
                });

            migrationBuilder.CreateTable(
                name: "SALESANPHAM",
                columns: table => new
                {
                    MaSale = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    GiaTri = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SALESANP__B234B7A7CFE930E9", x => x.MaSale);
                });

            migrationBuilder.CreateTable(
                name: "TAIKHOAN",
                columns: table => new
                {
                    MaTaiKhoan = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TenDangNhap = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MatKhau = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TAIKHOAN__AD7C65296F5F9EA2", x => x.MaTaiKhoan);
                });

            migrationBuilder.CreateTable(
                name: "THUONGHIEU",
                columns: table => new
                {
                    MaThuongHieu = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    TenThuongHieu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SoDienThoai = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__THUONGHI__A3733E2CE42662E1", x => x.MaThuongHieu);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SoDienThoai = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    GioiTinh = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    NamSinh = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime", nullable: false),
                    MaTaiKhoan = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NHANVIEN__77B2CA47A9DB6165", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK__NHANVIEN__MaTaiK__07C12930",
                        column: x => x.MaTaiKhoan,
                        principalTable: "TAIKHOAN",
                        principalColumn: "MaTaiKhoan");
                });

            migrationBuilder.CreateTable(
                name: "SANPHAM",
                columns: table => new
                {
                    MaSanPham = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MaThuongHieu = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SANPHAM__FAC7442DE9142573", x => x.MaSanPham);
                    table.ForeignKey(
                        name: "FK__SANPHAM__MaThuon__71D1E811",
                        column: x => x.MaThuongHieu,
                        principalTable: "THUONGHIEU",
                        principalColumn: "MaThuongHieu");
                });

            migrationBuilder.CreateTable(
                name: "HOADON",
                columns: table => new
                {
                    MaHoaDon = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SoDienThoai = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    MaNhanVien = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaKhuyenMai = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TongTien = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOADON__835ED13B4B65AD27", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK__HOADON__MaKhuyen__0D7A0286",
                        column: x => x.MaKhuyenMai,
                        principalTable: "KHUYENMAI",
                        principalColumn: "MaKhuyenMai");
                    table.ForeignKey(
                        name: "FK__HOADON__MaNhanVi__0C85DE4D",
                        column: x => x.MaNhanVien,
                        principalTable: "NHANVIEN",
                        principalColumn: "MaNhanVien");
                    table.ForeignKey(
                        name: "FK__HOADON__SoDienTh__0E6E26BF",
                        column: x => x.SoDienThoai,
                        principalTable: "KHACHHANG",
                        principalColumn: "SoDienThoai");
                });

            migrationBuilder.CreateTable(
                name: "SANPHAMCHITIET",
                columns: table => new
                {
                    MaSanPhamChiTiet = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    TenSanPham = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    MaKichThuoc = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaChatLieu = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaMauSac = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaThuongHieu = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    MoTaChiTiet = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MaSale = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaSanPham = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__SANPHAMCH__MaCha__7D439ABD",
                        column: x => x.MaChatLieu,
                        principalTable: "CHATLIEU",
                        principalColumn: "MaChatLieu");
                    table.ForeignKey(
                        name: "FK__SANPHAMCH__MaKic__7C4F7684",
                        column: x => x.MaKichThuoc,
                        principalTable: "KICHTHUOC",
                        principalColumn: "MaKichThuoc");
                    table.ForeignKey(
                        name: "FK__SANPHAMCH__MaMau__7E37BEF6",
                        column: x => x.MaMauSac,
                        principalTable: "MAUSAC",
                        principalColumn: "MaMauSac");
                    table.ForeignKey(
                        name: "FK__SANPHAMCH__MaSal__00200768",
                        column: x => x.MaSale,
                        principalTable: "SANPHAM",
                        principalColumn: "MaSanPham");
                    table.ForeignKey(
                        name: "FK__SANPHAMCH__MaSan__7B5B524B",
                        column: x => x.MaSanPham,
                        principalTable: "SANPHAM",
                        principalColumn: "MaSanPham");
                    table.ForeignKey(
                        name: "FK__SANPHAMCH__MaThu__7F2BE32F",
                        column: x => x.MaThuongHieu,
                        principalTable: "THUONGHIEU",
                        principalColumn: "MaThuongHieu");
                });

            migrationBuilder.CreateTable(
                name: "HOADONCHITIET",
                columns: table => new
                {
                    MaHoaDonChiTiet = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaHoaDon = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    MaSanPham = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOADONCH__6C2FD0CE8DA2E8DC", x => x.MaHoaDonChiTiet);
                    table.ForeignKey(
                        name: "FK__HOADONCHI__MaHoa__114A936A",
                        column: x => x.MaHoaDon,
                        principalTable: "HOADON",
                        principalColumn: "MaHoaDon");
                    table.ForeignKey(
                        name: "FK__HOADONCHI__MaSan__123EB7A3",
                        column: x => x.MaSanPham,
                        principalTable: "SANPHAM",
                        principalColumn: "MaSanPham");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MaKhuyenMai",
                table: "HOADON",
                column: "MaKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MaNhanVien",
                table: "HOADON",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_SoDienThoai",
                table: "HOADON",
                column: "SoDienThoai");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCHITIET_MaHoaDon",
                table: "HOADONCHITIET",
                column: "MaHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCHITIET_MaSanPham",
                table: "HOADONCHITIET",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "UQ__NHANVIEN__AD7C652875B490BD",
                table: "NHANVIEN",
                column: "MaTaiKhoan",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MaThuongHieu",
                table: "SANPHAM",
                column: "MaThuongHieu");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCHITIET_MaChatLieu",
                table: "SANPHAMCHITIET",
                column: "MaChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCHITIET_MaKichThuoc",
                table: "SANPHAMCHITIET",
                column: "MaKichThuoc");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCHITIET_MaMauSac",
                table: "SANPHAMCHITIET",
                column: "MaMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCHITIET_MaSale",
                table: "SANPHAMCHITIET",
                column: "MaSale");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCHITIET_MaSanPham",
                table: "SANPHAMCHITIET",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCHITIET_MaThuongHieu",
                table: "SANPHAMCHITIET",
                column: "MaThuongHieu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HOADONCHITIET");

            migrationBuilder.DropTable(
                name: "SALESANPHAM");

            migrationBuilder.DropTable(
                name: "SANPHAMCHITIET");

            migrationBuilder.DropTable(
                name: "HOADON");

            migrationBuilder.DropTable(
                name: "CHATLIEU");

            migrationBuilder.DropTable(
                name: "KICHTHUOC");

            migrationBuilder.DropTable(
                name: "MAUSAC");

            migrationBuilder.DropTable(
                name: "SANPHAM");

            migrationBuilder.DropTable(
                name: "KHUYENMAI");

            migrationBuilder.DropTable(
                name: "NHANVIEN");

            migrationBuilder.DropTable(
                name: "KHACHHANG");

            migrationBuilder.DropTable(
                name: "THUONGHIEU");

            migrationBuilder.DropTable(
                name: "TAIKHOAN");
        }
    }
}
