namespace Bai4_InteractiveSlotBooking;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitle = null!;
    private TableLayoutPanel tableSeats = null!;
    private GroupBox grpThongKe = null!;
    private Label lblKhungGio = null!;
    private ComboBox cboKhungGio = null!;
    private Label lblSoViTri = null!;
    private Label lblSoViTriValue = null!;
    private Label lblTamTinh = null!;
    private Label lblTamTinhValue = null!;
    private Label lblChuThich = null!;
    private Button btnXacNhanDat = null!;
    private Button btnHuyChon = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        tableSeats = new TableLayoutPanel();
        grpThongKe = new GroupBox();
        lblKhungGio = new Label();
        cboKhungGio = new ComboBox();
        lblSoViTri = new Label();
        lblSoViTriValue = new Label();
        lblTamTinh = new Label();
        lblTamTinhValue = new Label();
        lblChuThich = new Label();
        btnXacNhanDat = new Button();
        btnHuyChon = new Button();

        SuspendLayout();

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.Location = new Point(250, 18);
        lblTitle.Text = "SƠ ĐỒ CHỌN VỊ TRÍ / ĐẶT BÀN";

        tableSeats.Location = new Point(25, 80);
        tableSeats.Size = new Size(650, 420);
        tableSeats.ColumnCount = 5;
        tableSeats.RowCount = 4;
        for (int i = 0; i < 5; i++)
            tableSeats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        for (int i = 0; i < 4; i++)
            tableSeats.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        tableSeats.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

        grpThongKe.Location = new Point(700, 80);
        grpThongKe.Size = new Size(285, 320);
        grpThongKe.Text = "Thống kê";

        lblKhungGio.Location = new Point(20, 40);
        lblKhungGio.Size = new Size(100, 25);
        lblKhungGio.Text = "Khung giờ:";
        cboKhungGio.Location = new Point(20, 68);
        cboKhungGio.Size = new Size(240, 28);
        cboKhungGio.DropDownStyle = ComboBoxStyle.DropDownList;
        cboKhungGio.Items.AddRange(["Sáng - 100.000đ", "Tối - 150.000đ"]);
        cboKhungGio.SelectedIndexChanged += cboKhungGio_SelectedIndexChanged;

        lblSoViTri.Location = new Point(20, 125);
        lblSoViTri.Size = new Size(165, 25);
        lblSoViTri.Text = "Số vị trí đang chọn:";
        lblSoViTriValue.Location = new Point(200, 125);
        lblSoViTriValue.Size = new Size(60, 25);
        lblSoViTriValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblSoViTriValue.Text = "0";
        lblSoViTriValue.TextAlign = ContentAlignment.MiddleRight;

        lblTamTinh.Location = new Point(20, 170);
        lblTamTinh.Size = new Size(100, 25);
        lblTamTinh.Text = "Tạm tính:";
        lblTamTinhValue.Location = new Point(110, 170);
        lblTamTinhValue.Size = new Size(150, 25);
        lblTamTinhValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTamTinhValue.Text = "0 VNĐ";
        lblTamTinhValue.TextAlign = ContentAlignment.MiddleRight;

        lblChuThich.Location = new Point(20, 220);
        lblChuThich.Size = new Size(240, 75);
        lblChuThich.Text = "Chú thích:\r\n• Xám: Trống\r\n• Xanh lá: Đang chọn\r\n• Đỏ: Đã đặt";

        grpThongKe.Controls.AddRange([
            lblKhungGio, cboKhungGio, lblSoViTri, lblSoViTriValue,
            lblTamTinh, lblTamTinhValue, lblChuThich
        ]);

        btnXacNhanDat.Location = new Point(720, 430);
        btnXacNhanDat.Size = new Size(120, 45);
        btnXacNhanDat.Text = "Xác nhận đặt";
        btnXacNhanDat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnXacNhanDat.Click += btnXacNhanDat_Click;

        btnHuyChon.Location = new Point(855, 430);
        btnHuyChon.Size = new Size(120, 45);
        btnHuyChon.Text = "Hủy chọn tất cả";
        btnHuyChon.Click += btnHuyChon_Click;

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1010, 530);
        Controls.AddRange([lblTitle, tableSeats, grpThongKe, btnXacNhanDat, btnHuyChon]);
        Font = new Font("Segoe UI", 10F);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 4 - Interactive Slot Booking";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }
}
