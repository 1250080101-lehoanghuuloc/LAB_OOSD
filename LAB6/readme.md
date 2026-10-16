# LAB6 - QUẢN LÝ BỆNH ÁN

## 1. Giới thiệu
**LAB6** là bài thực hành môn **Phát triển phần mềm hướng đối tượng (OOSD)**, xây dựng ứng dụng **Quản lý Bệnh án** bằng ngôn ngữ C# và giao diện Windows Forms (.NET Framework 4.7.2).

Ứng dụng cung cấp đầy đủ các chức năng quản lý danh mục (Khoa, Bác sĩ, Thuốc, Xét nghiệm), tiếp nhận hồ sơ bệnh nhân & quản lý lệ phí năm, lập phiếu khám bệnh chi tiết (triệu chứng, chỉ số sinh tồn, toa thuốc, xét nghiệm, phản ứng phụ, viện phí), đăng ký hẹn khám định kỳ theo quý, tra cứu lịch sử bệnh án và thống kê báo cáo doanh thu. Dữ liệu được lưu trữ và quản lý tập trung trên hệ quản trị CSDL SQL Server với cơ sở dữ liệu `QuanLyBenhAn`.

---

## 2. Công nghệ sử dụng
- **Ngôn ngữ:** C# (.NET Framework 4.7.2)
- **Giao diện:** Windows Forms (WinForms)
- **Cơ sở dữ liệu:** SQL Server
- **Công nghệ truy xuất dữ liệu:** ADO.NET
- **Môi trường phát triển (IDE):** Visual Studio 2022
- **Quản lý mã nguồn:** Git / GitHub

---

## 3. Chức năng chính
- **Quản lý danh mục:** Quản lý thông tin Khoa, Bác sĩ, Danh mục thuốc và Các loại xét nghiệm.
- **Tiếp nhận & Đăng ký hồ sơ:**
  - Lập phiếu đăng ký cho bệnh nhân mới (Họ tên, địa chỉ, ngày sinh, SĐT, ảnh thẻ 3x4).
  - Cấp mã hồ sơ tự động và thu lệ phí hằng năm.
  - Quản lý và gia hạn lệ phí hằng năm (Ví dụ: kiểm thử chức năng gia hạn với hồ sơ `HS0003`).
- **Khám bệnh & Lập phiếu khám:**
  - Tra cứu hồ sơ bệnh nhân theo mã.
  - Lập phiếu khám chi tiết (Ngày giờ khám, bác sĩ phụ trách, khoa, triệu chứng, thân nhiệt, huyết áp, toa thuốc, chỉ định xét nghiệm, phản ứng phụ, viện phí, ngày xuất viện).
  - Xem toàn bộ lịch sử các lần khám bệnh của bệnh nhân.
- **Hẹn khám sức khỏe định kỳ:** Đăng ký lịch hẹn khám định kỳ theo quý (miễn phí, giới hạn tối đa 1 lần/quý).
- **Tra cứu hồ sơ:** Tra cứu nhanh chóng theo Mã hồ sơ, Họ tên hoặc Số điện thoại; xem chi tiết lịch sử khám, đơn thuốc và kết quả xét nghiệm.
- **Báo cáo & Thống kê:** Thống kê tổng hợp theo Khoa, Bác sĩ, Danh mục thuốc sử dụng và Doanh thu viện phí.
- **Kết nối CSDL:** Cấu hình chuỗi kết nối tập trung trong `Db.cs` và thao tác dữ liệu an toàn với SQL Server.

---

## 4. Cấu trúc thư mục
```text
LAB6/
├── README.md
└── QuanLyBenhAn/
    ├── QuanLyBenhAn.sln
    ├── Database/
    │   └── QuanLyBenhAn.sql
    └── QuanLyBenhAn/
        ├── Db.cs
        ├── FrmMain.cs
        ├── FrmDanhMuc.cs
        ├── FrmDangKy.cs
        ├── FrmPhieuKham.cs
        ├── FrmHenKham.cs
        ├── FrmTraCuu.cs
        └── FrmThongKe.cs
```

---

## 5. Cách tải và chạy chương trình

### 5.1. Tải source code
Clone repository về máy thông qua Git:
```bash
git clone https://github.com/1250080101-lehoanghuuloc/LAB_OOSD.git
```

### 5.2. Hướng dẫn cấu hình CSDL và chạy ứng dụng
1. Mở phần mềm **SQL Server Management Studio (SSMS)**, mở và chạy file script `Database\QuanLyBenhAn.sql` để tạo CSDL `QuanLyBenhAn` cùng dữ liệu mẫu (Gồm 3 hồ sơ từ `HS0001` đến `HS0003`; trong đó `HS0003` được thiết lập sẵn hết hạn lệ phí để thử chức năng gia hạn).
2. Mở file giải pháp **`QuanLyBenhAn.sln`** bằng **Visual Studio 2022**.
3. Kiểm tra và điều chỉnh chuỗi kết nối trong file **`Db.cs`** cho phù hợp với máy của bạn:
   - Mặc định: `Data Source=. ; Integrated Security=True` (Sử dụng Windows Authentication).
   - Nếu dùng SQL Express: Đổi `Data Source=.` thành `Data Source=.\SQLEXPRESS`.
4. Nhấn **F5** (hoặc nút **Start**) để biên dịch và bắt đầu chạy ứng dụng.