-- 1. Bảng Phòng
CREATE TABLE Phong (
    SoPhong VARCHAR(10) PRIMARY KEY,
    LoaiPhong NVARCHAR(50) NOT NULL,
    GiaTheoGio DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(30) NOT NULL -- 'Trống', 'Đang ở', 'Đang dọn dẹp'
);

-- 2. Bảng Khách Hàng
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    CCCD VARCHAR(20) UNIQUE NOT NULL,
    SoDienThoai VARCHAR(15)
);

-- 3. Bảng Dịch Vụ
CREATE TABLE DichVu (
    MaDV INT IDENTITY(1,1) PRIMARY KEY,
    TenDV NVARCHAR(100) NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL
);

-- 4. Bảng Phiếu Đặt Phòng
CREATE TABLE PhieuDatPhong (
    MaPhieu INT IDENTITY(1,1) PRIMARY KEY,
    SoPhong VARCHAR(10) FOREIGN KEY REFERENCES Phong(SoPhong),
    MaKH INT FOREIGN KEY REFERENCES KhachHang(MaKH),
    NgayNhanPhong DATETIME NOT NULL,
    NgayTraPhong DATETIME NULL,
    TongTienThanhToan DECIMAL(18,2) NULL
);

-- 5. Bảng Chi Tiết Dịch Vụ
CREATE TABLE SuDungDichVu (
    MaPhieu INT FOREIGN KEY REFERENCES PhieuDatPhong(MaPhieu),
    MaDV INT FOREIGN KEY REFERENCES DichVu(MaDV),
    SoLuong INT NOT NULL,
    ThoiGian DATETIME NOT NULL,
    PRIMARY KEY (MaPhieu, MaDV, ThoiGian)
);

-- DỮ LIỆU MẪU BAN ĐẦU
INSERT INTO Phong VALUES 
('P101', N'Đơn', 50000, N'Trống'),
('P102', N'Đơn', 50000, N'Trống'),
('P201', N'Đôi', 80000, N'Trống'),
('P301', N'VIP', 150000, N'Trống');

INSERT INTO DichVu VALUES 
(N'Nước khoáng', 10000),
(N'Nước ngọt lon', 15000),
(N'Mì ăn liền', 20000),
(N'Giặt ủi', 30000);