using System;
using System.Data.SqlClient;
using HotelManagement.DTO;

namespace HotelManagement.DAL
{
    public class KhachHangDAL
    {
        public KhachHangDTO TimTheoCCCD(string cccd)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT MaKH, HoTen, CCCD, SoDienThoai FROM KhachHang WHERE CCCD = @cccd";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@cccd", cccd);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new KhachHangDTO
                            {
                                MaKH = Convert.ToInt32(reader["MaKH"]),
                                HoTen = reader["HoTen"].ToString(),
                                CCCD = reader["CCCD"].ToString(),
                                SoDienThoai = reader["SoDienThoai"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public int ThemKhachHang(KhachHangDTO kh)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO KhachHang (HoTen, CCCD, SoDienThoai) VALUES (@hoTen, @cccd, @sdt); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@hoTen", kh.HoTen);
                    cmd.Parameters.AddWithValue("@cccd", kh.CCCD);
                    cmd.Parameters.AddWithValue("@sdt", kh.SoDienThoai ?? "");
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}