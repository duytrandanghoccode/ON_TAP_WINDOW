namespace Bai5_DeliveryOrderDashboard;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;

    private TabControl tabMain = null!;
    private TabPage tabDonHang = null!;
    private TabPage tabHuongDan = null!;
    private SplitContainer splitMain = null!;
    private GroupBox grpKhachHang = null!;
    private Label lblTenKH = null!;
    private TextBox txtTenKH = null!;
    private Label lblSDT = null!;
    private TextBox txtSDT = null!;
    private Label lblDiaChi = null!;
    private TextBox txtDiaChi = null!;
    private Label lblLoaiVC = null!;
    private ComboBox cboLoaiVanChuyen = null!;
    private Label lblHint = null!;
    private GroupBox grpHangHoa = null!;
    private DataGridView dgvHangHoa = null!;
    private Button btnThemDong = null!;
    private Button btnXoaDong = null!;
    private StatusStrip statusStrip = null!;
    private ToolStripStatusLabel tslClock = null!;
    private ToolStripStatusLabel tslSpacer = null!;
    private ToolStripStatusLabel tslTongSoLuong = null!;
    private ToolStripStatusLabel tslTongTrongLuong = null!;
    private ToolStripStatusLabel tslTongTien = null!;
    private ErrorProvider errorProvider = null!;
    private System.Windows.Forms.Timer timerClock = null!;
    private Label lblHuongDan = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        tabMain = new TabControl();
        tabDonHang = new TabPage();
        tabHuongDan = new TabPage();
        splitMain = new SplitContainer();
        grpKhachHang = new GroupBox();
        lblTenKH = new Label();
        txtTenKH = new TextBox();
        lblSDT = new Label();
        txtSDT = new TextBox();
        lblDiaChi = new Label();
        txtDiaChi = new TextBox();
        lblLoaiVC = new Label();
        cboLoaiVanChuyen = new ComboBox();
        lblHint = new Label();
        grpHangHoa = new GroupBox();
        dgvHangHoa = new DataGridView();
        btnThemDong = new Button();
        btnXoaDong = new Button();
        statusStrip = new StatusStrip();
        tslClock = new ToolStripStatusLabel();
        tslSpacer = new ToolStripStatusLabel();
        tslTongSoLuong = new ToolStripStatusLabel();
        tslTongTrongLuong = new ToolStripStatusLabel();
        tslTongTien = new ToolStripStatusLabel();
        errorProvider = new ErrorProvider(components);
        timerClock = new System.Windows.Forms.Timer(components);
        lblHuongDan = new Label();

        SuspendLayout();

        tabMain.Dock = DockStyle.Fill;
        tabMain.Controls.Add(tabDonHang);
        tabMain.Controls.Add(tabHuongDan);

        tabDonHang.Text = "Quản lý đơn giao hàng";
        tabDonHang.Padding = new Padding(8);

        splitMain.Dock = DockStyle.Fill;
        splitMain.SplitterDistance = 320;
        splitMain.FixedPanel = FixedPanel.Panel1;

        grpKhachHang.Dock = DockStyle.Fill;
        grpKhachHang.Text = "Thông tin khách hàng & vận chuyển";

        lblTenKH.Location = new Point(20, 40);
        lblTenKH.Size = new Size(150, 25);
        lblTenKH.Text = "Tên khách hàng:";
        txtTenKH.Location = new Point(20, 68);
        txtTenKH.Size = new Size(270, 27);

        lblSDT.Location = new Point(20, 115);
        lblSDT.Size = new Size(100, 25);
        lblSDT.Text = "Số điện thoại:";
        txtSDT.Location = new Point(20, 143);
        txtSDT.Size = new Size(270, 27);

        lblDiaChi.Location = new Point(20, 190);
        lblDiaChi.Size = new Size(100, 25);
        lblDiaChi.Text = "Địa chỉ:";
        txtDiaChi.Location = new Point(20, 218);
        txtDiaChi.Size = new Size(270, 90);
        txtDiaChi.Multiline = true;

        lblLoaiVC.Location = new Point(20, 330);
        lblLoaiVC.Size = new Size(140, 25);
        lblLoaiVC.Text = "Loại vận chuyển:";
        cboLoaiVanChuyen.Location = new Point(20, 358);
        cboLoaiVanChuyen.Size = new Size(270, 28);
        cboLoaiVanChuyen.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLoaiVanChuyen.Items.AddRange([
            "Tiêu chuẩn", "Nhanh", "Hỏa tốc"
        ]);

        lblHint.Location = new Point(20, 420);
        lblHint.Size = new Size(270, 110);
        lblHint.Text = "Phím tắt:\r\n• F2: Thêm nhanh dòng hàng\r\n• Delete: Xóa dòng đang chọn\r\n\r\nSố lượng và trọng lượng phải > 0.";

        grpKhachHang.Controls.AddRange([
            lblTenKH, txtTenKH, lblSDT, txtSDT, lblDiaChi, txtDiaChi,
            lblLoaiVC, cboLoaiVanChuyen, lblHint
        ]);
        splitMain.Panel1.Controls.Add(grpKhachHang);

        grpHangHoa.Dock = DockStyle.Fill;
        grpHangHoa.Text = "Chi tiết hàng hóa";

        dgvHangHoa.Location = new Point(15, 30);
        dgvHangHoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvHangHoa.Size = new Size(660, 470);
        dgvHangHoa.CellEndEdit += dgvHangHoa_CellEndEdit;
        dgvHangHoa.CellValueChanged += dgvHangHoa_CellValueChanged;
        dgvHangHoa.RowsRemoved += dgvHangHoa_RowsRemoved;
        dgvHangHoa.DataError += dgvHangHoa_DataError;

        btnThemDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnThemDong.Location = new Point(15, 515);
        btnThemDong.Size = new Size(145, 40);
        btnThemDong.Text = "Thêm dòng (F2)";
        btnThemDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnThemDong.Click += btnThemDong_Click;

        btnXoaDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnXoaDong.Location = new Point(175, 515);
        btnXoaDong.Size = new Size(150, 40);
        btnXoaDong.Text = "Xóa dòng (Delete)";
        btnXoaDong.Click += btnXoaDong_Click;

        grpHangHoa.Controls.AddRange([dgvHangHoa, btnThemDong, btnXoaDong]);
        splitMain.Panel2.Controls.Add(grpHangHoa);

        tabDonHang.Controls.Add(splitMain);

        lblHuongDan.Dock = DockStyle.Fill;
        lblHuongDan.Padding = new Padding(30);
        lblHuongDan.Font = new Font("Segoe UI", 11F);
        lblHuongDan.Text =
            "BÀI 5 - DELIVERY ORDER DASHBOARD\r\n\r\n" +
            "1. Nhập thông tin khách hàng ở cột bên trái.\r\n" +
            "2. Nhấn F2 hoặc nút Thêm dòng để thêm hàng hóa.\r\n" +
            "3. Nhập Tên hàng, Số lượng, Trọng lượng, Đơn giá.\r\n" +
            "4. Thành tiền và StatusStrip tự động cập nhật.\r\n" +
            "5. Số lượng hoặc Trọng lượng <= 0 sẽ báo lỗi.\r\n" +
            "6. Chọn dòng và nhấn Delete để xóa.";
        tabHuongDan.Text = "Hướng dẫn";
        tabHuongDan.Controls.Add(lblHuongDan);

        statusStrip.Items.AddRange([
            tslClock, tslSpacer, tslTongSoLuong, tslTongTrongLuong, tslTongTien
        ]);
        statusStrip.Dock = DockStyle.Bottom;

        tslClock.Text = "00/00/0000 00:00:00";
        tslSpacer.Spring = true;
        tslTongSoLuong.Text = "Tổng SL: 0";
        tslTongTrongLuong.Text = "Tổng TL: 0 kg";
        tslTongTien.Text = "Tổng tiền: 0 VNĐ";

        errorProvider.ContainerControl = this;
        timerClock.Interval = 1000;
        timerClock.Tick += timerClock_Tick;

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1080, 650);
        Controls.Add(tabMain);
        Controls.Add(statusStrip);
        Font = new Font("Segoe UI", 10F);
        KeyPreview = true;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 5 - Delivery Order Dashboard";
        Load += Form1_Load;
        KeyDown += Form1_KeyDown;

        ResumeLayout(false);
        PerformLayout();
    }
}
