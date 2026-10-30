using System.Collections.Generic;
using HotelManagement.DAL;
using HotelManagement.DTO;

namespace HotelManagement.BUS
{
    public class DichVuBUS
    {
        private DichVuDAL dal = new DichVuDAL();

        public List<DichVuDTO> LayTatCaDichVu()
        {
            return dal.LayTatCaDichVu();
        }
    }
}