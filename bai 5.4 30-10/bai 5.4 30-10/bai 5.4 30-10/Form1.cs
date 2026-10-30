using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using HotelManagement.BUS;
using HotelManagement.DTO;

namespace HotelManagement
{
    public partial class Form1 : Form
    {
        private PhongBUS phongBUS = new PhongBUS();
        private KhachHangBUS khachHangBUS = new KhachHangBUS();
        private DichVuBUS dichVuBUS = new DichVuBUS();
        private PhieuDatBUS phieuDatBUS = new PhieuDatBUS();

        private DataTable dtPhong;
        private string phongChon = "";
        private string trangThaiPhongChon = "";
        private decimal giaTheoGioChon = 0;
        private int maKHChon = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập ComboBox lọc
            cbLocLoaiPhong.Items.AddRange(new object[] { "Tất cả", "Đơn", "Đôi", "VIP" });
            cbLocLoaiPhong.SelectedIndex = 0;

            cbLocTrangThai.Items.AddRange(new object[] { "Tất cả", "Trống", "Đang ở", "Đang dọn dẹp" });
            cbLocTrangThai.SelectedIndex = 0;

            TaiDanhSachPhong();
            TaiDanhSachDichVu();
        }

        private void TaiDanhSachPhong()
        {
            dtPhong = phongBUS.LayDanhSachPhongDataTable();
            dgvPhong.DataSource = dtPhong;
            BoLoc_SelectedIndexChanged(null, null);
        }

        private void TaiDanhSachDichVu()
        {
            List<DichVuDTO> list = dichVuBUS.LayTatCaDichVu();
            cbDichVu.DataSource = list;
            cbDichVu.DisplayMember = "TenDV";
            cbDichVu.ValueMember = "MaDV";
        }

        // LỌC NGẮT KẾT NỐI BẰNG DATAVIEW
        private void BoLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtPhong == null) return;
            DataView dv = dtPhong.DefaultView;
            List<string> filterList = new List<string>();

            if (cbLocLoaiPhong.SelectedIndex > 0)
                filterList.Add($"LoaiPhong = '{cbLocLoaiPhong.SelectedItem}'");

            if (cbLocTrangThai.SelectedIndex > 0)
                filterList.Add($"TrangThai = '{cbLocTrangThai.SelectedItem}'");

            dv.RowFilter = string.Join(" AND ", filterList);
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhong.Rows[e.RowIndex];
                phongChon = row.Cells["SoPhong"].Value.ToString();
                trangThaiPhongChon = row.Cells["TrangThai"].Value.ToString();
                giaTheoGioChon = Convert.ToDecimal(row.Cells["GiaTheoGio"].Value);

                lblPhongDangChon.Text = $"{phongChon} ({trangThaiPhongChon})";
                lblHoaDon.Text = "Hóa đơn:";
            }
        }

        // 1. CHECK-IN
        private void btnTraCuuCCCD_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();
            if (string.IsNullOrEmpty(cccd))
            {
                MessageBox.Show("Vui lòng nhập CCCD!", "Thông báo");
                return;
            }

            KhachHangDTO kh = khachHangBUS.TimTheoCCCD(cccd);
            if (kh != null)
            {
                maKHChon = kh.MaKH;
                txtHoTen.Text = kh.HoTen;
                txtSDT.Text = kh.SoDienThoai;
                MessageBox.Show("Tìm thấy khách hàng thân quen!", "Thông tin");
            }
            else
            {
                maKHChon = 0;
                MessageBox.Show("Khách hàng mới! Vui lòng điền Họ tên và SĐT.", "Thông tin");
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phongChon))
            {
                MessageBox.Show("Vui lòng chọn một phòng trong danh sách!", "Lỗi");
                return;
            }

            if (trangThaiPhongChon != "Trống")
            {
                MessageBox.Show($"Phòng {phongChon} hiện tại đang '{trangThaiPhongChon}', không thể check-in!", "Cảnh báo");
                return;
            }

            if (string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách!", "Thiếu thông tin");
                return;
            }

            try
            {
                // Nếu khách mới -> Thêm vào DB
                if (maKHChon == 0)
                {
                    KhachHangDTO khMoi = new KhachHangDTO
                    {
                        CCCD = txtCCCD.Text.Trim(),
                        HoTen = txtHoTen.Text.Trim(),
                        SoDienThoai = txtSDT.Text.Trim()
                    };
                    maKHChon = khachHangBUS.ThemKhachHang(khMoi);
                }

                // Thực hiện Check-in
                phieuDatBUS.ThucHienCheckIn(phongChon, maKHChon);
                MessageBox.Show($"Check-in thành công cho phòng {phongChon}!", "Thành công");

                TaiDanhSachPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi check-in: " + ex.Message);
            }
        }

        // 2. GỌI DỊCH VỤ
        private void btnDatDichVu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phongChon))
            {
                MessageBox.Show("Vui lòng chọn phòng đang có khách ở!");
                return;
            }

            if (trangThaiPhongChon != "Đang ở")
            {
                MessageBox.Show("Chỉ phòng 'Đang ở' mới có thể đặt dịch vụ!", "Thông báo");
                return;
            }

            PhieuDatPhongDTO phieu = phieuDatBUS.LayPhieuDangO(phongChon);
            if (phieu == null)
            {
                MessageBox.Show("Không tìm thấy thông tin phiếu đặt phòng!", "Lỗi");
                return;
            }

            int maDV = Convert.ToInt32(cbDichVu.SelectedValue);
            int soLuong = (int)numSoLuong.Value;

            try
            {
                phieuDatBUS.GoiDichVu(phieu.MaPhieu, maDV, soLuong);
                MessageBox.Show($"Đã thêm dịch vụ cho phòng {phongChon}!", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gọi dịch vụ: " + ex.Message);
            }
        }

        // 3. TÍNH TIỀN & CHECK-OUT (TRANSACTION)
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phongChon) || trangThaiPhongChon != "Đang ở")
            {
                MessageBox.Show("Vui lòng chọn phòng 'Đang ở' để tính tiền!");
                return;
            }

            PhieuDatPhongDTO phieu = phieuDatBUS.LayPhieuDangO(phongChon);
            if (phieu == null) return;

            DateTime bayGio = DateTime.Now;
            int soGio;
            decimal tienPhong, tienDV;
            decimal tong = phieuDatBUS.TinhTien(phieu, giaTheoGioChon, bayGio, out soGio, out tienPhong, out tienDV);

            lblHoaDon.Text = $"[HÓA ĐƠN PHÒNG {phongChon}]\n" +
                             $"- Thời gian ở: {soGio} giờ x {giaTheoGioChon:#,##0} đ = {tienPhong:#,##0} đ\n" +
                             $"- Tiền dịch vụ: {tienDV:#,##0} đ\n" +
                             $"=> TỔNG TIỀN: {tong:#,##0} VNĐ";
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phongChon) || trangThaiPhongChon != "Đang ở")
            {
                MessageBox.Show("Vui lòng chọn phòng 'Đang ở' để trả phòng!");
                return;
            }

            PhieuDatPhongDTO phieu = phieuDatBUS.LayPhieuDangO(phongChon);
            if (phieu == null) return;

            DateTime ngayTra = DateTime.Now;
            int soGio;
            decimal tienPhong, tienDV;
            decimal tong = phieuDatBUS.TinhTien(phieu, giaTheoGioChon, ngayTra, out soGio, out tienPhong, out tienDV);

            DialogResult dr = MessageBox.Show($"Xác nhận thanh toán hóa đơn {tong:#,##0} VNĐ và trả phòng {phongChon}?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    // Chạy Transaction
                    phieuDatBUS.ThucHienCheckOut(phieu.MaPhieu, phongChon, tong, ngayTra);
                    MessageBox.Show("Thanh toán thành công! Phòng đã chuyển sang trạng thái 'Đang dọn dẹp'.", "Hoàn tất");

                    TaiDanhSachPhong();
                    lblHoaDon.Text = "Hóa đơn:";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thanh toán: " + ex.Message);
                }
            }
        }

        private void btnHoanTatDonDep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phongChon) || trangThaiPhongChon != "Đang dọn dẹp")
            {
                MessageBox.Show("Vui lòng chọn một phòng đang ở trạng thái 'Đang dọn dẹp'!");
                return;
            }

            phongBUS.ChuyenSangDonDepXong(phongChon);
            MessageBox.Show($"Phòng {phongChon} đã sẵn sàng đón khách mới!", "Thông báo");
            TaiDanhSachPhong();
        }
    }
}