-- =============================================
-- CSDL: QuanLyBenhAn  (Bệnh viện đa khoa quốc tế)
-- Chạy toàn bộ script này trong SSMS trước khi chạy ứng dụng
-- =============================================
IF DB_ID(N'QuanLyBenhAn') IS NOT NULL
BEGIN
    ALTER DATABASE QuanLyBenhAn SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyBenhAn;
END
GO
CREATE DATABASE QuanLyBenhAn;
GO
USE QuanLyBenhAn;
GO

-- ========== DANH MỤC ==========
CREATE TABLE Khoa (
    MaKhoa  VARCHAR(10)   NOT NULL PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL
);

CREATE TABLE BacSi (
    MaBS   VARCHAR(10)   NOT NULL PRIMARY KEY,
    HoTen  NVARCHAR(100) NOT NULL,
    MaKhoa VARCHAR(10)   NOT NULL REFERENCES Khoa(MaKhoa)
);

CREATE TABLE Thuoc (
    MaThuoc  VARCHAR(10)   NOT NULL PRIMARY KEY,
    TenThuoc NVARCHAR(100) NOT NULL,
    DonViTinh NVARCHAR(30) NULL
);

CREATE TABLE XetNghiem (
    MaXN  VARCHAR(10)   NOT NULL PRIMARY KEY,
    TenXN NVARCHAR(100) NOT NULL
);

-- ========== BỆNH NHÂN / HỒ SƠ BỆNH ÁN (trang bìa) ==========
CREATE TABLE BenhNhan (
    MaHoSo    VARCHAR(10)   NOT NULL PRIMARY KEY,   -- Mã hồ sơ (phân biệt các bệnh nhân)
    HoTen     NVARCHAR(100) NOT NULL,
    DiaChi    NVARCHAR(200) NULL,
    NgaySinh  DATE          NULL,
    DienThoai VARCHAR(20)   NULL,
    Anh       VARBINARY(MAX) NULL,                  -- Ảnh chụp 3x4
    NgayLap   DATE          NOT NULL DEFAULT (CAST(GETDATE() AS DATE))
);

-- Phiếu đăng ký + lệ phí hằng năm (mỗi lần đóng / gia hạn là 1 dòng)
CREATE TABLE DangKy (
    MaDK       INT IDENTITY(1,1) PRIMARY KEY,
    MaHoSo     VARCHAR(10)   NOT NULL REFERENCES BenhNhan(MaHoSo),
    NgayDangKy DATE          NOT NULL,
    LePhi      DECIMAL(18,0) NOT NULL,
    NgayHetHan DATE          NOT NULL
);

-- ========== PHIẾU KHÁM BỆNH (các trang sau của hồ sơ) ==========
CREATE TABLE PhieuKham (
    MaPhieuKham INT IDENTITY(1,1) PRIMARY KEY,
    MaHoSo      VARCHAR(10)   NOT NULL REFERENCES BenhNhan(MaHoSo),
    NgayGioKham DATETIME      NOT NULL,
    MaBS        VARCHAR(10)   NOT NULL REFERENCES BacSi(MaBS),
    MaKhoa      VARCHAR(10)   NOT NULL REFERENCES Khoa(MaKhoa),
    LoaiKham    NVARCHAR(30)  NOT NULL,             -- N'Điều trị' hoặc N'Khám định kỳ'
    TrieuChung  NVARCHAR(500) NULL,
    ThanNhiet   DECIMAL(4,1)  NULL,
    HuyetAp     VARCHAR(20)   NULL,
    ChanDoan    NVARCHAR(300) NULL,
    PhanUngPhu  NVARCHAR(300) NULL,                 -- Phản ứng phụ do thuốc
    NgayXuatVien DATE         NULL,
    VienPhi     DECIMAL(18,0) NOT NULL DEFAULT (0)  -- Khám định kỳ = 0
);

CREATE TABLE ToaThuoc (
    MaPhieuKham INT          NOT NULL REFERENCES PhieuKham(MaPhieuKham),
    MaThuoc     VARCHAR(10)  NOT NULL REFERENCES Thuoc(MaThuoc),
    SoLuong     INT          NOT NULL,
    CachDung    NVARCHAR(200) NULL,
    PRIMARY KEY (MaPhieuKham, MaThuoc)
);

CREATE TABLE KetQuaXN (
    MaPhieuKham INT          NOT NULL REFERENCES PhieuKham(MaPhieuKham),
    MaXN        VARCHAR(10)  NOT NULL REFERENCES XetNghiem(MaXN),
    KetQua      NVARCHAR(300) NULL,
    PRIMARY KEY (MaPhieuKham, MaXN)
);

-- ========== LỊCH HẸN KHÁM ĐỊNH KỲ THEO QUÝ ==========
CREATE TABLE LichHen (
    MaHen      INT IDENTITY(1,1) PRIMARY KEY,
    MaHoSo     VARCHAR(10)   NOT NULL REFERENCES BenhNhan(MaHoSo),
    NgayGioHen DATETIME      NOT NULL,
    Quy        TINYINT       NOT NULL,
    Nam        INT           NOT NULL,
    GhiChu     NVARCHAR(200) NULL,
    TrangThai  NVARCHAR(20)  NOT NULL DEFAULT (N'Đã hẹn')   -- Đã hẹn / Đã khám / Hủy
);
GO

-- ========== DỮ LIỆU MẪU ==========
INSERT INTO Khoa VALUES
 ('NOI',  N'Khoa Nội tổng hợp'),
 ('NGOAI',N'Khoa Ngoại'),
 ('NHI',  N'Khoa Nhi'),
 ('TMH',  N'Khoa Tai Mũi Họng'),
 ('TIM',  N'Khoa Tim mạch');

INSERT INTO BacSi VALUES
 ('BS01', N'BS. Nguyễn Văn An',   'NOI'),
 ('BS02', N'BS. Trần Thị Bình',   'NOI'),
 ('BS03', N'BS. Lê Hoàng Cường',  'NGOAI'),
 ('BS04', N'BS. Phạm Minh Đức',   'NHI'),
 ('BS05', N'BS. Võ Thị Hạnh',     'TMH'),
 ('BS06', N'BS. Đặng Quốc Khánh', 'TIM');

INSERT INTO Thuoc VALUES
 ('T01', N'Paracetamol 500mg',  N'Viên'),
 ('T02', N'Amoxicillin 500mg',  N'Viên'),
 ('T03', N'Ibuprofen 400mg',    N'Viên'),
 ('T04', N'Omeprazole 20mg',    N'Viên'),
 ('T05', N'Vitamin C 500mg',    N'Viên'),
 ('T06', N'Amlodipine 5mg',     N'Viên'),
 ('T07', N'Siro ho Prospan',    N'Chai');

INSERT INTO XetNghiem VALUES
 ('XN01', N'Xét nghiệm công thức máu'),
 ('XN02', N'Xét nghiệm đường huyết'),
 ('XN03', N'Xét nghiệm mỡ máu'),
 ('XN04', N'Xét nghiệm nước tiểu'),
 ('XN05', N'Chụp X-quang phổi'),
 ('XN06', N'Điện tâm đồ (ECG)');

INSERT INTO BenhNhan(MaHoSo, HoTen, DiaChi, NgaySinh, DienThoai) VALUES
 ('HS0001', N'Nguyễn Thị Lan',  N'12 Lê Lợi, Quận 1, TP.HCM',       '1988-03-15', '0901234567'),
 ('HS0002', N'Trần Văn Minh',   N'45 Nguyễn Huệ, Quận 1, TP.HCM',   '1975-11-02', '0912345678'),
 ('HS0003', N'Lê Thị Hoa',      N'88 Trần Hưng Đạo, Quận 5, TP.HCM','1992-07-21', '0987654321');

-- HS0001, HS0002 còn hạn; HS0003 đã hết hạn lệ phí (để thử chức năng gia hạn)
INSERT INTO DangKy(MaHoSo, NgayDangKy, LePhi, NgayHetHan) VALUES
 ('HS0001', DATEADD(MONTH,-3,CAST(GETDATE() AS DATE)),  200000, DATEADD(MONTH, 9,CAST(GETDATE() AS DATE))),
 ('HS0002', DATEADD(MONTH,-6,CAST(GETDATE() AS DATE)),  200000, DATEADD(MONTH, 6,CAST(GETDATE() AS DATE))),
 ('HS0003', DATEADD(MONTH,-15,CAST(GETDATE() AS DATE)), 200000, DATEADD(MONTH,-3,CAST(GETDATE() AS DATE)));

INSERT INTO PhieuKham(MaHoSo, NgayGioKham, MaBS, MaKhoa, LoaiKham, TrieuChung, ThanNhiet, HuyetAp, ChanDoan, PhanUngPhu, NgayXuatVien, VienPhi) VALUES
 ('HS0001', DATEADD(DAY,-60,GETDATE()), 'BS01','NOI',  N'Điều trị',    N'Nhức đầu, sốt nhẹ, mệt mỏi', 38.2, '120/80', N'Cảm cúm',        NULL,                 CAST(DATEADD(DAY,-58,GETDATE()) AS DATE), 450000),
 ('HS0001', DATEADD(DAY,-20,GETDATE()), 'BS02','NOI',  N'Khám định kỳ',N'Không có triệu chứng',       36.6, '115/75', N'Sức khỏe bình thường', NULL,             CAST(DATEADD(DAY,-20,GETDATE()) AS DATE), 0),
 ('HS0002', DATEADD(DAY,-30,GETDATE()), 'BS06','TIM',  N'Điều trị',    N'Đau tức ngực, huyết áp cao', 36.8, '150/95', N'Tăng huyết áp',  N'Hơi chóng mặt sau khi uống thuốc', CAST(DATEADD(DAY,-29,GETDATE()) AS DATE), 800000);

INSERT INTO ToaThuoc VALUES
 (1, 'T01', 10, N'Uống 1 viên khi sốt trên 38.5°C, cách nhau 6 giờ'),
 (1, 'T05', 14, N'Uống 1 viên sau ăn sáng'),
 (3, 'T06', 30, N'Uống 1 viên mỗi sáng');

INSERT INTO KetQuaXN VALUES
 (1, 'XN01', N'Bạch cầu tăng nhẹ'),
 (2, 'XN01', N'Bình thường'),
 (2, 'XN02', N'5.2 mmol/L - Bình thường'),
 (3, 'XN06', N'Nhịp xoang, không bất thường');

INSERT INTO LichHen(MaHoSo, NgayGioHen, Quy, Nam, GhiChu, TrangThai) VALUES
 ('HS0002', DATEADD(DAY,3,CAST(GETDATE() AS DATETIME)), DATEPART(QUARTER, DATEADD(DAY,3,GETDATE())), YEAR(DATEADD(DAY,3,GETDATE())), N'Khám sức khỏe định kỳ', N'Đã hẹn');
GO
