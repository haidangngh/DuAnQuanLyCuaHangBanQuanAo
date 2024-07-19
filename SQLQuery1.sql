create database DUAN1_QL_BANQUANAO
go
use DUAN1_QL_BANQUANAO
go
create table THUONGHIEU(
MaThuongHieu VARCHAR(25),
TenThuongHieu NVARCHAR(255) not null,
Email varchar(255) not null,
SoDienThoai varchar(11) not null 
primary key (MaThuongHieu),
)
go
create table SANPHAM(
MaSanPham varchar(255),
TenSanPham nvarchar(255) not null,
GiaBan float not null,
SoLuong int not null,
MaThuongHieu Varchar(25) not null
primary key (MaSanPham),
foreign key (MaThuongHieu) references ThuongHieu(MaThuongHieu)
)
go
create table KICHTHUOC(
MaKichThuoc varchar(255),
Ten varchar(255) not null,
MoTa nvarchar(255) not null,
TrangThai varchar(50) not null,
primary key (MaKichThuoc),
)
go
create table CHATLIEU(
MaChatLieu varchar(255),
Ten varchar(255) not null,
MoTa nvarchar(255) not null,
TrangThai varchar(50) not null,
primary key (MaChatLieu),
)
go
create table MAUSAC(
MaMauSac varchar(255),
Ten varchar(255) not null,
MoTa nvarchar(255) not null,
TrangThai varchar(50) not null,
primary key (MaMauSac),
)
go
create table SALESANPHAM(
MaSale varchar(255),
GiaTri varchar(255) not null,
NgayBatDau datetime not null,
NgayKetThuc datetime not null,
MoTa Nvarchar(255) not null,
primary key (MaSale)
)
go
create table SANPHAMCHITIET(
MaSanPhamChiTiet varchar(255),
TenSanPham nvarchar(255) not null,
Gia float not null,
SoLuong int not null,
MaKichThuoc varchar(255) not null,
MaChatLieu varchar(255) not null,
MaMauSac varchar(255) not null,
MaThuongHieu varchar(25) not null,
MoTaChiTiet nvarchar(255) not null,
MaSale varchar(255) not null,
MaSanPham varchar(255) not null,
foreign key (MaSanPham) references SANPHAM (MaSanPham),
foreign key (MaKichThuoc) references KICHTHUOC (MaKichThuoc),
foreign key (MaChatLieu) references CHATLIEU (MaChatLieu),
foreign key (MaMauSac) references MAUSAC (MaMauSac),
foreign key (MaThuongHieu) references THUONGHIEU (MaThuongHieu),
foreign key (MaSale) references SANPHAM (MaSanPham),
)
go
create table KHACHHANG
(
SoDienThoai varchar(11),
HoVaTen nvarchar(255) not null,
GioiTinh nvarchar(5) not null,
DiaChi nvarchar(255) not null,
NgaySinh datetime not null,
Email varchar(255) not null,
primary key (SoDienThoai)
)
go
create table NHANVIEN (
MaNhanVien varchar(255) unique,
TenNhanVien nvarchar(255) not null,
DiaChi nvarchar(255) not null,
SoDienThoai varchar(11) not null,
GioiTinh varchar(255) not null,
NamSinh datetime not null,
TrangThai varchar(255) not null,
NgayVaoLam datetime not null,
TenDangNhap varchar(255) unique ,
MatKhau varchar(255) ,
TenChucVu Nvarchar(255) not null,
primary key (MaNhanVien),
)
go
create table KHUYENMAI(
MaKhuyenMai varchar(255),
NgayTao datetime not null,
NgayHetHan datetime not null,
KieuKhuyenMai varchar(255) not null,
MucGiam varchar(255) not null,
TrangThai Nvarchar(255) not null,
SoLuong int not null,
GhiChu Nvarchar(255) not null
primary key (MaKhuyenMai)
)
go
create table HOADON
(
MaHoaDon varchar(255),
SoDienThoai varchar(11) not null,
MaNhanVien varchar(255) not null,
MaKhuyenMai varchar(255) not null,
NgayLap datetime not null,
TrangThai nvarchar(255) not null,
TongTien float not null,
primary key (MaHoaDon),
foreign key (MaNhanVien) references NHANVIEN (MaNhanVien),
foreign key (MaKhuyenMai) references KHUYENMAI (MaKhuyenMai),
foreign key (SoDienThoai) references KHACHHANG (SoDienThoai)
)
go
create table HOADONCHITIET (
MaHoaDonChiTiet varchar(255),
MaHoaDon varchar(255) not null,
MaSanPham varchar(255) not null,
SoLuong int not null,
DonGia float not null,
TrangThai nvarchar(255) not null,
GhiChu nvarchar(255) not null,
primary key (MaHoaDonChiTiet),
foreign key (MaHoaDon) references HoaDon (MaHoaDon),
foreign key (MaSanPham) references SANPHAM (MaSanPham)
)
