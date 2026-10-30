using System.Data;
using System.Data.SqlClient;

namespace HotelManagement.DAL
{
    public class PhongDAL
    {
        public DataTable LayDanhSachPhongDataTable()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                string sql = "SELECT SoPhong, LoaiPhong, GiaTheoGio, TrangThai FROM Phong";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void CapNhatTrangThai(string soPhong, string trangThai)
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE Phong SET TrangThai = @trangThai WHERE SoPhong = @soPhong";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);
                    cmd.Parameters.AddWithValue("@soPhong", soPhong);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}