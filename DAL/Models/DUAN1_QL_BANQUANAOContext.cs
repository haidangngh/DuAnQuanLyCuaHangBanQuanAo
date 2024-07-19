﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class DUAN1_QL_BANQUANAOContext : DbContext
    {
        public DUAN1_QL_BANQUANAOContext()
        {
        }

        public DUAN1_QL_BANQUANAOContext(DbContextOptions<DUAN1_QL_BANQUANAOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chatlieu> Chatlieus { get; set; } = null!;
        public virtual DbSet<Hoadon> Hoadons { get; set; } = null!;
        public virtual DbSet<Hoadonchitiet> Hoadonchitiets { get; set; } = null!;
        public virtual DbSet<Khachhang> Khachhangs { get; set; } = null!;
        public virtual DbSet<Khuyenmai> Khuyenmais { get; set; } = null!;
        public virtual DbSet<Kichthuoc> Kichthuocs { get; set; } = null!;
        public virtual DbSet<Mausac> Mausacs { get; set; } = null!;
        public virtual DbSet<Nhanvien> Nhanviens { get; set; } = null!;
        public virtual DbSet<Salesanpham> Salesanphams { get; set; } = null!;
        public virtual DbSet<Sanpham> Sanphams { get; set; } = null!;
        public virtual DbSet<Sanphamchitiet> Sanphamchitiets { get; set; } = null!;
        public virtual DbSet<Taikhoan> Taikhoans { get; set; } = null!;
        public virtual DbSet<Thuonghieu> Thuonghieus { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=HOANGDUCMINH\\SQLEXPRESS;Database=DUAN1_QL_BANQUANAO;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chatlieu>(entity =>
            {
                entity.HasKey(e => e.MaChatLieu)
                    .HasName("PK__CHATLIEU__453995BC216B4E29");

                entity.ToTable("CHATLIEU");

                entity.Property(e => e.MaChatLieu)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MoTa).HasMaxLength(255);

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HOADON__835ED13B4B65AD27");

                entity.ToTable("HOADON");

                entity.Property(e => e.MaHoaDon)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaKhuyenMai)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaNhanVien)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NgayLap).HasColumnType("datetime");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThai).HasMaxLength(255);

                entity.HasOne(d => d.MaKhuyenMaiNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.MaKhuyenMai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADON__MaKhuyen__0D7A0286");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.MaNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADON__MaNhanVi__0C85DE4D");

                entity.HasOne(d => d.SoDienThoaiNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.SoDienThoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADON__SoDienTh__0E6E26BF");
            });

            modelBuilder.Entity<Hoadonchitiet>(entity =>
            {
                entity.HasKey(e => e.MaHoaDonChiTiet)
                    .HasName("PK__HOADONCH__6C2FD0CE8DA2E8DC");

                entity.ToTable("HOADONCHITIET");

                entity.Property(e => e.MaHoaDonChiTiet)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.MaHoaDon)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThai).HasMaxLength(255);

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.Hoadonchitiets)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADONCHI__MaHoa__114A936A");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.Hoadonchitiets)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADONCHI__MaSan__123EB7A3");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.SoDienThoai)
                    .HasName("PK__KHACHHAN__0389B7BC9834F37F");

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinh).HasMaxLength(5);

                entity.Property(e => e.HoVaTen).HasMaxLength(255);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            });

            modelBuilder.Entity<Khuyenmai>(entity =>
            {
                entity.HasKey(e => e.MaKhuyenMai)
                    .HasName("PK__KHUYENMA__6F56B3BD44B9118C");

                entity.ToTable("KHUYENMAI");

                entity.Property(e => e.MaKhuyenMai)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.KieuKhuyenMai)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MucGiam)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHetHan).HasColumnType("datetime");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.TrangThai).HasMaxLength(255);
            });

            modelBuilder.Entity<Kichthuoc>(entity =>
            {
                entity.HasKey(e => e.MaKichThuoc)
                    .HasName("PK__KICHTHUO__22BFD664F4B2D17F");

                entity.ToTable("KICHTHUOC");

                entity.Property(e => e.MaKichThuoc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MoTa).HasMaxLength(255);

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mausac>(entity =>
            {
                entity.HasKey(e => e.MaMauSac)
                    .HasName("PK__MAUSAC__B9A9116213278034");

                entity.ToTable("MAUSAC");

                entity.Property(e => e.MaMauSac)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MoTa).HasMaxLength(255);

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NHANVIEN__77B2CA47A9DB6165");

                entity.ToTable("NHANVIEN");

                entity.HasIndex(e => e.MaTaiKhoan, "UQ__NHANVIEN__AD7C652875B490BD")
                    .IsUnique();

                entity.Property(e => e.MaNhanVien)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaTaiKhoan)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NamSinh).HasColumnType("datetime");

                entity.Property(e => e.NgayVaoLam).HasColumnType("datetime");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TenNhanVien).HasMaxLength(255);

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaTaiKhoanNavigation)
                    .WithOne(p => p.Nhanvien)
                    .HasForeignKey<Nhanvien>(d => d.MaTaiKhoan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NHANVIEN__MaTaiK__07C12930");
            });

            modelBuilder.Entity<Salesanpham>(entity =>
            {
                entity.HasKey(e => e.MaSale)
                    .HasName("PK__SALESANP__B234B7A7CFE930E9");

                entity.ToTable("SALESANPHAM");

                entity.Property(e => e.MaSale)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GiaTri)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MoTa).HasMaxLength(255);

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SANPHAM__FAC7442DE9142573");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaThuongHieu)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TenSanPham).HasMaxLength(255);

                entity.HasOne(d => d.MaThuongHieuNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.MaThuongHieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAM__MaThuon__71D1E811");
            });

            modelBuilder.Entity<Sanphamchitiet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SANPHAMCHITIET");

                entity.Property(e => e.MaChatLieu)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaKichThuoc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaMauSac)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaSale)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaSanPhamChiTiet)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaThuongHieu)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MoTaChiTiet).HasMaxLength(255);

                entity.Property(e => e.TenSanPham).HasMaxLength(255);

                entity.HasOne(d => d.MaChatLieuNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaChatLieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCH__MaCha__7D439ABD");

                entity.HasOne(d => d.MaKichThuocNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaKichThuoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCH__MaKic__7C4F7684");

                entity.HasOne(d => d.MaMauSacNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaMauSac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCH__MaMau__7E37BEF6");

                entity.HasOne(d => d.MaSaleNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaSale)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCH__MaSal__00200768");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCH__MaSan__7B5B524B");

                entity.HasOne(d => d.MaThuongHieuNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaThuongHieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCH__MaThu__7F2BE32F");
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.HasKey(e => e.MaTaiKhoan)
                    .HasName("PK__TAIKHOAN__AD7C65296F5F9EA2");

                entity.ToTable("TAIKHOAN");

                entity.Property(e => e.MaTaiKhoan)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TenChucVu).HasMaxLength(255);

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Thuonghieu>(entity =>
            {
                entity.HasKey(e => e.MaThuongHieu)
                    .HasName("PK__THUONGHI__A3733E2CE42662E1");

                entity.ToTable("THUONGHIEU");

                entity.Property(e => e.MaThuongHieu)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TenThuongHieu).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
