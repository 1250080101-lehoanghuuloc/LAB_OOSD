# Hệ thống phần mềm Cửa hàng Online "e-SHOPPING"

Tài liệu tả yêu cầu nghiệp vụ và cấu trúc tính năng cho hệ thống website bán hàng trực tuyến e-SHOPPING phục vụ cửa hàng ABC.

---

## 1. Giới thiệu tổng quan

Để chuẩn bị cho mùa mua sắm Giáng sinh và Năm mới, cửa hàng ABC quyết định mở rộng kênh bán hàng trực tuyến với hệ thống website e-SHOPPING. Hệ thống hỗ trợ khách hàng tìm kiếm, chọn mua, đặt hàng và thanh toán trực tuyến nhanh chóng, an toàn.

---

## 2. Các chức năng chính

### 2.1. Quản lý & Hiển thị Sản phẩm
* **Tích hợp hệ thống:** Kết nối với *Hệ thống quản lý sản phẩm* sẵn có của cửa hàng để lấy dữ liệu sản phẩm realtime.
* **Thông tin sản phẩm:**
  * Mã số sản phẩm (Duy nhất)
  * Tên sản phẩm, Nhà sản xuất
  * Nhóm sản phẩm (Đồ chơi, Gia dụng, Máy tính...)
  * Mô tả, Thông số kỹ thuật, Hình ảnh minh họa
  * Giá bán hiện hành (có thể thay đổi theo thời gian)
  * Trạng thái hàng (Còn hàng / Hết hàng)
* **Duyệt sản phẩm:** Xem sản phẩm theo nhóm, xem chi tiết sản phẩm và thêm sản phẩm vào giỏ hàng từ trang danh sách hoặc trang chi tiết.

### 2.2. Quản lý Giỏ hàng
* Xem danh sách các sản phẩm đã chọn.
* Cập nhật số lượng mua hoặc loại bỏ sản phẩm khỏi giỏ hàng.
* Chuyển sang bước **Tính tiền** để bắt đầu quy trình đặt hàng.

### 2.3. Quy trình Đặt hàng & Thanh toán
1. **Xác thực người dùng:** Yêu cầu đăng nhập hoặc đăng ký tài khoản mới nếu chưa có.
2. **Chọn loại hình giao hàng:** Chọn giữa các gói giao hàng phù hợp.
3. **Nhập thông tin người nhận:** Họ tên, địa chỉ, số điện thoại (Người nhận có thể khác người mua).
4. **Nhập thông tin thanh toán:** Điền thông tin thẻ tín dụng (Loại thẻ, số thẻ, ngày hết hạn, chủ thẻ, mã CSV).
5. **Xác thực thanh toán:** Hệ thống tự động kết nối cổng thanh toán trực tuyến để kiểm tra thẻ.
6. **Xác nhận đơn hàng:** Lưu đơn hàng vào hệ thống và gửi email xác nhận cho khách (không hiển thị thông tin thẻ trong email).

### 2.4. Quản lý Tài khoản Khách hàng
* Đăng ký tài khoản cá nhân.
* Thông tin lưu trữ: Họ tên, Ngày sinh, CMND/CCCD/Passport, Địa chỉ, Số điện thoại, Tên đăng nhập, Mật khẩu, Email.

---

## 3. Quy định Nghiệp vụ (Business Rules)

### 3.1. Giao hàng & Phí vận chuyển

Hệ thống hỗ trợ 3 hình thức giao hàng với chính sách ưu đãi miễn phí như sau:

| Loại hình giao hàng | Phí mặc định | Điều kiện Miễn phí |
| :--- | :--- | :--- |
| **Giao hàng thường** | Phí chuẩn theo khu vực | Không áp dụng miễn phí |
| **Chuyển phát nhanh** | Phí CPN theo khu vực | Đơn hàng từ **1.000.000 VNĐ** trở lên |
| **Chuyển phát nhanh trong ngày** | Phí CPN trong ngày theo khu vực | Đơn hàng từ **5.000.000 VNĐ** trở lên |

### 3.2. Quy định Thanh toán bằng Thẻ tín dụng

| Loại thẻ | Số chữ số | Mã an ninh (CSV) | Mức lệ phí |
| :--- | :--- | :--- | :--- |
| **VISA** | 16 chữ số | 3 chữ số | Theo chính sách loại thẻ |
| **MasterCard** | 16 chữ số | 3 chữ số | Theo chính sách loại thẻ |
| **Discover** | 16 chữ số | 3 chữ số | Theo chính sách loại thẻ |
| **American Express (Amex)** | 15 chữ số | 4 chữ số | Theo chính sách loại thẻ |

### 3.3. Bảo mật & An toàn thông tin
* **Xác thực thẻ:** Thông tin thẻ tín dụng được kiểm tra qua Hệ thống dịch vụ thanh toán trực tuyến bên thứ 3.
* **Quy định an toàn Email:** Email xác nhận gửi cho khách hàng **tuyệt đối không chứa thông tin thẻ tín dụng**.