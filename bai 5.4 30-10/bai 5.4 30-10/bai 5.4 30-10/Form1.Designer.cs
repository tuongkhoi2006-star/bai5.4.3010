namespace HotelManagement
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.cbLocLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbLocTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCheckIn = new System.Windows.Forms.GroupBox();
            this.lblPhongDangChon = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnTraCuuCCCD = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDichVu = new System.Windows.Forms.GroupBox();
            this.btnDatDichVu = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbDichVu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpCheckOut = new System.Windows.Forms.GroupBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnHoanTatDonDep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.grpCheckIn.SuspendLayout();
            this.grpDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.grpCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(12, 57);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(460, 420);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // cbLocLoaiPhong
            // 
            this.cbLocLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocLoaiPhong.FormattingEnabled = true;
            this.cbLocLoaiPhong.Location = new System.Drawing.Point(82, 18);
            this.cbLocLoaiPhong.Name = "cbLocLoaiPhong";
            this.cbLocLoaiPhong.Size = new System.Drawing.Size(121, 21);
            this.cbLocLoaiPhong.TabIndex = 1;
            this.cbLocLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.BoLoc_SelectedIndexChanged);
            // 
            // cbLocTrangThai
            // 
            this.cbLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocTrangThai.FormattingEnabled = true;
            this.cbLocTrangThai.Location = new System.Drawing.Point(286, 18);
            this.cbLocTrangThai.Name = "cbLocTrangThai";
            this.cbLocTrangThai.Size = new System.Drawing.Size(121, 21);
            this.cbLocTrangThai.TabIndex = 2;
            this.cbLocTrangThai.SelectedIndexChanged += new System.EventHandler(this.BoLoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loại phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trạng thái:";
            // 
            // grpCheckIn
            // 
            this.grpCheckIn.Controls.Add(this.lblPhongDangChon);
            this.grpCheckIn.Controls.Add(this.label7);
            this.grpCheckIn.Controls.Add(this.btnCheckIn);
            this.grpCheckIn.Controls.Add(this.btnTraCuuCCCD);
            this.grpCheckIn.Controls.Add(this.txtSDT);
            this.grpCheckIn.Controls.Add(this.txtHoTen);
            this.grpCheckIn.Controls.Add(this.txtCCCD);
            this.grpCheckIn.Controls.Add(this.label5);
            this.grpCheckIn.Controls.Add(this.label4);
            this.grpCheckIn.Controls.Add(this.label3);
            this.grpCheckIn.Location = new System.Drawing.Point(488, 18);
            this.grpCheckIn.Name = "grpCheckIn";
            this.grpCheckIn.Size = new System.Drawing.Size(384, 160);
            this.grpCheckIn.TabIndex = 5;
            this.grpCheckIn.TabStop = false;
            this.grpCheckIn.Text = "1. Nhận phòng (Check-in)";
            // 
            // lblPhongDangChon
            // 
            this.lblPhongDangChon.AutoSize = true;
            this.lblPhongDangChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongDangChon.ForeColor = System.Drawing.Color.Red;
            this.lblPhongDangChon.Location = new System.Drawing.Point(92, 126);
            this.lblPhongDangChon.Name = "lblPhongDangChon";
            this.lblPhongDangChon.Size = new System.Drawing.Size(79, 15);
            this.lblPhongDangChon.TabIndex = 9;
            this.lblPhongDangChon.Text = "(Chưa chọn)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phòng chọn:";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.LightGreen;
            this.btnCheckIn.Location = new System.Drawing.Point(234, 118);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(135, 32);
            this.btnCheckIn.TabIndex = 7;
            this.btnCheckIn.Text = "Xác nhận Check-in";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnTraCuuCCCD
            // 
            this.btnTraCuuCCCD.Location = new System.Drawing.Point(267, 21);
            this.btnTraCuuCCCD.Name = "btnTraCuuCCCD";
            this.btnTraCuuCCCD.Size = new System.Drawing.Size(102, 23);
            this.btnTraCuuCCCD.TabIndex = 6;
            this.btnTraCuuCCCD.Text = "Tra cứu CCCD";
            this.btnTraCuuCCCD.UseVisualStyleBackColor = true;
            this.btnTraCuuCCCD.Click += new System.EventHandler(this.btnTraCuuCCCD_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(95, 84);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(166, 20);
            this.txtSDT.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(95, 53);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(166, 20);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(95, 23);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(166, 20);
            this.txtCCCD.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CCCD:";
            // 
            // grpDichVu
            // 
            this.grpDichVu.Controls.Add(this.btnDatDichVu);
            this.grpDichVu.Controls.Add(this.numSoLuong);
            this.grpDichVu.Controls.Add(this.cbDichVu);
            this.grpDichVu.Controls.Add(this.label8);
            this.grpDichVu.Controls.Add(this.label6);
            this.grpDichVu.Location = new System.Drawing.Point(488, 184);
            this.grpDichVu.Name = "grpDichVu";
            this.grpDichVu.Size = new System.Drawing.Size(384, 94);
            this.grpDichVu.TabIndex = 6;
            this.grpDichVu.TabStop = false;
            this.grpDichVu.Text = "2. Gọi Dịch Vụ Cho Phòng Đang Ở";
            // 
            // btnDatDichVu
            // 
            this.btnDatDichVu.Location = new System.Drawing.Point(234, 53);
            this.btnDatDichVu.Name = "btnDatDichVu";
            this.btnDatDichVu.Size = new System.Drawing.Size(135, 28);
            this.btnDatDichVu.TabIndex = 4;
            this.btnDatDichVu.Text = "Thêm Dịch Vụ";
            this.btnDatDichVu.UseVisualStyleBackColor = true;
            this.btnDatDichVu.Click += new System.EventHandler(this.btnDatDichVu_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(95, 57);
            this.numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(65, 20);
            this.numSoLuong.TabIndex = 3;
            this.numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbDichVu
            // 
            this.cbDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDichVu.FormattingEnabled = true;
            this.cbDichVu.Location = new System.Drawing.Point(95, 25);
            this.cbDichVu.Name = "cbDichVu";
            this.cbDichVu.Size = new System.Drawing.Size(274, 21);
            this.cbDichVu.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chọn dịch vụ:";
            // 
            // grpCheckOut
            // 
            this.grpCheckOut.Controls.Add(this.btnCheckOut);
            this.grpCheckOut.Controls.Add(this.lblHoaDon);
            this.grpCheckOut.Controls.Add(this.btnTinhTien);
            this.grpCheckOut.Location = new System.Drawing.Point(488, 284);
            this.grpCheckOut.Name = "grpCheckOut";
            this.grpCheckOut.Size = new System.Drawing.Size(384, 193);
            this.grpCheckOut.TabIndex = 7;
            this.grpCheckOut.TabStop = false;
            this.grpCheckOut.Text = "3. Trả phòng & Xuất Hóa Đơn (Transaction)";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Salmon;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(18, 145);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(351, 35);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "XÁC NHẬN THANH TOÁN (CHECK-OUT)";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.BackColor = System.Drawing.Color.LightYellow;
            this.lblHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHoaDon.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.Location = new System.Drawing.Point(18, 55);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(351, 80);
            this.lblHoaDon.TabIndex = 1;
            this.lblHoaDon.Text = "Hóa đơn:";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(18, 22);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(166, 26);
            this.btnTinhTien.TabIndex = 0;
            this.btnTinhTien.Text = "Xem Tiền Tạm Tính";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnHoanTatDonDep
            // 
            this.btnHoanTatDonDep.Location = new System.Drawing.Point(12, 483);
            this.btnHoanTatDonDep.Name = "btnHoanTatDonDep";
            this.btnHoanTatDonDep.Size = new System.Drawing.Size(240, 27);
            this.btnHoanTatDonDep.TabIndex = 8;
            this.btnHoanTatDonDep.Text = "Đã dọn xong phòng -> Chuyển về \"Trống\"";
            this.btnHoanTatDonDep.UseVisualStyleBackColor = true;
            this.btnHoanTatDonDep.Click += new System.EventHandler(this.btnHoanTatDonDep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.btnHoanTatDonDep);
            this.Controls.Add(this.grpCheckOut);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.grpCheckIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLocTrangThai);
            this.Controls.Add(this.cbLocLoaiPhong);
            this.Controls.Add(this.dgvPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Tiện Ích Dịch Vụ & Khách Sạn (3-Tier)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.grpCheckIn.ResumeLayout(false);
            this.grpCheckIn.PerformLayout();
            this.grpDichVu.ResumeLayout(false);
            this.grpDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.grpCheckOut.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.ComboBox cbLocLoaiPhong;
        private System.Windows.Forms.ComboBox cbLocTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpCheckIn;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTraCuuCCCD;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lblPhongDangChon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpDichVu;
        private System.Windows.Forms.Button btnDatDichVu;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.ComboBox cbDichVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpCheckOut;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnHoanTatDonDep;
    }
}