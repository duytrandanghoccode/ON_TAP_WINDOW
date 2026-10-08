namespace Bai2_ITSupportTicket;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;

    private Label lblTitle = null!;
    private GroupBox grpThongTin = null!;
    private Label lblMaPhieu = null!;
    private TextBox txtMaPhieu = null!;
    private Label lblNguoiYeuCau = null!;
    private TextBox txtNguoiYeuCau = null!;
    private Label lblNgay = null!;
    private DateTimePicker dtpNgayGhiNhan = null!;
    private GroupBox grpUuTien = null!;
    private RadioButton radThap = null!;
    private RadioButton radTrungBinh = null!;
    private RadioButton radKhanCap = null!;
    private GroupBox grpChiTiet = null!;
    private Label lblLoaiSuCo = null!;
    private ComboBox cboLoaiSuCo = null!;
    private Label lblThietBi = null!;
    private CheckBox chkMayTinhBan = null!;
    private CheckBox chkLaptop = null!;
    private CheckBox chkMayIn = null!;
    private CheckBox chkDienThoai = null!;
    private PictureBox picAnhLoi = null!;
    private Button btnTaiAnh = null!;
    private Button btnGuiYeuCau = null!;
    private Button btnNhapLai = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        grpThongTin = new GroupBox();
        lblMaPhieu = new Label();
        txtMaPhieu = new TextBox();
        lblNguoiYeuCau = new Label();
        txtNguoiYeuCau = new TextBox();
        lblNgay = new Label();
        dtpNgayGhiNhan = new DateTimePicker();
        grpUuTien = new GroupBox();
        radThap = new RadioButton();
        radTrungBinh = new RadioButton();
        radKhanCap = new RadioButton();
        grpChiTiet = new GroupBox();
        lblLoaiSuCo = new Label();
        cboLoaiSuCo = new ComboBox();
        lblThietBi = new Label();
        chkMayTinhBan = new CheckBox();
        chkLaptop = new CheckBox();
        chkMayIn = new CheckBox();
        chkDienThoai = new CheckBox();
        picAnhLoi = new PictureBox();
        btnTaiAnh = new Button();
        btnGuiYeuCau = new Button();
        btnNhapLai = new Button();

        SuspendLayout();

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.Location = new Point(165, 20);
        lblTitle.Text = "TIẾP NHẬN SỰ CỐ IT";

        grpThongTin.Location = new Point(25, 75);
        grpThongTin.Size = new Size(560, 205);
        grpThongTin.Text = "Thông tin phiếu";

        lblMaPhieu.Location = new Point(20, 35);
        lblMaPhieu.Size = new Size(115, 25);
        lblMaPhieu.Text = "Mã phiếu:";
        txtMaPhieu.Location = new Point(145, 32);
        txtMaPhieu.Size = new Size(380, 27);
        txtMaPhieu.TabIndex = 0;

        lblNguoiYeuCau.Location = new Point(20, 75);
        lblNguoiYeuCau.Size = new Size(115, 25);
        lblNguoiYeuCau.Text = "Người yêu cầu:";
        txtNguoiYeuCau.Location = new Point(145, 72);
        txtNguoiYeuCau.Size = new Size(380, 27);
        txtNguoiYeuCau.TabIndex = 1;

        lblNgay.Location = new Point(20, 115);
        lblNgay.Size = new Size(115, 25);
        lblNgay.Text = "Ngày ghi nhận:";
        dtpNgayGhiNhan.Location = new Point(145, 112);
        dtpNgayGhiNhan.Size = new Size(200, 27);
        dtpNgayGhiNhan.Format = DateTimePickerFormat.Short;
        dtpNgayGhiNhan.TabIndex = 2;

        grpUuTien.Location = new Point(20, 145);
        grpUuTien.Size = new Size(505, 50);
        grpUuTien.Text = "Mức độ ưu tiên";
        radThap.Location = new Point(20, 20);
        radThap.Size = new Size(80, 25);
        radThap.Text = "Thấp";
        radThap.TabIndex = 3;
        radTrungBinh.Location = new Point(150, 20);
        radTrungBinh.Size = new Size(110, 25);
        radTrungBinh.Text = "Trung bình";
        radTrungBinh.TabIndex = 4;
        radKhanCap.Location = new Point(320, 20);
        radKhanCap.Size = new Size(110, 25);
        radKhanCap.Text = "Khẩn cấp";
        radKhanCap.TabIndex = 5;

        grpUuTien.Controls.AddRange([radThap, radTrungBinh, radKhanCap]);
        grpThongTin.Controls.AddRange([
            lblMaPhieu, txtMaPhieu, lblNguoiYeuCau, txtNguoiYeuCau,
            lblNgay, dtpNgayGhiNhan, grpUuTien
        ]);

        grpChiTiet.Location = new Point(25, 295);
        grpChiTiet.Size = new Size(560, 290);
        grpChiTiet.Text = "Phân loại & chi tiết";

        lblLoaiSuCo.Location = new Point(20, 35);
        lblLoaiSuCo.Size = new Size(115, 25);
        lblLoaiSuCo.Text = "Loại sự cố:";
        cboLoaiSuCo.Location = new Point(145, 32);
        cboLoaiSuCo.Size = new Size(200, 28);
        cboLoaiSuCo.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLoaiSuCo.Items.AddRange(["Phần cứng", "Phần mềm", "Mạng", "Tài khoản"]);
        cboLoaiSuCo.TabIndex = 6;

        lblThietBi.Location = new Point(20, 80);
        lblThietBi.Size = new Size(125, 25);
        lblThietBi.Text = "Thiết bị ảnh hưởng:";
        chkMayTinhBan.Location = new Point(145, 78);
        chkMayTinhBan.Size = new Size(120, 25);
        chkMayTinhBan.Text = "Máy tính bàn";
        chkMayTinhBan.TabIndex = 7;
        chkLaptop.Location = new Point(280, 78);
        chkLaptop.Size = new Size(90, 25);
        chkLaptop.Text = "Laptop";
        chkLaptop.TabIndex = 8;
        chkMayIn.Location = new Point(145, 110);
        chkMayIn.Size = new Size(90, 25);
        chkMayIn.Text = "Máy in";
        chkMayIn.TabIndex = 9;
        chkDienThoai.Location = new Point(280, 110);
        chkDienThoai.Size = new Size(110, 25);
        chkDienThoai.Text = "Điện thoại";
        chkDienThoai.TabIndex = 10;

        picAnhLoi.BorderStyle = BorderStyle.FixedSingle;
        picAnhLoi.Location = new Point(145, 150);
        picAnhLoi.Size = new Size(200, 110);
        picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;

        btnTaiAnh.Location = new Point(365, 150);
        btnTaiAnh.Size = new Size(160, 40);
        btnTaiAnh.Text = "Tải ảnh lỗi";
        btnTaiAnh.TabIndex = 11;
        btnTaiAnh.Click += btnTaiAnh_Click;

        grpChiTiet.Controls.AddRange([
            lblLoaiSuCo, cboLoaiSuCo, lblThietBi,
            chkMayTinhBan, chkLaptop, chkMayIn, chkDienThoai,
            picAnhLoi, btnTaiAnh
        ]);

        btnGuiYeuCau.Location = new Point(160, 605);
        btnGuiYeuCau.Size = new Size(135, 42);
        btnGuiYeuCau.Text = "Gửi yêu cầu";
        btnGuiYeuCau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnGuiYeuCau.TabIndex = 12;
        btnGuiYeuCau.Click += btnGuiYeuCau_Click;

        btnNhapLai.Location = new Point(315, 605);
        btnNhapLai.Size = new Size(135, 42);
        btnNhapLai.Text = "Nhập lại";
        btnNhapLai.TabIndex = 13;
        btnNhapLai.Click += btnNhapLai_Click;

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(610, 675);
        Controls.AddRange([lblTitle, grpThongTin, grpChiTiet, btnGuiYeuCau, btnNhapLai]);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 2 - IT Support Ticket Form";
        ResumeLayout(false);
        PerformLayout();
    }
}
