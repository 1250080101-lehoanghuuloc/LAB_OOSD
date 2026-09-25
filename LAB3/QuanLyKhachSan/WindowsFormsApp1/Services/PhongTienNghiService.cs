using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class PhongTienNghiService
    {
        // 1. Hàm lấy danh sách Phòng (kèm tên khu vực)
        public DataTable LayPhong()
        {
            try
            {
                return Db.Query("SELECT p.SoPhong, k.TenKhuVuc, p.SoNguoiToiDa, p.DonGiaNgay, p.TrangThai FROM Phong p LEFT JOIN KhuVuc k ON p.MaKhuVuc = k.MaKhuVuc ORDER BY p.SoPhong");
            }
            catch
            {
                return Db.Query("SELECT * FROM Phong");
            }
        }

        // 2. Hàm lấy danh sách Tiện nghi
        public DataTable LayTienNghi()
        {
            try
            {
                return Db.Query("SELECT t.MaTienNghi, l.TenLoaiTN, t.SoThuTu, t.TinhTrangHienTai FROM TienNghi t LEFT JOIN LoaiTienNghi l ON t.MaLoaiTN = l.MaLoaiTN ORDER BY t.MaTienNghi");
            }
            catch
            {
                return Db.Query("SELECT * FROM TienNghi");
            }
        }

        // 3. Hàm lấy danh sách Phiếu Lắp đặt
        public DataTable LayLapDat()
        {
            try
            {
                return Db.Query("SELECT p.SoPhieu, p.MaTienNghi, p.SoPhong, p.NgayLap, p.TinhTrang, p.MaNV, p.GhiChu FROM PhieuLapDat p ORDER BY p.NgayLap DESC");
            }
            catch
            {
                return Db.Query("SELECT * FROM PhieuLapDat");
            }
        }

        // Các hàm alias để khớp hoàn toàn với các cách gọi khác nhau
        public DataTable LayDanhSachPhong() => LayPhong();
        public DataTable LayDanhSachTienNghi() => LayTienNghi();
        public DataTable LayDanhSachPhieuLapDat() => LayLapDat();

        // 4. Thêm Phòng
        public KetQuaXuLy ThemPhong(string so, string khu, int max, decimal gia)
        {
            if (string.IsNullOrWhiteSpace(so) || string.IsNullOrWhiteSpace(khu) || max <= 0 || gia < 0)
                return KetQuaXuLy.Fail("Thông tin phòng không hợp lệ.");
            try
            {
                Db.Execute("INSERT INTO Phong(SoPhong, MaKhuVuc, SoNguoiToiDa, DonGiaNgay, TrangThai) VALUES(@s, @k, @m, @g, N'Trống')",
                    new SqlParameter("@s", so),
                    new SqlParameter("@k", khu),
                    new SqlParameter("@m", max),
                    new SqlParameter("@g", gia));
                return KetQuaXuLy.Ok("Đã thêm phòng thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi thêm phòng: " + ex.Message);
            }
        }

        // 5. Thêm Tiện nghi
        public KetQuaXuLy ThemTienNghi(string ma, string loai, int stt, string tt)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(loai) || stt <= 0)
                return KetQuaXuLy.Fail("Thông tin tiện nghi không hợp lệ.");
            try
            {
                Db.Execute("INSERT INTO TienNghi(MaTienNghi, MaLoaiTN, SoThuTu, TinhTrangHienTai) VALUES(@m, @l, @s, @t)",
                    new SqlParameter("@m", ma),
                    new SqlParameter("@l", loai),
                    new SqlParameter("@s", stt),
                    new SqlParameter("@t", tt));
                return KetQuaXuLy.Ok("Đã thêm tiện nghi thành công.");
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi thêm tiện nghi: " + ex.Message);
            }
        }

        // 6. Lập phiếu Lắp đặt
        public KetQuaXuLy LapDat(string soPhieu, string maTN, string soPhong, DateTime ngay, string tinhTrang, string maNV, string ghiChu)
        {
            if (string.IsNullOrWhiteSpace(soPhieu) || string.IsNullOrWhiteSpace(maTN) || string.IsNullOrWhiteSpace(soPhong) || string.IsNullOrWhiteSpace(maNV))
                return KetQuaXuLy.Fail("Vui lòng điền đầy đủ thông tin phiếu lắp đặt.");
            try
            {
                Db.Execute("INSERT INTO PhieuLapDat(SoPhieu, MaTienNghi, SoPhong, NgayLap, TinhTrang, MaNV, GhiChu) VALUES(@p, @tn, @ph, @n, @tt, @nv, @g)",
                    new SqlParameter("@p", soPhieu),
                    new SqlParameter("@tn", maTN),
                    new SqlParameter("@ph", soPhong),
                    new SqlParameter("@n", ngay.Date),
                    new SqlParameter("@tt", tinhTrang ?? ""),
                    new SqlParameter("@nv", maNV),
                    new SqlParameter("@g", ghiChu ?? ""));

                Db.Execute("UPDATE TienNghi SET TinhTrangHienTai = @tt WHERE MaTienNghi = @m",
                    new SqlParameter("@tt", tinhTrang ?? ""),
                    new SqlParameter("@m", maTN));

                return KetQuaXuLy.Ok("Đã lập phiếu lắp đặt thành công.");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    return KetQuaXuLy.Fail("Mã phiếu này hoặc thiết bị đã tồn tại trong ngày chọn.");
                return KetQuaXuLy.Fail("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                return KetQuaXuLy.Fail("Lỗi: " + ex.Message);
            }
        }
    }
}