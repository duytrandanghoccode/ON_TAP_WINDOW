using System;
using System.Drawing;
using System.Windows.Forms;

namespace ÔN_TẬP_WINDOW_FORM
{
    public partial class Form1 : Form
    {
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtGiamGia;
        private Label lblTongTien;
        private Button btnTinhTien;
        private Button btnLamMoi;

        public Form1()
        {
            InitializeComponent();
            TaoGiaoDien();
        }

        private void TaoGiaoDien()
        {
            this.Text = "Máy tính tính cước dịch vụ & Giảm giá";
            this.Size = new Size(420, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lbl1 = new Label() { Text = "Đơn giá dịch vụ:", Location = new Point(30, 25), AutoSize = true };
            Label lbl2 = new Label() { Text = "Số lượng khách:", Location = new Point(30, 65), AutoSize = true };
            Label lbl3 = new Label() { Text = "% Giảm giá:", Location = new Point(30, 105), AutoSize = true };

            txtDonGia = new TextBox() { Location = new Point(150, 22), Size = new Size(200, 25) };
            txtSoLuong = new TextBox() { Location = new Point(150, 62), Size = new Size(200, 25) };
            txtGiamGia = new TextBox() { Location = new Point(150, 102), Size = new Size(200, 25) };

            btnTinhTien = new Button() { Text = "Tính tiền", Location = new Point(150, 145), Size = new Size(95, 30) };
            btnLamMoi = new Button() { Text = "Làm mới", Location = new Point(255, 145), Size = new Size(95, 30) };

            lblTongTien = new Label()
            {
                Text = "Tổng tiền thanh toán: 0 VNĐ",
                Location = new Point(30, 195),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            btnTinhTien.Click += BtnTinhTien_Click;
            btnLamMoi.Click += BtnLamMoi_Click;

            this.Controls.Clear();
            this.Controls.AddRange(new Control[] {
                lbl1, lbl2, lbl3,
                txtDonGia, txtSoLuong, txtGiamGia,
                btnTinhTien, btnLamMoi, lblTongTien
            });
        }

        private void BtnTinhTien_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDonGia.Text, out double donGia) || donGia < 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá dịch vụ hợp lệ!", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng khách hợp lệ!", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            double giamGia = 0;
            if (!string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                if (!double.TryParse(txtGiamGia.Text, out giamGia) || giamGia < 0 || giamGia > 100)
                {
                    MessageBox.Show("% Giảm giá phải từ 0 đến 100!", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiamGia.Focus();
                    return;
                }
            }

            double tongTien = (donGia * soLuong) * (100 - giamGia) / 100;
            lblTongTien.Text = "Tổng tiền thanh toán: " + tongTien.ToString("N0") + " VNĐ";
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            lblTongTien.Text = "Tổng tiền thanh toán: 0 VNĐ";
            txtDonGia.Focus();
        }
    }
}