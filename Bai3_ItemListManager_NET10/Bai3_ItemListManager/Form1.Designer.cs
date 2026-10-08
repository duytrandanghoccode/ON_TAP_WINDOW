namespace Bai3_ItemListManager;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitle = null!;
    private GroupBox grpNhap = null!;
    private Label lblMaVT = null!;
    private TextBox txtMaVT = null!;
    private Label lblTenVT = null!;
    private TextBox txtTenVT = null!;
    private Label lblDonVi = null!;
    private ComboBox cboDonViTinh = null!;
    private Label lblDonGia = null!;
    private TextBox txtDonGia = null!;
    private Button btnThemMoi = null!;
    private Button btnCapNhat = null!;
    private Button btnXoaDong = null!;
    private Button btnXoaTatCa = null!;
    private GroupBox grpDanhSach = null!;
    private ListView lvVatTu = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        grpNhap = new GroupBox();
        lblMaVT = new Label();
        txtMaVT = new TextBox();
        lblTenVT = new Label();
        txtTenVT = new TextBox();
        lblDonVi = new Label();
        cboDonViTinh = new ComboBox();
        lblDonGia = new Label();
        txtDonGia = new TextBox();
        btnThemMoi = new Button();
        btnCapNhat = new Button();
        btnXoaDong = new Button();
        btnXoaTatCa = new Button();
        grpDanhSach = new GroupBox();
        lvVatTu = new ListView();

        SuspendLayout();

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.Location = new Point(255, 20);
        lblTitle.Text = "QUẢN LÝ VẬT TƯ / LINH KIỆN";

        grpNhap.Location = new Point(20, 80);
        grpNhap.Size = new Size(320, 390);
        grpNhap.Text = "Thông tin vật tư";

        lblMaVT.Location = new Point(20, 40);
        lblMaVT.Size = new Size(100, 25);
        lblMaVT.Text = "Mã vật tư:";
        txtMaVT.Location = new Point(20, 65);
        txtMaVT.Size = new Size(275, 27);
        txtMaVT.TabIndex = 0;

        lblTenVT.Location = new Point(20, 110);
        lblTenVT.Size = new Size(100, 25);
        lblTenVT.Text = "Tên vật tư:";
        txtTenVT.Location = new Point(20, 135);
        txtTenVT.Size = new Size(275, 27);
        txtTenVT.TabIndex = 1;

        lblDonVi.Location = new Point(20, 180);
        lblDonVi.Size = new Size(100, 25);
        lblDonVi.Text = "Đơn vị tính:";
        cboDonViTinh.Location = new Point(20, 205);
        cboDonViTinh.Size = new Size(275, 28);
        cboDonViTinh.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDonViTinh.Items.AddRange(["Cái", "Bộ", "Kg", "Mét"]);
        cboDonViTinh.TabIndex = 2;

        lblDonGia.Location = new Point(20, 250);
        lblDonGia.Size = new Size(100, 25);
        lblDonGia.Text = "Đơn giá nhập:";
        txtDonGia.Location = new Point(20, 275);
        txtDonGia.Size = new Size(275, 27);
        txtDonGia.TabIndex = 3;

        btnThemMoi.Location = new Point(20, 325);
        btnThemMoi.Size = new Size(125, 40);
        btnThemMoi.Text = "Thêm mới";
        btnThemMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnThemMoi.TabIndex = 4;
        btnThemMoi.Click += btnThemMoi_Click;

        btnCapNhat.Location = new Point(170, 325);
        btnCapNhat.Size = new Size(125, 40);
        btnCapNhat.Text = "Cập nhật";
        btnCapNhat.TabIndex = 5;
        btnCapNhat.Click += btnCapNhat_Click;

        grpNhap.Controls.AddRange([
            lblMaVT, txtMaVT, lblTenVT, txtTenVT, lblDonVi, cboDonViTinh,
            lblDonGia, txtDonGia, btnThemMoi, btnCapNhat
        ]);

        grpDanhSach.Location = new Point(360, 80);
        grpDanhSach.Size = new Size(610, 390);
        grpDanhSach.Text = "Danh sách vật tư";

        lvVatTu.Location = new Point(15, 30);
        lvVatTu.Size = new Size(580, 345);
        lvVatTu.View = View.Details;
        lvVatTu.FullRowSelect = true;
        lvVatTu.GridLines = true;
        lvVatTu.HideSelection = false;
        lvVatTu.MultiSelect = false;
        lvVatTu.Columns.Add("Mã VT", 100);
        lvVatTu.Columns.Add("Tên VT", 210);
        lvVatTu.Columns.Add("Đơn vị tính", 110);
        lvVatTu.Columns.Add("Đơn giá", 130);
        lvVatTu.SelectedIndexChanged += lvVatTu_SelectedIndexChanged;
        grpDanhSach.Controls.Add(lvVatTu);

        btnXoaDong.Location = new Point(570, 490);
        btnXoaDong.Size = new Size(140, 42);
        btnXoaDong.Text = "Xóa dòng";
        btnXoaDong.TabIndex = 6;
        btnXoaDong.Click += btnXoaDong_Click;

        btnXoaTatCa.Location = new Point(730, 490);
        btnXoaTatCa.Size = new Size(140, 42);
        btnXoaTatCa.Text = "Xóa toàn bộ";
        btnXoaTatCa.TabIndex = 7;
        btnXoaTatCa.Click += btnXoaTatCa_Click;

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(990, 555);
        Controls.AddRange([lblTitle, grpNhap, grpDanhSach, btnXoaDong, btnXoaTatCa]);
        Font = new Font("Segoe UI", 10F);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 3 - Item List Manager";
        ResumeLayout(false);
        PerformLayout();
    }
}
