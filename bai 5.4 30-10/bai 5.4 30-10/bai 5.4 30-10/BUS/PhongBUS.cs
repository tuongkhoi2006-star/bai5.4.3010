using System.Data;
using HotelManagement.DAL;

namespace HotelManagement.BUS
{
    public class PhongBUS
    {
        private PhongDAL dal = new PhongDAL();

        public DataTable LayDanhSachPhongDataTable()
        {
            return dal.LayDanhSachPhongDataTable();
        }

        public void ChuyenSangDonDepXong(string soPhong)
        {
            dal.CapNhatTrangThai(soPhong, "Trống");
        }
    }
}