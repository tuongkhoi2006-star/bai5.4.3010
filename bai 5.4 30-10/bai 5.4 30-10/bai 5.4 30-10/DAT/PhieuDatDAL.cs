using System;
using System.Data.SqlClient;
using HotelManagement.DTO;

namespace HotelManagement.DAL
{
    public class PhieuDatDAL
    {
        public PhieuDatPhongDTO LayPhieuDangOTheoPhong(string soPhong)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT TOP 1 * FROM PhieuDatPhong WHERE SoPhong = @soPhong AND NgayTraPhong IS NULL ORDER BY MaPhieu DESC";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@soPhong", soPhong);
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return new PhieuDatPhongDTO
                            {
                                MaPhieu = Convert.ToInt32(r["MaPhieu"]),
                                SoPhong = r["SoPhong"].ToString(),
                                MaKH = Convert.ToInt32(r["MaKH"]),
                                NgayNhanPhong = Convert.ToDateTime(r["NgayNhanPhong"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void CheckIn(string soPhong, int maKH)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Tạo phiếu đặt phòng
                        string sqlInsert = "INSERT INTO PhieuDatPhong (SoPhong, MaKH, NgayNhanPhong) VALUES (@soPhong, @maKH, GETDATE())";
                        using (SqlCommand cmd1 = new SqlCommand(sqlInsert, conn, trans))
                        {
                            cmd1.Parameters.AddWithValue("@soPhong", soPhong);
                            cmd1.Parameters.AddWithValue("@maKH", maKH);
                            cmd1.ExecuteNonQuery();
                        }

                        // 2. Cập nhật phòng -> 'Đang ở'
                        string sqlUpdate = "UPDATE Phong SET TrangThai = N'Đang ở' WHERE SoPhong = @soPhong";
                        using (SqlCommand cmd2 = new SqlCommand(sqlUpdate, conn, trans))
                        {
                            cmd2.Parameters.AddWithValue("@soPhong", soPhong);
                            cmd2.ExecuteNonQuery();
                        }

                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        public void ThemSuDungDichVu(int maPhieu, int maDV, int soLuong)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO SuDungDichVu (MaPhieu, MaDV, SoLuong, ThoiGian) VALUES (@maPhieu, @maDV, @soLuong, GETDATE())";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maPhieu", maPhieu);
                    cmd.Parameters.AddWithValue("@maDV", maDV);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public decimal LayTongTienDichVu(int maPhieu)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT ISNULL(SUM(sd.SoLuong * dv.DonGia), 0)
                               FROM SuDungDichVu sd
                               JOIN DichVu dv ON sd.MaDV = dv.MaDV
                               WHERE sd.MaPhieu = @maPhieu";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maPhieu", maPhieu);
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }

        // TRANSACTION CHO CHECK-OUT
        public void CheckOutTransaction(int maPhieu, string soPhong, decimal tongTien, DateTime ngayTra)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Cập nhật hóa đơn
                        string sqlPhieu = "UPDATE PhieuDatPhong SET NgayTraPhong = @ngayTra, TongTienThanhToan = @tongTien WHERE MaPhieu = @maPhieu";
                        using (SqlCommand cmd1 = new SqlCommand(sqlPhieu, conn, trans))
                        {
                            cmd1.Parameters.AddWithValue("@ngayTra", ngayTra);
                            cmd1.Parameters.AddWithValue("@tongTien", tongTien);
                            cmd1.Parameters.AddWithValue("@maPhieu", maPhieu);
                            cmd1.ExecuteNonQuery();
                        }

                        // 2. Đổi trạng thái sang 'Đang dọn dẹp'
                        string sqlPhong = "UPDATE Phong SET TrangThai = N'Đang dọn dẹp' WHERE SoPhong = @soPhong";
                        using (SqlCommand cmd2 = new SqlCommand(sqlPhong, conn, trans))
                        {
                            cmd2.Parameters.AddWithValue("@soPhong", soPhong);
                            cmd2.ExecuteNonQuery();
                        }

                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}