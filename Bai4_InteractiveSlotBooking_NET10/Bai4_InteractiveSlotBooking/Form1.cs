namespace Bai4_InteractiveSlotBooking;

public partial class Form1 : Form
{
    private readonly List<Button> selectedSeats = new();

    public Form1()
    {
        InitializeComponent();
        cboKhungGio.SelectedIndex = 0;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        TaoSoDoChoNgoi();
        CapNhatThongKe();
    }

    private void TaoSoDoChoNgoi()
    {
        tableSeats.Controls.Clear();

        int soThuTu = 1;

        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                Button btn = new();
                btn.Dock = DockStyle.Fill;
                btn.Margin = new Padding(8);
                btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                btn.Text = $"Vị trí {soThuTu}";
                btn.Tag = "Empty";
                btn.BackColor = Color.LightGray;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Click += Seat_Click;

                tableSeats.Controls.Add(btn, col, row);
                soThuTu++;
            }
        }
    }

    private void Seat_Click(object? sender, EventArgs e)
    {
        if (sender is not Button btn) return;

        string state = btn.Tag?.ToString() ?? "Empty";

        if (state == "Booked")
        {
            MessageBox.Show("Vị trí này đã được đặt!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (state == "Selected")
        {
            btn.Tag = "Empty";
            btn.BackColor = Color.LightGray;
            btn.ForeColor = Color.Black;
            selectedSeats.Remove(btn);
        }
        else
        {
            btn.Tag = "Selected";
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.Black;
            selectedSeats.Add(btn);
        }

        CapNhatThongKe();
    }

    private int LayDonGia()
    {
        return cboKhungGio.SelectedIndex == 1 ? 150_000 : 100_000;
    }

    private void CapNhatThongKe()
    {
        lblSoViTriValue.Text = selectedSeats.Count.ToString();
        long tongTien = (long)selectedSeats.Count * LayDonGia();
        lblTamTinhValue.Text = tongTien.ToString("N0") + " VNĐ";
    }

    private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
    {
        CapNhatThongKe();
    }

    private void btnXacNhanDat_Click(object sender, EventArgs e)
    {
        if (selectedSeats.Count == 0)
        {
            MessageBox.Show("Bạn chưa chọn vị trí nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int soLuong = selectedSeats.Count;
        long tongTien = (long)soLuong * LayDonGia();

        DialogResult result = MessageBox.Show(
            $"Xác nhận đặt {soLuong} vị trí?\nTổng tiền: {tongTien:N0} VNĐ",
            "Xác nhận đặt",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result != DialogResult.Yes) return;

        foreach (Button btn in selectedSeats.ToList())
        {
            btn.Tag = "Booked";
            btn.BackColor = Color.IndianRed;
            btn.ForeColor = Color.White;
        }

        selectedSeats.Clear();
        CapNhatThongKe();

        MessageBox.Show("Đặt vị trí thành công!", "Thành công",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnHuyChon_Click(object sender, EventArgs e)
    {
        foreach (Button btn in selectedSeats.ToList())
        {
            btn.Tag = "Empty";
            btn.BackColor = Color.LightGray;
            btn.ForeColor = Color.Black;
        }

        selectedSeats.Clear();
        CapNhatThongKe();
    }
}
