using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelManagement.DTO;

namespace HotelManagement.DAL
{
    public class DichVuDAL
    {
        public List<DichVuDTO> LayTatCaDichVu()
        {
            List<DichVuDTO> list = new List<DichVuDTO>();
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT MaDV, TenDV, DonGia FROM DichVu";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new DichVuDTO
                        {
                            MaDV = Convert.ToInt32(r["MaDV"]),
                            TenDV = r["TenDV"].ToString(),
                            DonGia = Convert.ToDecimal(r["DonGia"])
                        });
                    }
                }
            }
            return list;
        }
    }
}