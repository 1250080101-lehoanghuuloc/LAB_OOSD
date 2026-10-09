# LAB5 - QUẢN LÝ CÔNG TY DU LỊCH

## 1. Giới thiệu

LAB5 là bài thực hành môn **Phát triển phần mềm hướng đối tượng (OOSD)**, xây dựng ứng dụng **Quản lý Công ty Du lịch** bằng **C#** và **Windows Forms**.

Ứng dụng cung cấp các chức năng quản lý thông tin tour du lịch, lập phiếu đăng ký cho khách hàng (khách theo đoàn và khách lẻ), phân công hướng dẫn viên, tính lương nhân viên, khảo sát ý kiến và lập phiếu đền bù. Dữ liệu được lưu trữ và quản lý trên **SQL Server** với cơ sở dữ liệu `QuanLyDuLich`.

## 2. Công nghệ sử dụng

- C#
- Windows Forms
- .NET
- SQL Server
- ADO.NET
- Visual Studio
- Git/GitHub

## 3. Chức năng chính

- Quản lý thông tin tour du lịch.
- Quản lý điểm tham quan và nơi dừng chân.
- Đăng ký tour cho khách theo đoàn (> 12 người) và thu tiền đặt cọc.
- Đăng ký tour cho khách lẻ (< 12 người) và thanh toán tiền vé.
- Quản lý danh sách khách hàng và danh sách người đi cùng.
- Phân công nhân viên/hướng dẫn viên theo tour và chuyến đi.
- Tính lương nhân viên (lương căn bản + lương theo tour).
- Tiếp nhận và quản lý phiếu khảo sát ý kiến khách hàng.
- Lập phiếu đền bù khi phát sinh sự cố.
- Tra cứu, báo cáo và thống kê doanh thu.
- Kết nối và thao tác với cơ sở dữ liệu SQL Server.

## 4. Cấu trúc thư mục

LAB5/
├── README.md
└── QuanLyDuLich/
    ├── QuanLyDuLich.sln
    └── QuanLyDuLich/

## 5. Cách tải và chạy chương trình

### 5.1. Tải source code

Clone repository về máy bằng Git:

```bash
git clone [https://github.com/1250080101-lehoanghuuloc/LAB_OOSD.git](https://github.com/1250080101-lehoanghuuloc/LAB_OOSD.git)