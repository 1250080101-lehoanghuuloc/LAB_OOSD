# LAB 3: HỆ THỐNG QUẢN LÝ KHÁCH SẠN (HOTEL MANAGEMENT SYSTEM)

**Môn học:** Phân tích & Thiết kế Hướng đối tượng (OOSD)  
**Họ và tên:** Lê Hoàng Hữu Lộc  
**Mã sinh viên:** 1250080101  
**Repository:** `LAB_OOSD/LAB3`  

---

## 1. Tổng Quan Bài Lab 3

Ứng dụng **Quản lý Khách sạn** được phát triển trên nền tảng **C# Windows Forms (.NET)** kết hợp với hệ quản trị cơ sở dữ liệu **SQL Server**. Hệ thống quản lý toàn diện từ màn hình chính điều hướng đến các nghiệp vụ cốt lõi: Danh mục hệ thống, Quản lý Phòng - Tiện nghi, Đặt/Nhận phòng, Sử dụng dịch vụ, Trả phòng - Đền bù - Hóa đơn - Thanh toán và Báo cáo Thống kê.

---

## 2. Cấu Trúc Mã Nguồn Dự Án (Project Structure)

```text
LAB3/
├── README.md                              # File báo cáo & mô tả tổng quan Lab 3
├── LAP03_LEHOANGHUULOC_1250080101.docx             # File Word chứa tài liệu, hình ảnh Form & CSDL
└── QuanLyKhachSan/
    ├── Data/
    │   └── Db.cs                          # Kết nối & thực thi truy vấn SQL Server
    ├── Services/
    │   ├── DanhMucService.cs              # Nghiệp vụ quản lý danh mục (Nhân viên, Khách hàng)
    │   ├── DichVuService.cs               # Nghiệp vụ ghi nhận & lịch sử sử dụng dịch vụ
    │   ├── TraPhongService.cs             # Nghiệp vụ kiểm tra phòng, đền bù, hóa đơn, thanh toán
    │   └── ThongKeService.cs              # Nghiệp vụ thống kê & chỉ số báo cáo tổng hợp
    ├── Forms/
    │   ├── FrmMain.cs (.Designer)         # Giao diện Trang chủ / Menu điều hướng chính
    │   ├── FrmDanhMuc.cs (.Designer)      # Giao diện Quản lý Danh mục
    │   ├── FrmPhong.cs (.Designer)        # Giao diện Quản lý Phòng - Tiện nghi
    │   ├── FrmDatPhong.cs (.Designer)     # Giao diện Đặt / Nhận phòng
    │   ├── FrmDichVu.cs (.Designer)       # Giao diện Ghi nhận dịch vụ
    │   ├── FrmTraPhong.cs (.Designer)     # Giao diện Trả phòng - Đền bù - Thanh toán
    │   └── FrmThongKe.cs (.Designer)      # Giao diện Báo cáo Thống kê
