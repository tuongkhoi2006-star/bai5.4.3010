using HotelManagement.DAL;
using HotelManagement.DTO;

namespace HotelManagement.BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAL dal = new KhachHangDAL();

        public KhachHangDTO TimTheoCCCD(string cccd)
        {
            return dal.TimTheoCCCD(cccd);
        }

        public int ThemKhachHang(KhachHangDTO kh)
        {
            return dal.ThemKhachHang(kh);
        }
    }
}