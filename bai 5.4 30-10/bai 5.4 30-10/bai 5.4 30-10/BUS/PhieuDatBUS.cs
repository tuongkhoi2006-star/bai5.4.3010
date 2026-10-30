using System;
using HotelManagement.DAL;
using HotelManagement.DTO;

namespace HotelManagement.BUS
{
    public class PhieuDatBUS
    {
        private PhieuDatDAL dal = new PhieuDatDAL();

        public PhieuDatPhongDTO LayPhieuDangO(string soPhong)
        {
            return dal.LayPhieuDangOTheoPhong(soPhong);
        }

        public void ThucHienCheckIn(string soPhong, int maKH)
        {
            dal.CheckIn(soPhong, maKH);
        }

        public void GoiDichVu(int maPhieu, int maDV, int soLuong)
        {
            dal.ThemSuDungDichVu(maPhieu, maDV, soLuong);
        }

        public decimal TinhTien(PhieuDatPhongDTO phieu, decimal giaTheoGio, DateTime ngayTra, out int soGio, out decimal tienPhong, out decimal tienDV)
        {
            TimeSpan duration = ngayTra - phieu.NgayNhanPhong;
            soGio = (int)Math.Ceiling(duration.TotalHours);
            if (soGio <= 0) soGio = 1; // Tối thiểu tính 1 giờ

            tienPhong = soGio * giaTheoGio;
            tienDV = dal.LayTongTienDichVu(phieu.MaPhieu);
            return tienPhong + tienDV;
        }

        public void ThucHienCheckOut(int maPhieu, string soPhong, decimal tongTien, DateTime ngayTra)
        {
            dal.CheckOutTransaction(maPhieu, soPhong, tongTien, ngayTra);
        }
    }
}