using System.Globalization;

namespace Bai5_DeliveryOrderDashboard;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        KhoiTaoBang();
        cboLoaiVanChuyen.SelectedIndex = 0;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        timerClock.Start();
        CapNhatThoiGian();
        CapNhatTong();
    }

    private void KhoiTaoBang()
    {
        dgvHangHoa.AutoGenerateColumns = false;
        dgvHangHoa.AllowUserToAddRows = false;
        dgvHangHoa.AllowUserToDeleteRows = false;
        dgvHangHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvHangHoa.MultiSelect = true;
        dgvHangHoa.RowHeadersVisible = false;
        dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        dgvHangHoa.Columns.Clear();

        dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "TenHang",
            HeaderText = "Tên hàng",
            FillWeight = 150
        });

        dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "SoLuong",
            HeaderText = "Số lượng",
            FillWeight = 75
        });

        dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "TrongLuong",
            HeaderText = "Trọng lượng (kg)",
            FillWeight = 95
        });

        dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "DonGia",
            HeaderText = "Đơn giá",
            FillWeight = 100
        });

        dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "ThanhTien",
            HeaderText = "Thành tiền",
            ReadOnly = true,
            FillWeight = 110
        });
    }

    private void ThemDongMoi()
    {
        int index = dgvHangHoa.Rows.Add("", 1, 1, 0, 0);
        dgvHangHoa.CurrentCell = dgvHangHoa.Rows[index].Cells["TenHang"];
        dgvHangHoa.BeginEdit(true);
        CapNhatTong();
    }

    private void btnThemDong_Click(object sender, EventArgs e)
    {
        ThemDongMoi();
    }

    private void btnXoaDong_Click(object sender, EventArgs e)
    {
        XoaDongDangChon();
    }

    private void XoaDongDangChon()
    {
        if (dgvHangHoa.SelectedRows.Count == 0)
        {
            MessageBox.Show("Hãy chọn dòng cần xóa!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        foreach (DataGridViewRow row in dgvHangHoa.SelectedRows)
        {
            if (!row.IsNewRow)
                dgvHangHoa.Rows.Remove(row);
        }

        CapNhatTong();
    }

    private bool ThuDocSo(DataGridViewRow row, out int soLuong, out decimal trongLuong, out decimal donGia)
    {
        soLuong = 0;
        trongLuong = 0;
        donGia = 0;

        bool okSoLuong = int.TryParse(Convert.ToString(row.Cells["SoLuong"].Value), out soLuong);
        bool okTrongLuong = decimal.TryParse(Convert.ToString(row.Cells["TrongLuong"].Value), out trongLuong);
        bool okDonGia = decimal.TryParse(Convert.ToString(row.Cells["DonGia"].Value), out donGia);

        return okSoLuong && okTrongLuong && okDonGia;
    }

    private bool KiemTraDong(DataGridViewRow row, bool hienThongBao)
    {
        row.Cells["SoLuong"].ErrorText = "";
        row.Cells["TrongLuong"].ErrorText = "";

        if (!ThuDocSo(row, out int soLuong, out decimal trongLuong, out decimal donGia))
        {
            if (hienThongBao)
                errorProvider.SetError(dgvHangHoa, "Số lượng, trọng lượng và đơn giá phải là số.");
            return false;
        }

        if (soLuong <= 0)
        {
            row.Cells["SoLuong"].ErrorText = "Số lượng phải lớn hơn 0";
            errorProvider.SetError(dgvHangHoa, "Có dòng có Số lượng không hợp lệ.");
            return false;
        }

        if (trongLuong <= 0)
        {
            row.Cells["TrongLuong"].ErrorText = "Trọng lượng phải lớn hơn 0";
            errorProvider.SetError(dgvHangHoa, "Có dòng có Trọng lượng không hợp lệ.");
            return false;
        }

        if (donGia < 0)
        {
            errorProvider.SetError(dgvHangHoa, "Đơn giá không được âm.");
            return false;
        }

        return true;
    }

    private void TinhThanhTienDong(DataGridViewRow row)
    {
        if (!ThuDocSo(row, out int soLuong, out _, out decimal donGia))
        {
            row.Cells["ThanhTien"].Value = 0;
            return;
        }

        decimal thanhTien = soLuong * donGia;
        row.Cells["ThanhTien"].Value = thanhTien;
    }

    private void CapNhatTong()
    {
        int tongSoLuong = 0;
        decimal tongTrongLuong = 0;
        decimal tongTien = 0;
        bool coLoi = false;

        foreach (DataGridViewRow row in dgvHangHoa.Rows)
        {
            if (row.IsNewRow) continue;

            TinhThanhTienDong(row);

            if (!KiemTraDong(row, false))
            {
                coLoi = true;
                continue;
            }

            ThuDocSo(row, out int soLuong, out decimal trongLuong, out decimal donGia);

            tongSoLuong += soLuong;
            tongTrongLuong += trongLuong;
            tongTien += soLuong * donGia;
        }

        if (!coLoi)
            errorProvider.SetError(dgvHangHoa, "");

        tslTongSoLuong.Text = $"Tổng SL: {tongSoLuong}";
        tslTongTrongLuong.Text = $"Tổng TL: {tongTrongLuong:N2} kg";
        tslTongTien.Text = $"Tổng tiền: {tongTien:N0} VNĐ";
    }

    private void dgvHangHoa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];
        KiemTraDong(row, true);
        TinhThanhTienDong(row);
        CapNhatTong();
    }

    private void dgvHangHoa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        CapNhatTong();
    }

    private void dgvHangHoa_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
        CapNhatTong();
    }

    private void dgvHangHoa_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        e.ThrowException = false;
        MessageBox.Show("Giá trị nhập vào không hợp lệ!", "Lỗi dữ liệu",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F2)
        {
            ThemDongMoi();
            e.Handled = true;
        }
        else if (e.KeyCode == Keys.Delete)
        {
            XoaDongDangChon();
            e.Handled = true;
        }
    }

    private void timerClock_Tick(object sender, EventArgs e)
    {
        CapNhatThoiGian();
    }

    private void CapNhatThoiGian()
    {
        tslClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    }
}
